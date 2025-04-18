using System;
using System.Collections;

//using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DemoGenerics.Collections
{
    //public class MyList: IEnumerable
    //{
    //    private object[] storeArray;
    //    private int count;

    //    public MyList(int size)
    //    {
    //        storeArray = new object[size];
    //    }

    //    public void Add(object item)
    //    {
    //        if(count == storeArray.Length)
    //        {
    //            Array.Resize<object>(ref storeArray, count*2);
    //        }
    //        storeArray[count++] = item;
    //    }

    //    public void Clear()
    //    {
    //        for (int i = 0; i < storeArray.Length; i++)
    //        {
    //            storeArray[i] = null;
    //        }
    //    }

    //    public IEnumerator GetEnumerator()
    //    {
    //        foreach(object item in storeArray)
    //        {
    //            yield return item;
    //        }
    //    }

    //    public int Count => count;

    //    public int Size => storeArray.Length;

    //    public object this[int index]
    //    {
    //        get 
    //        { 
    //            if(index>=0 && index<Count)
    //            {
    //                return storeArray[index];
    //            }
    //            else
    //            {
    //                throw new IndexOutOfRangeException();
    //            }
    //        }
    //        set 
    //        {
    //            if (index >= 0 && index < Size)
    //            {
    //                storeArray[index] = value;
    //            }
    //        }
    //    }


    //}

    public class MyList<T> : IEnumerable<T> where T: IDisposable
    {
        private T[] storeArray;
        private int count;

        public MyList(int size)
        {
            storeArray = new T[size];
        }

        public void Add(T item)
        {
            if (count == storeArray.Length)
            {
                Array.Resize<T>(ref storeArray, count * 2);
            }
            storeArray[count++] = item;
        }

        public void Clear()
        {
            for (int i = 0; i < storeArray.Length; i++)
            {
                storeArray[i] = default(T);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            //foreach (var item in storeArray)
            //{
            //    yield return item;
            //}

            for (int i = 0; i < Count; i++)
            {
                yield return storeArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count => count;

        public int Size => storeArray.Length;

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < Count)
                {
                    return storeArray[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < Size)
                {
                    storeArray[index] = value;
                }
            }
        }
    }
}
