using System;

namespace PluginsEnvironment
{
    public static partial class Extentions
    {
        public static T GetEnum<T>(this string s)
        {
            return (T)Enum.Parse(typeof(T), s);
        }

        public static float ToFloat(this string s)
        {
            return string.IsNullOrEmpty(s) ? 0 : float.Parse(s);
        }

        public static int ToInt(this string s)
        {
            return string.IsNullOrEmpty(s) ? 0 : int.Parse(s);
        }

        public static bool ToBool(this string s)
        {
            return !string.IsNullOrEmpty(s) && bool.Parse(s);
        }

        public static string F(this string str, params object[] args)
        {
            return string.Format(str, args);
        }

        public static string F(this string str, string s1)
        {
            return string.Format(str, s1);
        }

        public static string F(this string str, string s1, string s2)
        {
            return string.Format(str, s1, s2);
        }

        public static string F(this string str, string s1, string s2, string s3)
        {
            return string.Format(str, s1, s2, s3);
        }

        public static string F(this string str, string s1, string s2, string s3, string s4)
        {
            return string.Format(str, s1, s2, s3, s4);
        }
    }
}
