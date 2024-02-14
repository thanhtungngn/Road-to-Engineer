namespace Common
{
    public static class TypeExtension
    {
        public static string ToString(this int[] array)
        {
            var result = String.Join(", ", array);
            return result;

        }      
    }
}
