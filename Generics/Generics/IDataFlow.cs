namespace Generics
{
    public interface IDataFlow<T> where T : class
    {
        T RunFlow(T input);
        void AddBlock(IBlock<T> block);
    }
}
