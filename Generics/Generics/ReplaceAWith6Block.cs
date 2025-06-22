namespace Generics
{
    internal class ReplaceAWith6Block : IBlock<string>
    {
        public string Process(string input)
        {
            int indexOfA = input.IndexOf('A');
            while (indexOfA != -1)
            {
                input = input.Remove(indexOfA, 1);
                input = input.Insert(indexOfA, "6");
                indexOfA = input.IndexOf('A');
            }

            return input;
        }
    }
}
