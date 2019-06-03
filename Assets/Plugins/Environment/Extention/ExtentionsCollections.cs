using System;
using System.Collections.Generic;
using System.Linq;
using Random = UnityEngine.Random;

namespace PluginsEnvironment
{
    public static partial class Extentions
    {
        public static T GetIndexOrNearest<T>(this List<T> list, int index)
        {
            if (list.Count >= index + 1)
            {
                return list[index];
            }

            for (int i = index; i >= 0; i--)
            {
                if (list.Count == i + 1)
                {
                    return list[i];
                }
            }

            throw new Exception("Error, list is empty!");
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;

            while (n > 1)
            {
                n--;
                int k = Random.Range(0, n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static bool ContainsType<T>(this List<T> collection, Type type)
        {
            return collection.Any(i => i.GetType() == type);
        }

        public static void NullableRemove<T>(this List<T> collection, T item)
        {
            if (item != null)
            {
                collection.Remove(item);
            }
        }

        public static T GetRandElement<T>(this List<T> list)
        {
            return list[Random.Range(0, list.Count)];
        }

        public static T[,] CloneEx<T>(this T[,] array)
        {
            return array.Clone() as T[,];
        }
    }
}
