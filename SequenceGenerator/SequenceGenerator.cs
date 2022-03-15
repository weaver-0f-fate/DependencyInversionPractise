using SequenceGenerator.Interfaces;

namespace SequenceGenerator {
    public class SequenceGenerator : ISequenceGenerator{

        public List<string> GenerateSequence(int n) {
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
