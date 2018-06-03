using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
            private string name;
            private int hunger;
            private int hungerMax;
            private int boredom;
            private int tired;
            private int tiredMax;
            private int neglect;
            private int neglectMax;
            private int mischief;   

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int Hunger
            {
                get{ return this.hunger; }
                set{ this.hunger = value; }
            }
            public int HungerMax
            {
                get { return this.hungerMax; }
                set { this.hungerMax = value; }
            }
            public int Boredom
            {
                get{ return this.boredom; }
                set{ this.boredom = value; }
            }


            public int Tired
            {
                get{ return this.tired; }
                set{ this.tired = value; }
            }

            public int TiredMax
            {
                get { return this.tiredMax; }
                set { this.tiredMax = value; }
            }

            public int Neglect
            {
                get{ return this.neglect; }
                set{ this.neglect = value; }
            }
            public int NeglectMax
            {
                get { return this.neglectMax; }
                set { this.neglectMax = value; }
            }
            public int Mischief
            {
                get { return this.mischief; }
                set { this.mischief = value; }
            }

            //Adding Constructors

            public VirtualPet()
            {
                //This is the default constructor
            }


            public VirtualPet(string name, int hunger, int boredom, int tired, int neglect) //Loaded Constructor
            {
                this.Name = name;
                this.Hunger = hunger;
            this.HungerMax = hungerMax;
                this.Boredom = boredom;
                this.Tired = tired;
            this.TiredMax = tiredMax;
                this.Neglect = neglect;
            this.NeglectMax = neglectMax;

            }


            //Methods

            public void CheckStatus()
            {
            Console.WriteLine();
            }
            
            // Periodic Tired Check. To go in Tick Method
            public void TiredStatus()
            {
            this.Tired = this.Tired + 4;
            if(this.tired >= TiredMax)
            {
                string tiredResponse = "yes";
                Console.WriteLine("{} is tired, would you like to let him rest?", this.Name);
                Console.WriteLine("Yes or No?");
                tiredResponse = Console.ReadLine().ToLower();
                if(tiredResponse.Equals("yes"))
                {
                    Sleep();
                }
                else if(tiredResponse.Equals("no"))
                {
                    this.Neglect = this.Neglect + 4;
                }
                else
                {
                    this.Neglect = this.Neglect + 4;
                }

            }
            
            }
        public void HungerUpdate()
        {
            this.Hunger = Hunger + 4;

            if(this.Hunger > this.HungerMax)
            {
                string hungerUpdater = "yes";
                Console.WriteLine("{0} is Hungry would you like to feed him?", this.Name);
                Console.WriteLine("Yes or No?");
                hungerUpdater = Console.ReadLine().ToLower();
            }
        }

            // Tick Method. To be placed with all other methods and UI input
            public void Tick()
            {
            TiredStatus();
            NeglectUpdate();
            HungerUpdate();
            }
            public void Sleep()
            {
            this.tired = 0;
            Console.WriteLine("{0} has rested", this.Name);

            }

            public void NeglectUpdate()
            {
            this.Neglect = this.neglect + 1;
            if(this.neglect == 40)
            {
                Console.WriteLine("{} has died of neglect");
                
            }
            }

        }
    }

