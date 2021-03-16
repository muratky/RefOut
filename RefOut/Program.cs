using System;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number1 = 6; 
            int number2 = 8;
            int number3; 
            //int number3=5;

            var result1 = add( out number1, number2);//Burda 'out' ise add metotun içinde  number1 değişkene değer vermesi gerekiyor.yukardaki  10'uncu satırdaki number1 değişkeni etkisizdir.metodun içinde atanması gerekir.
            Console.WriteLine(result1);
            Console.WriteLine(number1);

            var result2 = add1(ref number3, number2);// Burda 'ref' ise yukardaki 12 satırdaki kodda number3 değişkene değer atamamız gerekir yoksa ref çalışmaz.
            Console.WriteLine(result2);
            Console.WriteLine(number3);

            Console.ReadLine();
        }

        static int add( out int number1, int number2)
        {
            //number1=5;
            return number1 + number2;

        }
        static int add1(ref int number3, int number2)
        {
            number3=5;
            return number3 + number2;

        }
    }
}
