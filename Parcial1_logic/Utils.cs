using System.Collections.Generic;
using System.Linq;

namespace Parcial1_logic
{
    public static class Utils
    {
        /// <summary>
        /// Ordena ascendentemente la lista
        /// </summary>
        /// <param name="list">Lista a ordenar</param>
        public static void SortAscending(this List<int> list)
        {
            list.Sort((x, y) => x.CompareTo(y));
        }

        /// <summary>
        /// Ordena ascendentemente la lista
        /// </summary>
        /// <param name="list">Lista a ordenar</param>
        public static void SortAscending(this List<string> list)
        {
            list.Sort((x, y) => x.CompareTo(y) * -1);
        }

        /// <summary>
        /// Ordena ascendentemente la lista
        /// </summary>
        /// <param name="list">Lista a ordenar</param>
        public static void SortAscending(this List<char> list)
        {
            list.Sort((x, y) => x.CompareTo(y));
        }

        /// <summary>
        /// Ordena descendentemente la lista
        /// </summary>
        /// <param name="list">Lista a ordenar</param>
        public static void SortDescending(this List<int> list)
        {
            list.Sort((x, y) => x.CompareTo(y) * -1);
        }

        /// <summary>
        /// Ordena descendentemente la lista
        /// </summary>
        /// <param name="list">Lista a ordenar</param>
        public static void SortDescending(this List<string> list)
        {
            list.Sort((x, y) => x.CompareTo(y) * -1);
        }

        /// <summary>
        /// Ordena descendentemente la lista
        /// </summary>
        /// <param name="list">Lista a ordenar</param>
        public static void SortDescending(this List<char> list)
        {
            list.Sort((x, y) => x.CompareTo(y) * -1);
        }

        public static List<T> ToList<T>(this Queue<T> queue)
        {
            return queue.OfType<T>().ToList();
        }

        public static Queue<string> ToQueueOfString<T>(this Queue<T> sourceQueue)
        {
            Queue<string> result = new Queue<string>();

            while (result.Count < sourceQueue.Count)
            {
                T currentValue = sourceQueue.Dequeue();
                result.Enqueue(currentValue.ToString());
                sourceQueue.Enqueue(currentValue);
            }

            return result;
        }
    }
}