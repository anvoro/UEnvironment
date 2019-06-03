using System;
using System.Collections.Generic;

namespace PluginsEnvironment
{
    public static partial class Extentions
    {
        public static IEnumerable<T> GetEnumValues<T>() where T : struct
        {
            return (T[])Enum.GetValues(typeof(T));
        }

        public static string[] GetEnumNames<T>() where T : struct
        {
            return Enum.GetNames(typeof(T));
        }
    }
}
