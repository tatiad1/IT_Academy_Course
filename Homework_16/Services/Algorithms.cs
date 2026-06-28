namespace Homework_16.Services
{
    internal class Algorithms
    {
        public static IEnumerable<T> Where<T>(IEnumerable<T> collection, Predicate<T> pred)
        {
            foreach (T item in collection)
            {
                if (pred(item))
                {
                    yield return item;
                }
            }
        }
        public static IEnumerable<T> OrderBy<T, TKey>(IEnumerable<T> collection, Func<T, TKey> keySelector) where TKey : IComparable<TKey>
        {
            List<T> list = collection.ToList();

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (keySelector(list[i]).CompareTo(keySelector(list[j])) > 0)
                    {
                        T temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }

            return list;
        }
        public static T First<T>(IEnumerable<T> collection, Predicate<T> pred)
        {
            foreach (T item in collection)
            {
                if (pred(item))
                {
                    return item;
                }
            }

            throw new Exception("Sequence contains no such element.");
        }
        public static T FirstOrDefault<T>(IEnumerable<T> collection, Predicate<T> pred)
        {
            foreach (T item in collection)
            {
                if (pred(item))
                {
                    return item;
                }
            }

            return default(T);
        }
        public static T Single<T>(IEnumerable<T> collection, Predicate<T> pred)
        {
            bool found = false;
            T result = default;

            foreach (T item in collection)
            {
                if (pred(item))
                {
                    if (found)
                    {
                        throw new Exception("More than one matching element.");
                    }

                    found = true;
                    result = item;
                }
            }

            if (!found)
            {
                throw new Exception("No matching element.");
            }

            return result;
        }
        public static T SingleOrDefault<T>(IEnumerable<T> collection, Predicate<T> pred)
        {
            bool found = false;
            T result = default;

            foreach (T item in collection)
            {
                if (pred(item))
                {
                    if (found)
                    {
                        throw new Exception("More than one matching element.");
                    }

                    found = true;
                    result = item;
                }
            }

            return result;
        }
        public static bool Any<T>(IEnumerable<T> collection, Predicate<T> pred)
        {
            foreach (T item in collection)
            {
                if (pred(item))
                {
                    return true;
                }
            }

            return false;
        }
        public static bool All<T>(IEnumerable<T> collection, Predicate<T> pred)
        {
            foreach (T item in collection)
            {
                if (!pred(item))
                {
                    return false;
                }
            }

            return true;
        }
        public static int Count<T>(IEnumerable<T> collection, Predicate<T> pred)
        {
            int count = 0;
            foreach (T item in collection)
            {
                if (pred(item))
                {
                    count++;
                }
            }

            return count;
        }

        public static IEnumerable<T> Distinct<T>(IEnumerable<T> collection)
        {
            List<T> unique = new List<T>();

            foreach (T item in collection)
            {
                if (!unique.Contains(item))
                {
                    unique.Add(item);
                    yield return item;
                }
            }
        }
    }
}
