using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Listtask
{
    internal class CustomList<T>
    {

        private T[] array;
        public int _count;
        public int _capasity;

        public CustomList(int capasity = 6)
        {
            _capasity = capasity;
            array = new T[capasity];

        }
        private  int Length
        {
            get { 
          
                return _count;
            }
            
        }


        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public CustomList()
        {
            array = new T[0];
        }
       

        public CustomList(params T[] nums)
        {
            array = nums;
        }


        public void Add(T num)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = num;

            _count++;

        }
        public void AddRange(params T[] nums)
        {
            foreach(T num in nums)
            {
               Add(num);
            }
           
        }

        public bool Contains(T num)
        {
            for (int i = 0; i < _count; i++)
            {
                if (array[i].Equals(num))
                {
                    return true;
                }
            }
           return false;    
        }
        //public void Sum()
        //{
        //    int sum = 0;
        //    if (typeof(T) == typeof(int))
        //    {
        //        for(int i = 0; i <_count; i++)
        //        {

        //        }
        //    }

        //}
        public void Remove(T num)
        {

          int findIndex=Array.IndexOf(array, num);
            if (findIndex != 0)
            {
                for(int i = findIndex; i < array.Length-1; i++)
                {
                    array[i] = array[i +1];
                }

            }
            Array.Resize(ref array, array.Length - 1);
        }
            public void RemoveRange(params T[] nums)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Remove(array[i]);
            }
        }
        public override string ToString()
        {
          return string.Join(",", array);
        }

        public void Capasity()
        {
            if (_count >= _capasity)
            {
                _capasity *= 2;
            }
            Array.Resize(ref array, _capasity);
        }
    }
}
