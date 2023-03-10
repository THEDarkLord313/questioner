using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questioner
{
    internal class Program
    {
        private const string YES = "YES";
        static void Main(string[] args)
        {
            Console.WriteLine("Are you married? (YES/NO) ");
            if (Console.ReadLine().ToUpper().Equals(YES))
            {
                Console.WriteLine("Do you have children? (YES/NO)");
                if (Console.ReadLine().ToUpper().Equals(YES))
                {
                    Console.WriteLine("How many children are they?");
                    int numberOfChildren;
                    if (int.TryParse(Console.ReadLine(), out numberOfChildren))
                    {
                        Console.WriteLine("What are their names?");
                        string[] childrenNamesArray = new string[numberOfChildren];

                        for (int i = 0; i < childrenNamesArray.Length; i++)
                        {
                            Console.WriteLine($"Enter the #{i + 1} child name");
                            childrenNamesArray[i] = Console.ReadLine();
                        }

                        Console.WriteLine($"Your children names are :{string.Join(", ", childrenNamesArray)}");
                        Console.ReadKey(); // Zert baste nashe barname
                    }
                    else
                    {
                        Console.WriteLine("InvalidFormat");
                    }
                }
                else
                {
                    Console.WriteLine("Do you even want to have children? (YES/NO)");
                    if (Console.ReadLine().ToUpper().Equals(YES))
                    {
                        Console.WriteLine("You're doing the right thing");
                        // Inja mitooni code bala ro estefade koni o esm bache hasho dobare beporsi
                        // Behtare 2ta code ro eynan copy/paste nakoni.
                        // Code haye ye function bkon. Anjam nmidinam chon fekonam nagofte behetoon
                    }
                    else
                    {
                        Console.WriteLine("Well that's not all your idea tbh :-)) Come back later if you've changed your mind");
                        Console.ReadKey(); // Zert baste nashe barname
                    }
                }

            }
            else
            {
                Console.WriteLine("Don't you have a special case in your mind?");
                if (Console.ReadLine().ToUpper().Equals(YES))
                {
                    Console.WriteLine("Cool :-) What's his/her name?");
                    string name = Console.ReadLine();
                    Console.WriteLine($"I hope you and {name} get married soon and live a happy life. :D");
                    Console.ReadKey(); // Zert baste nashe barname
                }
                else
                {
                    Console.WriteLine("ROFL. That's alright Kido :-)))))))) Do as you please");
                    Console.ReadKey(); // Zert baste nashe barname
                }
            }
        }
    }
}
