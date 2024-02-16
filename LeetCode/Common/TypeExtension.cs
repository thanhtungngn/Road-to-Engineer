namespace Common
{
    public static class TypeExtension
    {
        public static string Print(this int[] array)
        {
            var result = String.Join(", ", array);
            return result;

        }

        public static string Print(this long[] array)
        {
            var result = String.Join(", ", array);
            return result;

        }

        public static string Print(this int[][] array)
        {
            var result = string.Empty;
            for (int i = 0; i < array.Length; i++) {
                if (array[i] != null )
                {
                    result += string.Join(", ", array[i]) + "\n";

                }
            }
            return result;
        }
    }

}
