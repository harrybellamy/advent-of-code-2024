namespace Day1
{
    internal static class EnumerableExtensions
    {
        public static MultiSet<T> AsMultiSet<T>(this IEnumerable<T> enumerable) where T : notnull
        { 
            var retval = new MultiSet<T>();

            foreach (var item in enumerable)
            { 
                retval.Add(item);
            }

            return retval;
        }
    }
}
