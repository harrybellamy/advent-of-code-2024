namespace Common
{
    public class MultiSet<T> where T : notnull
    {
        private readonly Dictionary<T, int> keyValuePairs = [];

        public IEnumerable<T> UniqueItems => keyValuePairs.Keys;

        public void Add(T item) 
        {
            if (!keyValuePairs.TryAdd(item, 1))
            {
                keyValuePairs[item] += 1;
            }
        }

        public int Count(T item)
        {
            if (keyValuePairs.TryGetValue(item, out int count))
            {
                return count;
            }

            return 0;
        }
    }
}
