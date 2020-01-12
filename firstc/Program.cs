using System;

namespace firstc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to my console sum calculator, to quit enter 'exit' ");
            do
            {
                Console.Write("Please enter a number:");
                string firstInput = Console.ReadLine();
                if( firstInput == "exit")
                {
                    Console.WriteLine("Thank you for using my console sum calculator");
                    break;
                }
                else
                {
                    int x = Convert.ToInt32(firstInput);
                    Console.Write("Please enter another number:");
                    string secondInput = Console.ReadLine();
                    int y = Convert.ToInt32(secondInput);
                    int answer = x+y;
                    Console.WriteLine(answer);
                }
            }
            while (true);
        
        }
    }
}
