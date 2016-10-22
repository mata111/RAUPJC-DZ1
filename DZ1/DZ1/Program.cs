using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ja sam kralj");

            ////Zadajem velicinu niza
            //int initialSize = 5;

            //IntegerList lista = new IntegerList(initialSize);

            //GenericList<int> generic_lista = new GenericList<int>(initialSize);

            //Console.WriteLine(lista.Count);
            //for (int count = 0; count < 5; count++)
            //{
            //    lista.Add(count);
            //}

            //lista.RemoveAt(2);

            //Console.WriteLine(lista.Count);

            IGenericList<string> stringList = new GenericList<string>();
            stringList.Add(" Hello ");
            stringList.Add(" World ");
            stringList.Add("!");
            foreach (string value in stringList)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }
    }
}
