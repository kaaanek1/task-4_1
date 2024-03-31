namespace task4_1
{
    sealed class OneDim<T>: IGeneral<T>
    {
        private int CAPACITY = 5;

        private int capacity;

        private int factLen;

        private T[] array;

        public OneDim(int capacity)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(capacity);
            this.capacity = capacity;
            array = new T[capacity];
        }

        public OneDim(): this(CAPACITY) { }

        private void Resize()
        {
            capacity = capacity == 0 ? 4 : capacity * 2 + 1;
            T[] _array = new T[factLen];
            array.CopyTo(_array, 0);
            array = new T[capacity];
            _array.CopyTo(array, 0);
        }

        public void Print()
        {
            Console.WriteLine($"Массив {T}:");
            for (int i = 0; i < factLen; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        public void Add(T item) 
        {
            if (factLen >= capacity)
            {
                Resize();
            }
            array[factLen] = item;
            factLen++;
        }

        public void Delete(T item) 
        {
            int ind = Index(item);
            factLen--;
            array.Copy(array, ind + 1, array, ind, factLen-ind);
        }

        public void ForEachAction(Action<T> action)
        {
            // ArgumentNullException.ThrowIfNull(action);
            for (int i = 0; i < factLen; i++)
            {
                action(array[i]);
            }
        }

        // public TResult[] Projection<TResult>(Func<T, TResult> project) 
        // {
        //     ArgumentNullException.ThrowIfNull(project);
        //     TResult[] _array = new TResult[factLen];
        //     for (int i = 0; factLen > i; i++)
        //     {
        //         _array[i] = project(array[i]);
        //     }
        //     return _array;
        // }

        public int Index(T item)
        {
            for (int i = 0; i < length;i++)
            {
                if (array[i].Equals(element))
                {
                    return i;
                }
            }
            throw new Exception(-1);
        }

        public T[] Reverse()
        {
            T[] _array = new T[factLen];

            for (int i = 0; i < factLen; i++)
            {
                _array[factLen - i - 1] = array[i];
            }

            return _array;
        }


        public T[] Sort()
        {
            T[] _array = array.Sort();
            return _array;
        }


        public T Min()
        {
            T min = array[0];
            for (int i = 0; i < factLen; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }

            return min;
        }


        public T Max()
        {
            T max = array[0];
            for (int i = 0; i < factLen; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }


        // public TResult Min<TResult>(Func<T, TResult> project)
        // {

        // }


        // public TResult Max<TResult>(Func<T, TResult> project)
        // {
            
        // }


        public T GetValueCond(Func<T, bool> condition)
        {
            // ArgumentNullException.ThrowIfNull(condition);
            for (int i = 0; i < factLen;i++)
            {
                if (condition(array[i]))
                {
                    return array[i];
                }
            }
            throw new Exception("Не найдено");
        }


        public T[] GetValuesCond(Func<T, bool> condition)
        {
            // ArgumentNullException.ThrowIfNull(condition);
            T[] _array = new T[factLen];
            int ind = 0;

            for (int i = 0; i < factLen; i++)
            {
                if (condition(array[i]))
                {
                    _array[index++] = array[i];
                }
            }
            return _array;
        }


        public int ConditionCount(Func<T, bool> condition)
        {
            // ArgumentNullException.ThrowIfNull(condition);
            int c = 0;

            for (int i = 0; i < factLen; i++)
            {
                if (condition(array[i]))
                {
                    c++;
                }
            }
            return c;
        }


        public bool AnyCheck(Func<T, bool> condition)
        {
            // ArgumentNullException.ThrowIfNull(condition);
            for (int i = 0; i < factLen; i++)
            {
                if (condition(array[i]))
                {
                    return true;
                }
            }
            return false;
        }


        public bool AllCheck(Func<T, bool> condition)
        {
            // ArgumentNullException.ThrowIfNull(condition);
            for (int i = 0; i < factLen; i++)
            {
                if (!condition(array[i]))
                {
                    return false;
                }
            }
            return true;
        }


        public T[] Get(int ind, int number)
        {
            T[] _array = new T[number];
            int _ind = 0;

            for (int i = ind; i < number+1; i++)
            {
                _array[_ind++] = array[i];
            }

            return _array;
        }
    }
}