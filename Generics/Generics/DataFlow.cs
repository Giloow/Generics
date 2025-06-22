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
            _blocks.Add(block);
        }

        public T RunFlow(T input)
        {
            T result = input;
            for(int i = 0; i < _blocks.Count; i++)
            {
                result = _blocks[i].Process(result);
            }
            return result;
        }
    }
}
