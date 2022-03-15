using SequenceGenerator.Interfaces;

namespace DependencyInversionPractise
{
    public class Program {
        public static void Main(string[] args) {
            ISequenceGenerator sequenceGenerator = new SequenceGenerator.SequenceGenerator();

            sequenceGenerator.AddRule("FizzBuzz", x => x % 3 == 0 && x % 5 == 0);
            sequenceGenerator.AddRule("Fizz", x => x % 3 == 0);
            sequenceGenerator.AddRule("Buzz", x => x % 5 == 0);


            var result = sequenceGenerator.GenerateSequence(20);
            foreach (var item in result) { 
                Console.WriteLine(item);
            }
        }

        
    }
}