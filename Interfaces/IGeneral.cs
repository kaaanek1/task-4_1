namespace task4_1
{
    interface IGeneral<T>: IPrinter
    {
        void Add(T item);

        void Delete(T item);

        //Дейсвие ко всем элементам массива
        void ForEachAction(Action<T> action);

        //Проекця в другой тип
        // TResult[] Projection<TResult>(Func<T, TResult> projection);

        T[] Sort();

        T[] Reverse();

        T Max();

        T Min();

        // TResult Max<TResult>(Func<T, TResult> project);

        // TResult Min<TResult>(Func<T, TResult> project);

        //Подсчет количества элементов в массиве, удовлетворяющих переданному условию.
        int ConditionCount(Func<T, bool> condition);

        //Проверка выполнения переданного условия хотя бы одного элемента массива.
        bool AnyCheck(Func<T, bool> condition);

        //Проверка выполнения переданного условия для всех элементов массива
        bool AllCheck(Func<T, bool> condition);

        //Проверка наличия элемента в массиве.
        int Index(T item);

        //Получение первого элемента в массиве, удовлетворяющего условию
        T GetValueCond(Func<T, bool> condition);

        //Получение элементов массива, удовлетворяющих переданному условию
        T[] GetValuesCond(Func<T, bool> condition);

        //Получить заданное количество элементов массива с указанного индекса.
        T[] Get(int ind, int number);

    }
}