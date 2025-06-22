namespace Generics
{
    internal class ReverseBlock : IBlock<string>
    {
        public string Process(string input)
        {
            string reversed = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            return reversed;
        }
    }
}
