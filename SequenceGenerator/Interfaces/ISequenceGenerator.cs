namespace SequenceGenerator.Interfaces {
    public interface ISequenceGenerator {
        public List<string> GenerateSequence(int n);
        public void AddRule(string value, Func<int, bool> expression);
    }
}
