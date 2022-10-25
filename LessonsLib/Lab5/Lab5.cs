
using LessonsInterface;

namespace MDK.Lab5
{
    public class Lab5 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>    
        public void Demo()
        {
            // ход лабы
            Console.WriteLine();
            int[,] matrix = RandomMatrix();
            Console.WriteLine("Задание №1");
            Console.WriteLine("Элементы главной диагонали");
            PrintMainDiagonal(matrix);
            Console.WriteLine();
            Console.WriteLine("Задание №2");
            Console.WriteLine("Элементы второстепенной диагонали");
            PrintSecondaryDiagonal(matrix);
            Console.WriteLine();
            Console.WriteLine("Задание №3");
            Console.WriteLine("Сумма всех элементов матрицы =" + SummaMatrix(matrix));
            Console.WriteLine();

            //Заполнение матрицы случайными числами
            static int[,] RandomMatrix()
            {
                int[,] matrix = new int[4, 4];
                Random rnd = new Random();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = rnd.Next(-100, 100);
                    }
                }
                return matrix;
                Console.WriteLine();
            }

            //Вывод главной диагонали
            static void PrintMainDiagonal(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                    Console.Write(matrix[i, i] + "\t");
                    Console.WriteLine();
            }

            //Вывод второстепенной диагонали
            static void PrintSecondaryDiagonal(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                    Console.Write(matrix[i, matrix.GetLength(0) - i - 1] + "\t");
                    Console.WriteLine();
            }

            // Вывод суммы всех элементов матрицы
            static int SummaMatrix(int[,] matrix)
            {
                int summa = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        summa += matrix[i, j];
                    }
                }
                return summa;
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Задания лабы №5";
        }

        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 5;
        }

        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        public string Title()
        {
            return "Лабораторная №5. Тема: Двумерные массивы";
        }
    }
}
