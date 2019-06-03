using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Random = UnityEngine.Random;

namespace PluginsEnvironment
{
    public static partial class Extentions
    {
        public static T DeepCopy<T>(this T source)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable.", nameof(source));
            }

            if (ReferenceEquals(source, null))
            {
                return default(T);
            }

            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream stream = new MemoryStream())
            {
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }

        public static int GetRange(int min, int max)
        {
            return Random.Range(min, max + 1);
        }
    }
}
