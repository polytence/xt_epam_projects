using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task33
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArrayTask();
        }
        static void DynamicArrayTask()
        {
            Console.WriteLine("Create array");
            DynamicArray<int> Array1 = new DynamicArray<int>();
            Array1.Add(1);
            Console.WriteLine("Add element");
            Console.Write("Array: ");
            foreach (var item in Array1)
            {
                Console.Write(item + " ");
            }
            int[] massint = new int[] { 1, 2, 33, 4, 55, 19 };
            Array1.AddRange(massint);
            Console.WriteLine("");
            Console.WriteLine("Last element: " + Array1[-1]);
            Console.WriteLine("Lenght: " + Array1.Length + " Capacity: " + Array1.Capacity);

            Console.WriteLine("");
            Console.Write("Generate new array: ");
            foreach (var item in Array1)
            {
                Console.Write(item + " ");
            }
            var Array2 = (DynamicArray<int>)Array1.Clone();
           // Array1.Insert(1, 1);
           // Array1.Remove(4);
            Array2.Remove(2);
            
            Console.WriteLine("");
            Console.WriteLine("Use remove and insert");
            Console.Write("Array: ");
            foreach (var item in Array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Cloned array: ");
            foreach (var item in Array2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");

            Console.ReadLine();
        }
        class DynamicArray<T> : IEnumerable, IEnumerable<T>, ICloneable
        {
            T[] Arr = null;
            public int Length { get; set; } 

            public int Capacity => Arr.Length;
            
            //1
            public DynamicArray()
            {
                Arr = new T[8];
            }
            //2
            public DynamicArray(int capacity)
            {
                if (capacity <= 0)
                    throw new ArgumentException("Capacity > 0");
                Arr = new T[capacity];
            }
            //3
            public DynamicArray(IEnumerable<T> array)
            {
                Arr = new T[array.Count()];

                foreach (var item in array)
                {
                    Arr[Length] = item;
                    Length++;
                }
            }
            //4
            public void Add(T item)
            {
                AddCapacity(Length + 1);
                Arr[Length] = item;
                Length++;
            }

            public void AddCapacity(int newLength)
            {
                int capacity = Capacity;
                while (newLength > capacity)
                {
                    capacity *= 2;
                }
                if (capacity != Capacity)
                    ChangeCapacity(capacity);
            }
            public void ChangeCapacity(int newLength)
            {
                T[] temp = new T[newLength];
                int length = Arr.Length > newLength ? newLength : Arr.Length;
                for (int i = 0; i < length; i++)
                {
                    temp[i] = Arr[i];
                }
                Arr = temp;
            }
            //5
            public void AddRange(IEnumerable<T> array)
            {
                AddCapacity(Length + array.Count());
                foreach (var item in array)
                {
                    Arr[Length] = item;
                    Length++;
                }
            }
            //6 Exception if not have specified item (bad worked)
            public bool Remove(T item)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i].GetHashCode() == item.GetHashCode())
                    {
                        for (; i < Arr.Length - 1; i++)
                        {
                            Arr[i] = Arr[i + 1];
                        }
                        Length--;
                        return true;
                    }
                }
                return false;
            }
            //7 bad worked
            public void Insert(int n, T item)
            {
                if (n >= Length || n < -Length)
                    throw new ArgumentOutOfRangeException();
                AddCapacity(Length++);

                if (n < 0)
                    n += Length;
                _ = Arr[n];
                for (int i = Length - 1; i > n; i--)
                {
                    Arr[i + 1] = Arr[i];
                }
                Arr[n] = item;
            }

            public T[] ToArray()
            {
                T[] arr = new T[Length];
                for (int i = 0; i < Length; i++)
                {
                    arr[i] = Arr[i];
                }
                return arr;
            }

            public object Clone()
            {
                return new DynamicArray<T>(Arr);
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

            public EnumeratorArray<T> GetEnumerator()
            {
                return new EnumeratorArray<T>(ToArray());
            }

            IEnumerator<T> IEnumerable<T>.GetEnumerator() => GetEnumerator();
            //11
            public T this[int index]
            {
                get
                {
                    if (index >= Length || index < -Length)
                        throw new ArgumentOutOfRangeException();
                    return (index >= 0) ?  Arr[index] :  Arr[Length + index];
                }
                set
                {
                    if (index >= Length || index < -Length)
                        throw new ArgumentOutOfRangeException();
                    if (index >= 0)
                        Arr[index] = value;
                    else
                        Arr[Length + index] = value;
                }
            }
        }
        class EnumeratorArray<T> : IEnumerator<T>
        {
            public T[] array;

            public int index = -1;

            public EnumeratorArray(T[] array)
            {
                this.array = array;
            }

            public bool MoveNext()
            {
                index++;
                return (index < array.Length);
            }

            public void Reset()
            {
                index = -1;
            }

            public void Dispose()
            {
            }
            public T Current
            {
                get
                {
                    try
                    {
                        return array[index];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }

            object IEnumerator.Current => throw new NotImplementedException();
        }
    }

    
}
