using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using StrawberryShake;
using StrawberryShake.Http;

namespace Blah.Client
{
    public class GetProductsResultParser
        : JsonResultParserBase<IGetProducts>
    {
        private readonly IValueSerializer _intSerializer;
        private readonly IValueSerializer _stringSerializer;

        public GetProductsResultParser(IEnumerable<IValueSerializer> serializers)
        {
            IReadOnlyDictionary<string, IValueSerializer> map = serializers.ToDictionary();

            if (!map.TryGetValue("Int", out IValueSerializer serializer))
            {
                throw new ArgumentException(
                    "There is no serializer specified for `Int`.",
                    nameof(serializers));
            }
            _intSerializer = serializer;

            if (!map.TryGetValue("String", out  serializer))
            {
                throw new ArgumentException(
                    "There is no serializer specified for `String`.",
                    nameof(serializers));
            }
            _stringSerializer = serializer;
        }

        protected override IGetProducts ParserData(JsonElement data)
        {
            return new GetProducts
            (
                ParseGetProductsProducts(data, "products")
            );

        }

        private IReadOnlyList<IProduct> ParseGetProductsProducts(
            JsonElement parent,
            string field)
        {
            if (!parent.TryGetProperty(field, out JsonElement obj))
            {
                return null;
            }

            if (obj.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            int objLength = obj.GetArrayLength();
            var list = new IProduct[objLength];
            for (int objIndex = 0; objIndex < objLength; objIndex++)
            {
                JsonElement element = obj[objIndex];
                list[objIndex] = new Product
                (
                    DeserializeInt(element, "id"),
                    DeserializeNullableString(element, "title"),
                    DeserializeInt(element, "price")
                );

            }

            return list;
        }

        private int DeserializeInt(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (int)_intSerializer.Deserialize(value.GetInt32());
        }

        private string DeserializeNullableString(JsonElement obj, string fieldName)
        {
            if (!obj.TryGetProperty(fieldName, out JsonElement value))
            {
                return null;
            }

            if (value.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return (string)_stringSerializer.Deserialize(value.GetString());
        }
    }
}
