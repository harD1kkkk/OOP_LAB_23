namespace Lab_23
{
    public class Lab23_1
    {
        public interface IInterface<T>
        {
            void SetValue(T value);
            T GetValue();
        }

        public class MyClass<T> : IInterface<T>
        {
            private T value;

            public void SetValue(T value)
            {
                this.value = value;
            }

            public T GetValue()
            {
                return value;
            }
        }

        public static void Run()
        {
            var obj = new MyClass<int>();
            obj.SetValue(100);
            Console.WriteLine(obj.GetValue());
        }
    }
}
