namespace BomJSimul.GameLogic
{
    using System;
    using BomJSimul.Engine;

    internal class PlayerContainerInteraction : BomJSimul.Engine.SceneEvent
    {
        public SceneObject TrashBin { get; set; }

        public bool haveYouUsed;

        static int Randomness()
        {
            // Создание объекта для генерации чисел
            Random rnd = new Random();

            // Получить очередное (в данном случае - первое) случайное число
            int value = rnd.Next();

            // Вернуть полученное значение
            return value;
        }
    }
}
