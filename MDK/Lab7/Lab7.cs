using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MDK.Lab7
{
    public class Lab7 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>
        public void Demo()
        {
            // ход лабы
            Group PKS20 = new Group();
        }

        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Задания лабы №7";
        }

        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 7;
        }

        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        public string Title()
        {
            return "Лабораторная №7. Тема: Сериализация";
        }

    }
}
