using System;

namespace CSharpAdvanced
{
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index] => throw new NotImplementedException();
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }
}