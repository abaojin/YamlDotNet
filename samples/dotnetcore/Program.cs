﻿using System;
using YamlDotNet.Serialization;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serializer = new Serializer();
            serializer.Serialize(Console.Out, new { hello = "world" });
        }
    }
}
