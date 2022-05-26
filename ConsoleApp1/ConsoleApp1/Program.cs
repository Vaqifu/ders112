using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 21;
            int result1 = Sum(num1, num2);
            int result2 = Sum(45, 55);




            int[] num = { 1, 3, 5, 7, 9 };
            int result3 = SumOfNum(num);
            Console.WriteLine(result3);






            bool ce = IsEven(53);
            Console.WriteLine(ce);





            Find("Vaqif", "Usubzade");





            Console.WriteLine("eded daxil edin:");
            string numStr = Console.ReadLine();
            int number = Convert.ToInt32(numStr);
            bool isodd = IsOdd(number);
            if (isodd == true)
            {
                Console.WriteLine("ededn tekdir");
            }
            else
            {
                Console.WriteLine("eded tek deyil");
            }









            //string[] names = { "Lamiye", "Eli", "Anar", "Abdulla", "Saiq" };
            //{   
            //    int count = 0; 
            //    for (int i = 0; i <names.Length; i++)
            //    {
            //        if (name[i] > 5)
            //        {
            //            count++;
            //        }
            //    }

            //    Console.WriteLine(count);

            //}


            var Laastdigits =SumOfDigit(2242);
            Console.WriteLine(Laastdigits);

            
            













        }

        static int Sum(int num1,int num2)
        {
         int result = 0;    
            result = num1 + num2;       
            return result;  
        }



        static int SumOfNum(int[] num)
        {
            int total = 0;
            for (int i = 0; i < num.Length; i++)
            {
               total+= num[i];
            }
            return total;
        }


        static bool IsEven(int num)
        {
            bool check = num % 2 == 1;
            return check;
        }

        

        static void Find(string name,string surname)
        {
            Console.WriteLine(name+" "+surname);
            Console.WriteLine($"{name} {surname}");
            Console.WriteLine(name+" "+surname);
          

        }


        static bool IsOdd(int num)
        {
            bool check = (num % 2 == 1);
            return check;   
        }
        static int SumOfDigit(int number)
        {
            int sum= 0;
            int lastdigit;
            while (number!= 0)
            {
                lastdigit = number % 10;
                sum+= lastdigit;
                number = (number/10);
            }
            return sum; 
        }
    }
}
