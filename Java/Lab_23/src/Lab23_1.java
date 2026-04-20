public class Lab23_1 {

    abstract static class Figure {
        abstract double getArea();
        abstract double getPerimeter();
    }

    static class Rectangle extends Figure {
        double width, height;

        Rectangle(double w, double h) {
            width = w;
            height = h;
        }

        double getArea() {
            return width * height;
        }

        double getPerimeter() {
            return 2 * (width + height);
        }
    }

    static class Circle extends Figure {
        double radius;

        Circle(double r) {
            radius = r;
        }

        double getArea() {
            return Math.PI * radius * radius;
        }

        double getPerimeter() {
            return 2 * Math.PI * radius;
        }
    }

    static class Trapezium extends Figure {
        double a, b, c, d, height;

        Trapezium(double a, double b, double c, double d, double h) {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.height = h;
        }

        double getArea() {
            return (a + b) / 2 * height;
        }

        double getPerimeter() {
            return a + b + c + d;
        }
    }

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
        Figure f1 = new Rectangle(5, 4);
        Figure f2 = new Circle(3);
        Figure f3 = new Trapezium(3, 5, 4, 4, 2);

        MyClass<Figure> obj = new MyClass<>();

        obj.setValue(f1);
        System.out.println(obj.getValue().getArea());

        obj.setValue(f2);
        System.out.println(obj.getValue().getPerimeter());

        obj.setValue(f3);
        System.out.println(obj.getValue().getArea());
    }
}
