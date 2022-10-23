
namespace MDK.Lab6
{
    public class Lab6 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>    
        public void Demo()
        {
            //ход лабы
            Console.WriteLine();
            Console.WriteLine("Задание №1");
            Console.Write("Введите факториал: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Факториал числа " + n + " равен: " + Task1(n));
            Console.WriteLine();
            Console.WriteLine("Задание №2");
            Task2();
            Console.WriteLine();


            static int Task1(int n)
            {
                if (n > 0)
                {
                    int result;
                    if (n == 1)
                        return 1;
                    result = Task1(n - 1) * n;
                    return result;
                }
                else
                    throw new Exception();
            }

            static void Task2()
            {
                Console.WriteLine("Введите порядковый номер числа Фибоначчи");
                int f = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Числа Фибоначчи: ");
                for (int i = 0; i < f; i++)
                {
                    Console.Write(Task3(i) + " ");
                }
                Console.WriteLine();
            }

            static int Task3(int f)
            {
                    if (f >= 0)
                    {
                        if (f < 2)
                            return f;
                        else
                            return (Task3(f - 1) + Task3(f - 2));
                    }
                    else
                        throw new Exception();
                
            }
        }

        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Задания лабы №6";
        }

        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 6;
        }

        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        public string Title()
        {
            return "Лабораторная №6. Тема: Функции и процедуры";
        }
    }
}
