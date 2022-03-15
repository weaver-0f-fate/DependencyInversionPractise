using System;
using SequenceGenerator;

namespace DependencyInversionPractise
{
    public class Program {
        public static void Main(string[] args) {
            var sequenceGenerator = new SequenceGenerator.SequenceGenerator();

            var result = sequenceGenerator.GenerateSequence(20);
            foreach (var item in result) { 
                Console.WriteLine(item);
            }
        }

        
    }
}