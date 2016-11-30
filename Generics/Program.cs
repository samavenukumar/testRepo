using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyGenericArray<T>
    {
        private T[] array;

        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }
        public T GetItem(int index)
        {
            return array[index];
        }
        public void SetItem(int index, T value)
        {
            array[index] = value;
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);
            for (int c = 0; c < 5; c++)
            {
                intArray.SetItem(c, c * 5);
            }
            for (int c = 0; c < 5; c++)
            {
                Console.Write(intArray.GetItem(c)+" ");
            }
            Console.WriteLine();

            MyGenericArray<char> charArray = new MyGenericArray<char>(5);
            for(int c=0; c < 5; c++)
            {
                charArray.SetItem(c,(char)(c+97));
            }
            for(int c= 0; c < 5; c++)
            {
                Console.Write(charArray.GetItem(c)+" ");
            }
            Console.WriteLine();


            int a, b;
            char e, d;
            a = 10;
            b = 20;
            e = 'I';
            d = 'V';
            Console.WriteLine("");
            Console.WriteLine("Int values before swap:");
            Console.WriteLine("a={0}, b={1}", a, b);
            Console.WriteLine("Char values before swap:");
            Console.WriteLine("c={0}, d={1}", e, d);
            GenericMethods.Swap<int>(ref a, ref b);
            GenericMethods.Swap<char>(ref e, ref d);

            Console.WriteLine("Int values after calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values after calling swap:");
            Console.WriteLine("c = {0}, d = {1}", e, d);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
