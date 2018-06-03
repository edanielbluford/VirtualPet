using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {

            VirtualPet algernon = new VirtualPet("Algernon", 5, 40, 5, 40, 5, 40, 0, 50, 0, 0);
            string[] choices = new string[5] {"1. Play", "2. Feed","3. Sleep","4. Go to the Doctor","5. Do Nothing" };


            string exitResponse = "yes";
            Console.WriteLine("You wake up to a letter and a box on your dresser Would you like to open it?");
            Console.WriteLine("(Yes or No?)");
            exitResponse = Console.ReadLine().ToLower();
            if (exitResponse.Equals("yes"))
            {
                while (exitResponse.Equals("yes"))
                {
                    Console.WriteLine("Greetings!  We have been watching you and we think you would make a good addition to Clotho Magic Academy");
                    Console.WriteLine("Before we can fully accept you, we have one task for you.");
                    Console.WriteLine("Inside this box, you'll find your familar, a pet if you will. If you can manage to take good care of him, you're in!");
                    Console.WriteLine("The box shifts and shakes...");
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine("*Shake*");
                    }

                    Console.WriteLine("A mouse pops out of the box!");
                    Console.WriteLine("Hello! My name is {0}! I'm sure we're going to have a great time together!", algernon.Name);

                    while (algernon.Neglect <= algernon.NeglectMax)
                    {
                        int choiceValue = 0;
                        algernon.CheckStatus();
                        algernon.Tick();
                        Console.WriteLine("What would you like to do today Master!");
                        for (int i = 0; i < choices.Length; i++)
                        {
                            Console.WriteLine(choices[i]);
                        }
                        choiceValue = int.Parse(Console.ReadLine());
                        switch (choiceValue)
                        {
                            case 1: algernon.Play();
                                    break;
                            case 2: algernon.Feed();
                                break;
                            case 3: algernon.Sleep();
                                break;
                            case 4: algernon.DoctorVisit();
                                break;
                            case 5:
                                break;
                        }
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("You have a very normal, not very eventful day...");
            }
        }
    }
}
