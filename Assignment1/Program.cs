namespace Assignment1
{
    internal class Program
    {
        static void Task2()
        {
            int a, b;
            Console.WriteLine("enter first number");
            Int32.TryParse(Console.ReadLine(),out a);
            Console.WriteLine("enter second number");
            Int32.TryParse(Console.ReadLine(),out b);
            Console.WriteLine($"addition : {a+b}");
            Console.WriteLine($"subtraction : {a-b}");
            Console.WriteLine($"product : {a * b}");
            Console.WriteLine($"quotient : {a / b}");

        }
        static void Task3()
        {
            int a, b;
            Console.WriteLine("enter first number");
            Int32.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("enter second number");
            Int32.TryParse(Console.ReadLine(), out b);
            char choice;
            Console.WriteLine("Enter Choice i.e + - * /");
            char.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case '+':
                    Console.WriteLine($"addition : {a + b}");
                    break;
                case '-':
                    Console.WriteLine($"subtraction : {a - b}");
                    break;
                case '*':
                    Console.WriteLine($"product : {a * b}");
                    break;
                case '/':
                    Console.WriteLine($"quotient : {a / b}");
                    break;
                default:
                    Console.WriteLine("wront input, try +,-,*,/");
                    break;
            }

        }
        static void Task4()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Abhay Kumar");
            }
        }
        static void Task5()
        {
            Console.WriteLine("enter ending range");
            int end;
            Int32.TryParse(Console.ReadLine(), out end);
            //dowhile loop
            int i = 0;
            do
            {
                if (i % 2 == 0)
                {
                    Console.Write(i+" ");
                }
                i++;                
            }while(i < end);

            //while loop
            i = 0;
            while (i < end)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
                i++;
            }
            //for Loop
            for(int j = 0; j < end; j++)
            {
                if(j % 2 == 0)
                {
                    Console.WriteLine(j+" ");
                }
            }
        }
        static void Task6()
        {
            Console.WriteLine("enter ending range");
            int end;
            Int32.TryParse(Console.ReadLine(), out end);
            //dowhile loop
            int i = 0;
            do
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
                i++;
            } while (i < end);

            //while loop
            i = 0;
            while (i < end)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
                i++;
            }
            //for Loop
            for (int j = 0; j < end; j++)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j + " ");
                }
            }
        }
        static void Task7()
        {
            Console.WriteLine("enter number");
            int num;
            Int32.TryParse(Console.ReadLine(), out num);
            //dowhile loop
            int i = 1;
            do
            {
                Console.WriteLine($"{num} * {i} = {num*i}");

            } while (i <= 10);

            //while loop
            i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"{num} * {i} = {num*i}");
                i++;
            }
            //for Loop
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{num} * {j} = {num*j}");
            }
        }
        static void Task8()
        {
            int num1, num2, num3, num4;
            num1 = 31;
            num2 = 14;
            num3 = 51;
            num4 = 21;
            Console.WriteLine($"{num1} {num2} {num3} {num4}");
        }
        static void Task9()
        {
            int num1, num2, num3, num4;
            num1 = 31;
            num2 = 14;
            num3 = 51;
            num4 = 21;
            Console.WriteLine($"{num1}\n{num2}\n{num3}\n{num4}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();
            Task9();
        }
    }
}