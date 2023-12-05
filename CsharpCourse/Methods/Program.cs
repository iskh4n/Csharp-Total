using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result=Add2gether(20, 30);
            Console.WriteLine("addition method returning with integer ="+result);

            //-------------------------------------------
            int num1 = 20;
            int num2 = 100;

            var Answr = Add3Challenge(num1, num2);
            var AnswrRef = AddwithRef(ref num1, num2);
            var AnswrOut = AddwithOut(out num1, num2);

            Console.WriteLine("method içi atamaya göre toplama  "+Answr);
            Console.WriteLine("\nReferanslı method içi atamaya göre toplama "+AnswrRef);
            Console.WriteLine("\nout'refli method içi atamaya göre toplama " + AnswrOut);
            Console.WriteLine("\nadd with params 1,2,5,10,25=== "+AddwithParams(1, 2, 5, 10, 25));

            //----------------------------------------------
            Console.WriteLine("\nMain Addition "+(num1+num2));//maindeki toplama(ref/out methodlarından dolayı değişmiş olabilir)

            Console.WriteLine("\nMain Multiply " + Multiply(num1,num2,2));//overload method 50*100*2


            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Add method, *Dont repeat yourself idea*");

        }
        static int Add2gether(int num1, int num2=0)//default number of num2= 0 if its not given
        {
            var result = num1 + num2;
            return result;

        }

        static int Add3Challenge(int num1, int num2) 
        {
            num1 = 500;
            return num1 + num2;
        }

        static int AddwithRef(ref int num1, int num2)
        {
            num1 = 30; // burada yapılan değişiklik mainde geçerli olduğu için artık 30 geçerli
            return num1 + num2;
        }
        static int AddwithOut(out int num1, int num2)
        {
            num1 = 50; // burada yapılan değişiklik mainde geçerli olduğu için artık 50 geçerli
            return num1 + num2;
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Multiply(int num1, int num2, int num3) // overload of multiply method
        {
            return num1 * num2*num3;
        }
        static int AddwithParams(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
