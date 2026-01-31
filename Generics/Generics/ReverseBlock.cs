namespace Generics
{
    internal class ReverseBlock : IBlock<string>
    {
        public string Process(string input)
        {
            return string.Concat(input.Reverse());
        }
    }
}
