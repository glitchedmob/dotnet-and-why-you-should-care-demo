
// This file was auto-generated by ML.NET Model Builder.

using System;
using System.IO;

namespace SentimentModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Traning model...");

            Model.Train(Path.GetFullPath("SentimentModel.mlnet"));

            Console.WriteLine("Model trained");
        }
    }
}
