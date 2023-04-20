using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 20;
            int b = 4;

            var result = Add(ref a, b); // int veri tipi değer tiptir ref keyword ünü kullanmazisek method tarafından number1 e a nın değeri atılır vein değeri değiştirilir a nın  değeri değiştirilemez. out keywor ü de aynı şekilde ama reften farkı a değerini set etme şartı yok.
            Console.WriteLine("a : {0} a+b = {1}", a, result);

            Console.WriteLine(Multiply(2, 4) + Multiply(1, 2, 3));
            Console.WriteLine(MultiplyWithParams(1,2,3,4,5,6,7,8,9));
            Console.ReadLine(); 
        }
        static int Add(ref int number1, int number2)
        {
            number1 = 'A';
            return number1 + number2;
        }
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int extraNumber) // metodu overload ettik isim aynı params keyword ü bu sorunu çözer.
        {
            return number1 * number2* extraNumber;
        }

        static int MultiplyWithParams(int number1,params int[] numbers/*,int numbers2*/)
        {
            // burada number 1 i kullanmıyorum o yüzden onu tolamıyor numbers dizesindekileri toplar ayrıca params
            // dizesinden sonra parametre yazılmaz
            return numbers.Sum();
        }
    }
}
