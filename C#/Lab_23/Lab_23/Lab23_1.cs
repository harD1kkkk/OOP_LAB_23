using System;

namespace Lab_23
{
    public class Lab23_1
    {
        public abstract class Figure
        {
            public abstract double GetArea();
            public abstract double GetPerimeter();
        }

        public class Rectangle : Figure
        {
            public double Width, Height;

            public Rectangle(double w, double h)
            {
                Width = w;
                Height = h;
            }

            public override double GetArea() => Width * Height;
            public override double GetPerimeter() => 2 * (Width + Height);
        }

        public class Circle : Figure
        {
            public double Radius;

            public Circle(double r)
            {
                Radius = r;
            }

            public override double GetArea() => Math.PI * Radius * Radius;
            public override double GetPerimeter() => 2 * Math.PI * Radius;
        }

        public class Trapezium : Figure
        {
            public double A, B, C, D, Height;

            public Trapezium(double a, double b, double c, double d, double h)
            {
                A = a; B = b; C = c; D = d; Height = h;
            }

            public override double GetArea() => (A + B) / 2 * Height;
            public override double GetPerimeter() => A + B + C + D;
        }

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
            Figure f1 = new Rectangle(5, 4);
            Figure f2 = new Circle(3);
            Figure f3 = new Trapezium(3, 5, 4, 4, 2);

            var obj = new MyClass<Figure>();

            obj.SetValue(f1);
            Console.WriteLine(obj.GetValue().GetArea());

            obj.SetValue(f2);
            Console.WriteLine(obj.GetValue().GetPerimeter());

            obj.SetValue(f3);
            Console.WriteLine(obj.GetValue().GetArea());
        }
    }
}
