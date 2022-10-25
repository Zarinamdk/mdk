namespace MDK.Lab1
{
    public class Lab1 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>    
        public void Demo()
        {
            // ход лабы
            Console.WriteLine();
            Task1();
            Console.WriteLine();
            Task2();
            Console.WriteLine();
            Task3();
            Console.WriteLine();
            Task4();
            Console.WriteLine();

            static void Task1()
            {
                Console.WriteLine("Задача 1");
                double a = (Math.Pow(2, 2) - Math.Pow(3, 3));
                double b = Math.Sqrt((Math.Pow(3, 4) - Math.Pow(2, 4)));
                double c = Math.Abs((Math.Pow(3, 5) - Math.Pow(15, 2.5)));
                double d = Math.Sqrt((a / b) + c);
                Console.WriteLine(d);
            }

            static void Task2()
            {
                Console.WriteLine("Задача 2");
                Random rand = new Random();
                double a = rand.Next(-25, 25);
                double b = rand.Next(-25, 25);
                double c = (Math.Pow(a, 2) + Math.Pow(b, (1 / 3))) / (a + b);
                Console.WriteLine(c);
            }

            static void Task3()
            {
                Console.WriteLine("Задача 3");
                double a = 5.93576;
                int b = (int)a;
                double c = Math.Round(a);
                int d = (int)Math.Floor(a);
                double e = Math.Round(a, 1);
                int f = 5;
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(d);
                Console.WriteLine(e);
                Console.WriteLine(f++);//5
                                       //+1
                                       //+1
                Console.WriteLine(++f);//7
            }

            static void Task4()
            {
                Console.WriteLine("Задача 4");
                Random rand1 = new Random();
                double k = rand1.NextDouble() + rand1.Next(-25, 25);
                Console.WriteLine(k);
            }
        }

        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Задания лабы №1";
        }

        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 1;
        }

        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        public string Title()
        {
            return "Лабораторная №1. Тема: Арифметические операции. Классы Random и Math. Приведение числовых типов данных. Округление. Суффиксы и префиксы";
        }
    }
}
