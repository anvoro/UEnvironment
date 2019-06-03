using UnityEngine;

namespace PluginsEnvironment
{
    public static partial class Extentions
    {
        public static int Clamp_0_100(this int i)
        {
            if (i > 100)
                return 100;

            if (i < 0)
                return 0;

            return i;
        }

        public static int Clamp_0_MAX(this int i)
        {
            return i < 0 ? 0 : i;
        }

        public static bool GetChance(this int chance)
        {
            return Random.Range(0, 100) < chance;
        }

        public static float ToPercent(this int percent)
        {
            return (float)percent / 100;
        }
    }
}
