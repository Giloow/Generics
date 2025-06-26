namespace Generics
{
    internal class DataFlow<T> : IDataFlow<T> where T : class
    {
        private readonly List<IBlock<T>> _blocks;

        public DataFlow()
        {
            _blocks = new List<IBlock<T>>();
        }

        public void AddBlock(IBlock<T> block)
        {
            if (block != null)
            {
                _blocks.Add(block);
            }
        }

        public T RunFlow(T input)
        {
            if (input == null)
            {
                return default;
            }

            T result = input;
            foreach (IBlock<T> block in _blocks)
            {
                result = block.Process(result);
            }

            return result;
        }
    }
}
