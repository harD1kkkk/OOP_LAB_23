public class Lab23_1 {

    interface IInterface<T> {
        void setValue(T value);
        T getValue();
    }

    static class MyClass<T> implements IInterface<T> {
        private T value;

        public void setValue(T value) {
            this.value = value;
        }

        public T getValue() {
            return value;
        }
    }

    public static void run() {
        MyClass<Integer> obj = new MyClass<>();
        obj.setValue(100);
        System.out.println(obj.getValue());
    }
}
