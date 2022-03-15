namespace SequenceGenerator.Interfaces {
    internal interface ISequenceRule {
        internal bool TryApplyRule(int number, out string value);
    }
}
