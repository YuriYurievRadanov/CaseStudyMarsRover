using System;

namespace MarsRover.Common
{
    public static class Extensions
    {
        public static T Next<T>(this T src) where T : struct
        {
            if (typeof(T).IsEnum)
            {
                T[] Arr = (T[])Enum.GetValues(src.GetType());

                int j = Array.IndexOf(Arr, src) - 1;
                j = j < 0 ? j + Arr.Length : j;
                return (Arr.Length == j) ? Arr[0] : Arr[j];
            }

            throw new ArgumentException(String.Format("Argument {0} is not an Enum", typeof(T).FullName));
        }

        public static T Previous<T>(this T src) where T : struct
        {
            if (typeof(T).IsEnum)
            {
                T[] Arr = (T[])Enum.GetValues(src.GetType());
                int j = Array.IndexOf<T>(Arr, src) + 1;
                return (Arr.Length == j) ? Arr[0] : Arr[j];
            }

            throw new ArgumentException(string.Format("Argument {0} is not an Enum", typeof(T).FullName));
        }
    }
}