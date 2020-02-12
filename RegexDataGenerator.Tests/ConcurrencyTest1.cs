﻿using System.Threading;
using Xunit;

namespace RegexDataGenerator.Tests
{
    public class ConcurrencyTests1
    {
        [Fact]
        public void Test1()
        {
            var generator = new RegExpDataGenerator("[0-9]{4}");
            for (var i = 0; i < 100; i++)
            {
                var code = generator.Next();
                Thread.Sleep(10);
            }
        }
    }
}