using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int itemNumber = 0;

        public IntegerList()
        {
            _internalStorage = new int[4];
        }

        public IntegerList(int initialSize)
        {
            _internalStorage = new int[initialSize];
            Console.WriteLine(_internalStorage.Length + "bla");
        }

        public void Add(int item)
        {
            if(itemNumber>=_internalStorage.Length)
            {
                Array.Resize<int>(ref _internalStorage, 2 * _internalStorage.Length);
            }
            _internalStorage[itemNumber++] = item;
        }

        public bool RemoveAt(int index)
        {
            if ((index >= _internalStorage.Length) || (index < 0))
            {
                return false;
            }
            
            var _storageList = _internalStorage.ToList();
            _storageList.Remove(index);
            _internalStorage = _storageList.ToArray();
            itemNumber--;
            //Console.WriteLine(_internalStorage.GetType());
            //foreach (int item in _internalStorage)
            //{
            //    Console.Write(item);
            //}
            return true;
        }

        public bool Remove(int item)
        {
            var index = Array.IndexOf(_internalStorage, item);
            return RemoveAt(index);
        }

        public int GetElement(int index)
        {
            if ((index >= 0) && (index <= _internalStorage.Length))
            {
                return _internalStorage[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        //ovo tu ne radi
        public int Count
        {
            get
            {
                return 1;
            }
        }

        public int IndexOf(int item)
        {
            var index = Array.IndexOf(_internalStorage, item);
            return index;
        }



        public void Clear()
        {
            Array.Clear(_internalStorage, 0, _internalStorage.Length);
        }

        public bool Contains(int item)
        {
            return _internalStorage.Contains<int>(item);
        }
    }
}
