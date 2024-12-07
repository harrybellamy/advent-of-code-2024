namespace Common
{
    public static class EnumerableExtensions
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

        public static IEnumerable<T> WithoutItemAtIndex<T>(this IEnumerable<T> enumerable, int index)
        {
            if (enumerable.Count() <= index)
            {
                throw new ArgumentException(
                    $"Cannot remove item at index {index} as it is beyond the bounds of the enumerable.",
                    nameof(index));
            }

            var retval = new List<T>();
            for (var i = 0; i < enumerable.Count(); i++)
            {
                if (i != index)
                { 
                    retval.Add(enumerable.ElementAt(i));
                }
            }

            return retval;
        }
    }
}
