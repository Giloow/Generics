namespace Generics
{
    internal class ReplaceAWith6Block : IBlock<string>
    {
        public string Process(string input)
        {
            return input.Replace('A', '6');
        }
    }
}
