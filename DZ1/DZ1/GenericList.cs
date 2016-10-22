using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    class GenericList <X> : IGenericList <X>
    {
        private X[] _internalStorage;
        private int itemNumber = 0;

        public GenericList()
        {
            _internalStorage = new X[4];
        }

        public GenericList(int initialSize)
        {
            _internalStorage = new X[initialSize];
            Console.WriteLine(_internalStorage.Length + "bla");
        }

        //// IEnumerable <X> implementation koji ne radi
        public IEnumerator<X> GetEnumerator()
        {
            return new GenericListEnumerator<X>(this);
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        //metode

        public void Add(X item)
        {
            if (itemNumber >= _internalStorage.Length)
            {
                Array.Resize<X>(ref _internalStorage, 2 * _internalStorage.Length);
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
            _storageList.RemoveAt(index);
            _internalStorage = _storageList.ToArray();
            itemNumber--;
            //Console.WriteLine(_internalStorage.GetType());
            //foreach (int item in _internalStorage)
            //{
            //    Console.Write(item);
            //}
            return true;
        }

        public bool Remove(X item)
        {
            var index = Array.IndexOf(_internalStorage, item);
            return RemoveAt(index);
        }

        public X GetElement(int index)
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

        public int IndexOf(X item)
        {
            var index = Array.IndexOf(_internalStorage, item);
            return index;
        }



        public void Clear()
        {
            Array.Clear(_internalStorage, 0, _internalStorage.Length);
        }

        public bool Contains(X item)
        {
            return _internalStorage.Contains<X>(item);
        }

    }
}
