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
    }
}
