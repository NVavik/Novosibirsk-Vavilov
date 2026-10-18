namespace laba3
{
    internal class pg5
    {
        static void MainOld44(string[] args)
        {
            int[] array = { 1, 2, 3 };
            Console.WriteLine("--- ЭКСПЕРИМЕНТ 1: Попытка изменить ссылку БЕЗ ref ---");
            Console.WriteLine($"Массив ДО вызова: [{string.Join(", ", array)}]. Хэш-код: {array.GetHashCode()}");
            // Вызываем метод, который должен был бы подменить массив, но не сможет
            BrokenSafeAppend(array, 4);
            Console.WriteLine($"Массив ПОСЛЕ вызова: [{string.Join(", ", array)}]. Хэш-код: {array.GetHashCode()}");
            Console.WriteLine("ОЖИДАНИЕ: Массив должен был измениться. РЕАЛЬНОСТЬ: Он не изменился.\n");
            Console.WriteLine("--- ЭКСПЕРИМЕНТ 2: Изменение ссылки с помощью ref ---");
            Console.WriteLine($"Массив ДО вызова: [{string.Join(", ", array)}]. Хэш-код: {array.GetHashCode()}");
            // А вот этот вызов сработает как надо
            RefSafeAppend(ref array, 4);
            Console.WriteLine($"Массив ПОСЛЕ вызова: [{string.Join(", ", array)}]. Хэш-код: {array.GetHashCode()}");
            Console.WriteLine("ОЖИДАНИЕ: Массив изменился. РЕАЛЬНОСТЬ: Успех!\n");
            // КОНТРОЛЬНЫЕ ВОПРОСЫ:
            // 1. Почему результаты двух экспериментов отличаются?
            // 2. Что конкретно делает ключевое слово 'ref' в сигнатуре метода 'RefSafeAppend'?
            // 3. Почему хэш-код массива изменился во втором эксперименте, но не в первом? Что это доказывает?
        }
        // ЗАДАНИЕ 1: Реализуйте этот метод. Он должен создавать новый массив, копировать в него старые элементы и добавлять новый.
        // Ключевое слово ref здесь ГАРАНТИРУЕТ, что присваивание 'sourceArray = newArray' повлияет на переменную 'array' в Main.
        public static void RefSafeAppend(ref int[] sourceArray, int value)
        {
            // ВАШ КОД ЗДЕСЬ
            // 1. Создайте newArray нужного размера
            // 2. Скопируйте данные
            // 3. Добавьте value
            // 4. Сделайте так, чтобы sourceArray теперь указывал на newArray
            int[] newArray = new int[sourceArray.Length + 1];
            for (int i = 0; i < sourceArray.Length; i++)
            {
                newArray[i] = sourceArray[i];
            }
            newArray[newArray.Length - 1] = value;
            sourceArray = newArray;
        }
        // ЗАДАНИЕ 2: Скопируйте сюда РАБОЧУЮ реализацию из RefSafeAppend, но УБЕРИТЕ ключевое слово ref из сигнатуры.
        // Этот метод теперь будет работать с КОПИЕЙ ССЫЛКИ и не сможет изменить оригинальный массив в Main.
        public static void BrokenSafeAppend(int[] sourceArray, int value)
        {
            // ВАШ КОД ЗДЕСЬ
            // Он будет идентичен коду выше, но работать будет только внутри этого метода.
            int[] newArray = new int[sourceArray.Length + 1];
            for (int i = 0; i < sourceArray.Length; i++)
            {
                newArray[i] = sourceArray[i];
            }
            newArray[newArray.Length - 1] = value;
            sourceArray = newArray;
        }

    }
}
