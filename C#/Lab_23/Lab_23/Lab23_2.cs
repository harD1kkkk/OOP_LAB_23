namespace Lab_23
{
    public class Lab23_2
    {
        public interface IInterface
        {
            string GetInfo<T1, T2>(T1 value1, T2 value2);
        }

        public class CInfo : IInterface
        {
            public string GetInfo<T1, T2>(T1 value1, T2 value2)
            {
                return $"Value1: {value1}, Type1: {typeof(T1).Name} | " +
                       $"Value2: {value2}, Type2: {typeof(T2).Name}";
            }
        }

        public static void Run()
        {
            IInterface info = new CInfo();
            Console.WriteLine(info.GetInfo(5, "Hello"));
            Console.WriteLine(info.GetInfo(3.14, true));
        }
    }
}
