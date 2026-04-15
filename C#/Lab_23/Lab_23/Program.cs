namespace Lab_23
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1 - Lab15_1");
                Console.WriteLine("2 - Lab15_2");
                Console.WriteLine("0 - Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Lab23_1.Run();
                        break;

                    case 2:
                        Lab23_2.Run();
                        break;

                    case 0:
                        return;
                }
            }
        }
    }
}
