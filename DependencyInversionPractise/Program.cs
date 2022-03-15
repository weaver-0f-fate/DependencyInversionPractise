using System;

namespace DependencyInversionPractise
{
    public class Program {
        public static void Main(string[] args) {
            var result = GenerateList(20);
            foreach (var item in result) { 
                Console.WriteLine(item);
            }
        }

        private static List<string> GenerateList(int n) {
            var list = new List<string>();
            for (int i = 1; i <= n; i++) {
                list.Add(ProcessNumber(i));
            }
            return list;
        }

        private static string ProcessNumber(int number) {
            if (number % 3 == 0 && number % 5 == 0) {
                return "FizzBuzz";
            }
            if (number % 3 == 0) {
                return "Fizz";
            }
            if (number % 5 == 0) {
                return "Buzz";
            }
            return number.ToString();
        }
    }
}