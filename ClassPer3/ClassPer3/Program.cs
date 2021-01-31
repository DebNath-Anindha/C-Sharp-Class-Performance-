using System;


namespace ClassPer3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Any Number : ");

            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(i + 1);
            Console.WriteLine(i + 2);
            Console.WriteLine(i + 3);

            Console.ReadKey();

            Console.Write("Enter Any Number : " + Console.ReadLine());

            

        }
    }
}
        