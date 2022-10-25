﻿using LessonsInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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

            //ПКС20
            Group PKS = new Group();
            PKS.Add(new Student("Василиса","Курьянова", 18, "женский", "ПКС20", "ВКУиНТ", "Программирование в компьютерных системах"));
            PKS.Add(new Student("Марина","Васильева", 19, "женский", "ПКС20", "ВКУиНТ", "Программирование в компьютерных системах"));
            PKS.Add(new Student("Анжелика","Андреева", 18, "женский", "ПКС20", "ВКУиНТ", "Программирование в компьютерных системах"));
            PKS.Add(new Student("Кристина","Павловец", 20, "женский", "ПКС20", "ВКУиНТ", "Программирование в компьютерных системах"));
            PKS.Add(new Student("Эвелина","Смирнова", 21, "женский", "ПКС20", "ВКУиНТ", "Программирование в компьютерных системах"));
            PKS.Add(new Student("Анжела","Пономарева", 18, "женский", "ПКС20", "ВКУиНТ", "Программирование в компьютерных системах"));
            PKS.Add(new Student("Кира","Щукина", 19, "женский", "ПКС20", "ВКУиНТ", "Программирование в компьютерных системах"));
            PKS.Add(new Student("Виктория","Антипова", 19, "женский", "ПКС20", "ВКУиНТ", "Программирование в компьютерных системах"));
            PKS.Add(new Student("Евгения","Вергун", 18, "женский", "ПКС20", "ВКУиНТ", "Программирование в компьютерных системах"));
            PKS.Add(new Student("Мария","Рублева", 20, "женский", "ПКС20", "ВКУиНТ", "Программирование в компьютерных системах"));


            //ОДЛ20
            Group ODL = new Group();
            ODL.Add(new Student("Ольга", "Петренко", 18, "женский", "ОДЛ20", "ВКУиНТ", "Операционная деятельность в логистике"));
            ODL.Add(new Student("Ангелина", "Кирсанова", 19, "женский", "ОДЛ20", "ВКУиНТ", "Операционная деятельность в логистике"));
            ODL.Add(new Student("Анна", "Никишина", 19, "женский", "ОДЛ20", "ВКУиНТ", "Операционная деятельность в логистике"));
            ODL.Add(new Student("Алина", "Садинова", 20, "женский", "ОДЛ20", "ВКУиНТ", "Операционная деятельность в логистике"));
            ODL.Add(new Student("Карина", "Бульбулянц", 20, "женский", "ОДЛ20", "ВКУиНТ", "Операционная деятельность в логистике"));
            ODL.Add(new Student("Фарида", "Имангалиева", 21, "женский", "ОДЛ20", "ВКУиНТ", "Операционная деятельность в логистике"));
            ODL.Add(new Student("Юлия", "Федорова", 19, "женский", "ОДЛ20", "ВКУиНТ", "Операционная деятельность в логистике"));
            ODL.Add(new Student("Елена", "Миронова", 20, "женский", "ОДЛ20", "ВКУиНТ", "Операционная деятельность в логистике"));
            ODL.Add(new Student("Амина", "Хафизова", 18, "женский", "ОДЛ20", "ВКУиНТ", "Операционная деятельность в логистике"));
            ODL.Add(new Student("Екатерина", "Курьянова", 20, "женский", "ОДЛ20", "ВКУиНТ", "Операционная деятельность в логистике"));


            //ГД20
            Group GD = new Group();
            GD.Add(new Student("Алиса", "Кожевникова", 19, "женский", "ГД20", "ВКУиНТ", "Гостиничное дело"));
            GD.Add(new Student("Ева", "Вакулина", 19, "женский", "ГД20", "ВКУиНТ", "Гостиничное дело"));
            GD.Add(new Student("Валерия", "Антонова", 18, "женский", "ГД20", "ВКУиНТ", "Гостиничное дело"));
            GD.Add(new Student("Мирослава", "Утегенова", 18, "женский", "ГД20", "ВКУиНТ", "Гостиничное дело"));
            GD.Add(new Student("Елизавета", "Рыбакова", 20, "женский", "ГД20", "ВКУиНТ", "Гостиничное дело"));
            GD.Add(new Student("Кирилл", "Бутин", 18, "мужской", "ГД20", "ВКУиНТ", "Гостиничное дело"));
            GD.Add(new Student("Михаил", "Никонов", 20, "мужской", "ГД20", "ВКУиНТ", "Гостиничное дело"));
            GD.Add(new Student("Станислав", "Леднев", 20, "мужской", "ГД20", "ВКУиНТ", "Гостиничное дело"));
            GD.Add(new Student("Владимир", "Давыдов", 18, "мужской", "ГД20", "ВКУиНТ", "Гостиничное дело"));
            GD.Add(new Student("Владислав", "Тиркин", 19, "мужской", "ГД20", "ВКУиНТ", "Гостиничное дело"));


            //АДТ20
            Group ADT = new Group();
            ADT.Add(new Student("Давид", "Микаелян", 19, "мужской", "АДТ20", "ВКУиНТ", "Адитивные технологии"));
            ADT.Add(new Student("Данила", "Барсуков", 18, "мужской", "АДТ20", "ВКУиНТ", "Адитивные технологии"));
            ADT.Add(new Student("Даниил", "Водолазко", 19, "мужской", "АДТ20", "ВКУиНТ", "Адитивные технологии"));
            ADT.Add(new Student("Максим", "Свотин", 18, "мужской", "АДТ20", "ВКУиНТ", "Адитивные технологии"));
            ADT.Add(new Student("Роман", "Дуденков", 20, "мужской", "АДТ20", "ВКУиНТ", "Адитивные технологии"));
            ADT.Add(new Student("Эдгар", "Петросян", 20, "мужской", "АДТ20", "ВКУиНТ", "Адитивные технологии"));
            ADT.Add(new Student("Артем", "Середов", 21, "мужской", "АДТ20", "ВКУиНТ", "Адитивные технологии"));
            ADT.Add(new Student("Анатолий", "Уткин", 18, "мужской", "АДТ20", "ВКУиНТ", "Адитивные технологии"));
            ADT.Add(new Student("Виктор", "Циолковский", 19, "мужской", "АДТ20", "ВКУиНТ", "Адитивные технологии"));
            ADT.Add(new Student("Сергей", "Пресняков", 19, "мужской", "АДТ20", "ВКУиНТ", "Адитивные технологии"));


            //БД20
            Group BD = new Group();
            BD.Add(new Student("Ванесса", "Роулинг", 18, "женский", "БД20", "ВКУиНТ", "Банковское дело"));
            BD.Add(new Student("Розалина", "Каллин", 20, "женский", "БД20", "ВКУиНТ", "Банковское дело"));
            BD.Add(new Student("Эванджелина", "Свифт", 20, "женский", "БД20", "ВКУиНТ", "Банковское дело"));
            BD.Add(new Student("Изабелла", "Свон", 19, "женский", "БД20", "ВКУиНТ", "Банковское дело"));
            BD.Add(new Student("Элис", "Тернер", 18, "женский", "БД20", "ВКУиНТ", "Банковское дело"));
            BD.Add(new Student("Сэм", "Дэнверс", 19, "мужской", "БД20", "ВКУиНТ", "Банковское дело"));
            BD.Add(new Student("Тони", "Старк", 18, "мужской", "БД20", "ВКУиНТ", "Банковское дело"));
            BD.Add(new Student("Стивен", "Кинг", 20, "мужской", "БД20", "ВКУиНТ", "Банковское дело"));
            BD.Add(new Student("Крис", "Пайн", 20, "мужской", "БД20", "ВКУиНТ", "Банковское дело"));
            BD.Add(new Student("Джеймс", "Форд", 18, "мужской", "БД20", "ВКУиНТ", "Банковское дело"));

            //Вывод
            Console.WriteLine();
            Console.WriteLine("Группа ПКС20");
            PKS.PrintGroup();
            Console.WriteLine();
            Console.WriteLine("Группа ОДЛ20");
            ODL.PrintGroup();
            Console.WriteLine();
            Console.WriteLine("Группа ГД20");
            GD.PrintGroup();
            Console.WriteLine();
            Console.WriteLine("Группа АДТ20");
            ADT.PrintGroup();
            Console.WriteLine();
            Console.WriteLine("Группа БД20");
            BD.PrintGroup();

            Console.WriteLine();

            var jsonFormatter = new DataContractSerializer (typeof(Group));
            using (var file = new FileStream("students.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(file, PKS);
                jsonFormatter.WriteObject(file, BD);
                jsonFormatter.WriteObject(file, GD);
                jsonFormatter.WriteObject(file, ADT);
                jsonFormatter.WriteObject(file, ODL);
            }
            using (var file = new FileStream("students.json", FileMode.OpenOrCreate))
            {
                var newStudent = jsonFormatter.ReadObject(file) as List<Student>;
                if (newStudent != null)
                {
                    foreach (var student in newStudent)
                    {
                        Console.WriteLine(student);
                    }
                }
            }

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
