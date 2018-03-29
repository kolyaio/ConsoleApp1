using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            foreach (string arg in args)
            {
                if(arg == "ground")
                {
                    Ground();
                }
            }
            
            StartUp();
        }

        private static void StartUp()
        {
            Console.WriteLine("Welcome Masha\nare you on airplane?");
            
            string airquestion = Console.ReadLine();
            
            Debug.Assert(airquestion != null, nameof(airquestion) + " != null");
            
            if (airquestion.ToLower().Equals("yes"))
            {
                Console.WriteLine("Good for you Mashoshka");
                Console.ReadLine();
                Ground();
            } 
            else if (airquestion.ToLower().Equals("no"))
            {
                Console.WriteLine("Huh, I got confused..Probably..");
                Console.ReadLine();
                WhyNot();
            } 
            else
            {
               AreYouSure(StartUp);
            }
            Console.ReadLine();
        }
        private static void Ground()
        {

            string say, message;
            
            message = "What are you doin' now?";
            Console.WriteLine("so.....");
            Console.ReadKey();
            Console.WriteLine(message);
            say = Console.ReadLine();
            if (say.ToLower().Equals(""))
            {
                AreYouSure(Ground);
            }
            else
            {
                Console.WriteLine("oh really? let me quote you, you said '" + say + "'\nIs this what are you saying?(yes/no)");
                say = Console.ReadLine();
                
                Debug.Assert(say != null, nameof(say) + " != null");
                
                if (say.ToLower().Equals("yes"))
                {
                    Console.WriteLine("Jokes on you I dont really care.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if (say.ToLower().Equals("no"))
                {
                    Console.WriteLine("oh...kay...let me ask you the whole over again...");
                    Console.ReadLine();
                    Ground();
                }
                else
                {
                    AreYouSure(Ground);
                }
            }
        }
        private static void WhyNot()
        {
            string answer;
            Console.WriteLine("Why aren't you on Airplane?");
            answer = Console.ReadLine();
            Console.WriteLine("You said '" + answer + "'\nSounds terrible, I hope you get into plane soon");
            Console.ReadLine();
            Ground();
        }
        private static void Goodbye()
        {
            Console.WriteLine("lol masha, you decided to leave ? :-( Bye Bye.");
            Console.ReadLine();
            Environment.Exit(0);
        }

        private static void AreYouSure(Action callback)
        {
            string answer;
            Console.WriteLine("masha ? Are you sure you want to leave?");
            answer = Convert.ToString(Console.ReadLine());
            if (answer.ToLower().Equals("y"))
            {
               Goodbye();
            }
            else if(answer.ToLower().Equals("n"))
            {
                callback();
            }
            else
            {
                Console.WriteLine("You should input Y / N values only.\n ");
                AreYouSure(callback);
            }
           
        }
    }
}
