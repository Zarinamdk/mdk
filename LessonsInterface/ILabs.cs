namespace LessonsInterface
{
    public interface ILabs
    {
        /// <summary>
        /// Метод демонстрации отработки всех заданий лабораторной работы
        /// </summary>
        void Demo();

        /// <summary>
        /// Заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        string Title();

        /// <summary>
        /// Описание заданий
        /// </summary>
        /// <returns></returns>
        string Description();

        /// <summary>
        /// Идентификатор (номер) лабораторной работы
        /// </summary>
        /// <returns></returns>
        int Id();
    }
 
}

