namespace delegaty
{
    public delegate void MySampleDelegate(int number);
    public static class MyDelegate
    {
        public static MySampleDelegate mySampleDelegate;
        public static void Main()
        {
            mySampleDelegate += SampleMethod;
            mySampleDelegate?.Invoke(10);
        }

        public static void SampleMethod(int number) {
        Console.WriteLine("Podana liczba: "+number);
        }
    }

}