namespace Generics
{
    internal class UpperCaseBlock : IBlock<string>
    {
        public string Process(string input)
        {
            return input.ToUpper();
        }
    }
}
