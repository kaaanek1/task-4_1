namespace task4_1
{
    class Program
    {
        static void Main()
        {
            OneDim<int> array = new();

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                array.Add(rnd.Next(-10, 11));
            }

            array.Print();

            Console.WriteLine($"\nМинимальное значение: {array.Min()}");
            Console.WriteLine($"\nМаксимальное значение: {array.Max()}");
            Console.WriteLine($"\nКоличество элементов подходящих под условие '3 < x < 7': {array.ConditionCount(x => x>3 & x<7)}");
            Console.WriteLine($"\nПервое подходящее значение под условие '3 < x < 7': {array.GetValueCond(x => x>3 & x<7)}");
            Console.WriteLine($"\nВсе подходящие значения под условие '3 < x < 7': {array.GetValuesCond(x => x>3 & x<7)}");

            Console.WriteLine($"\nХотя бы один из элементов положительный - {array.AnyCheck(x => x > 0)}");
            Console.WriteLine($"\nВсе элементы положительные - {array.AllCheck(x => x > 0)}");

            Console.WriteLine($"\nОтсортированный массив: {array.Sort()}");
            Console.WriteLine($"\nМассив задом наперед: {array.Reverse()}");
        }
    }
}
