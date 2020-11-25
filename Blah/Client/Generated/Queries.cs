using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Blah.Client
{
    public class Queries
        : IDocument
    {
        private readonly byte[] _hashName = new byte[]
        {
            109,
            100,
            53,
            72,
            97,
            115,
            104
        };
        private readonly byte[] _hash = new byte[]
        {
            70,
            80,
            121,
            67,
            70,
            119,
            54,
            113,
            105,
            80,
            56,
            74,
            88,
            85,
            109,
            97,
            76,
            103,
            87,
            84,
            85,
            65,
            61,
            61
        };
        private readonly byte[] _content = new byte[]
        {
            113,
            117,
            101,
            114,
            121,
            32,
            71,
            101,
            116,
            80,
            114,
            111,
            100,
            117,
            99,
            116,
            115,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            112,
            114,
            111,
            100,
            117,
            99,
            116,
            115,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            105,
            100,
            32,
            116,
            105,
            116,
            108,
            101,
            32,
            112,
            114,
            105,
            99,
            101,
            32,
            125,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Queries Default { get; } = new Queries();

        public override string ToString() => 
            @"query GetProducts {
              products {
                id
                title
                price
              }
            }";
    }
}
