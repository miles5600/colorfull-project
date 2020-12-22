using System;
namespace question_bot
{
    class room_code
    {
        static void Main()
        {
            string name;
            int age;
            string address;
            string future_job;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter your name please please");
            Console.ForegroundColor = ConsoleColor.Red;
            name = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("come on enter your age for me");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Int32.TryParse(Console.ReadLine(), out age);


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("please i am not bad please just enter your address");
            Console.ForegroundColor = ConsoleColor.Magenta;
            address = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("do you wanna be a robot? just kidding enter your future job");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            future_job = Console.ReadLine();


            Console.WriteLine("you have entered " + name +  "\n " + age + "\n " + address + "\n " + future_job);
        }
    }
}