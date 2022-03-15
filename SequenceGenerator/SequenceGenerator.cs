using SequenceGenerator.Interfaces;
using System.Linq.Expressions;

namespace SequenceGenerator {
    public class SequenceGenerator : ISequenceGenerator{

        private Dictionary<string, Func<int, bool>> rules;

        public SequenceGenerator() { 
            rules = new Dictionary<string, Func<int, bool>>();
        }

        public List<string> GenerateSequence(int n) {
            var list = new List<string>();
            for (int i = 1; i <= n; i++) {
                list.Add(ProcessNumber(i));
            }
            return list;
        }

        public void AddRule(string value, Func<int, bool> expression) {
            rules.Add(value, expression);
        }

        private string ProcessNumber(int number) {
            foreach (var rule in rules) {
                if (rule.Value.Invoke(number)) {
                    return rule.Key;
                }
            }
            return number.ToString();
        }
    }
}
