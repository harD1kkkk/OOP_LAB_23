public class Lab23_2 {

    interface IInterface {
        <T1, T2> String getInfo(T1 value1, T2 value2);
    }

    static class CInfo implements IInterface {

        public <T1, T2> String getInfo(T1 value1, T2 value2) {
            return "Value1: " + value1 +
                    ", Type1: " + value1.getClass().getSimpleName() +
                    " | Value2: " + value2 +
                    ", Type2: " + value2.getClass().getSimpleName();
        }
    }

    public static void run() {
        IInterface info = new CInfo();

        System.out.println(info.getInfo(5, "Hello"));
        System.out.println(info.getInfo(3.14, true));
    }
}
