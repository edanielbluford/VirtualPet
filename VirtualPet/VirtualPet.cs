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
            private int boredomMax;
            private int tired;
            private int tiredMax;
            private int neglect;
            private int neglectMax;
            private int mischief;
            private int sickness;

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

        public int BoredomMax
        {
            get { return this.boredomMax; }
            set { this.boredomMax = value; }
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
            public int Sickness
        {
            get { return this.sickness; }
            set { this.sickness = value; }
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
            this.BoredomMax = boredomMax;
            this.Tired = tired;
            this.TiredMax = tiredMax;
            this.Neglect = neglect;
            this.NeglectMax = neglectMax;
            this.Mischief = mischief;
            this.Sickness = Sickness;

            }


            //Methods

            public void CheckStatus()
        {
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Hunger: {0}", this.Hunger);
            Console.WriteLine("Boredom: {0}", this.Boredom);
            Console.WriteLine("Tiredness: {0}", this.Tired);
            Console.WriteLine("Sickness: {0}", this.Sickness);

        }
        //UI Methods
        public void Sleep()
        {
            this.Tired = 0;
            this.Hunger = this.Hunger + 5;
            Console.WriteLine("{0} has rested", this.Name);

        }
        public void Play()
        {
            this.Boredom = 0;
            this.Tired = this.Tired + 6;
            Console.WriteLine("{0} had a fun time playing with you", this.Name);
        }
        public void Feed()
        {
            this.Hunger = 0;
            this.Tired = this.Tired + 3;
            Console.WriteLine("{0} is full now", this.Name);
        }
        public void DoctorVisit()
        {
            this.Sickness = 0;
            this.Boredom = this.Boredom + 5;
            this.Neglect = this.Neglect - 2;
            Console.WriteLine("{0} is full now", this.Name);
        }

        // Tick Method. To be placed with all other methods and UI input
        public void Tick()
            {
            TiredStatus();
            NeglectUpdate();
            HungerUpdate();
            BoredomUpdate();
            SicknessUpdate();
            MischiefMaker();
            }
            

            public void NeglectUpdate()
            {
            this.Neglect = this.neglect + 1;
            if(this.neglect == 40)
            {
                Console.WriteLine("{} has died of neglect");
                
            }
            }
        public void HungerUpdate()
        {
            this.Hunger = Hunger + 4;

            if (this.Hunger >= this.HungerMax)
            {
                this.Neglect = this.Neglect + 4;
                string hungerUpdater = "yes";
                Console.WriteLine("{0} is Hungry would you like to feed him?", this.Name);
                Console.WriteLine("Yes or No?");
                hungerUpdater = Console.ReadLine().ToLower();

                if (hungerUpdater.Equals("yes"))
                {
                    this.Neglect = this.Neglect + 4;
                }
            }
        }


        public void TiredStatus()
        {
            this.Tired = this.Tired + 4;
            if (this.tired >= TiredMax)
            {
                string tiredResponse = "yes";
                Console.WriteLine("{} is tired, would you like to let him rest?", this.Name);
                Console.WriteLine("Yes or No?");
                tiredResponse = Console.ReadLine().ToLower();
                if (tiredResponse.Equals("yes"))
                {
                    Sleep();
                }
                else if (tiredResponse.Equals("no"))
                {
                    this.Neglect = this.Neglect + 4;
                }
                else
                {
                    this.Neglect = this.Neglect + 4;
                }

            }

        }

        public void BoredomUpdate()
        {
            this.Boredom = this.Boredom + 4;
            if (this.Boredom >= this.BoredomMax)
            {
                string tiredResponse = "yes";
                Console.WriteLine("{0} is bored, would you like to play with him?", this.Name);
                Console.WriteLine("Yes or No?");
                tiredResponse = Console.ReadLine().ToLower();
                if (tiredResponse.Equals("yes"))
                {
                    Sleep();
                }
                else if (tiredResponse.Equals("no"))
                {
                    this.Neglect = this.Neglect + 4;
                }
                else
                {
                    this.Neglect = this.Neglect + 4;
                }

            }

        }
        public void SicknessUpdate()
        {
            Random r = new Random();
            this.Sickness = this.Sickness = r.Next(1, 7);
            if(Sickness >= 30)
            {
                string sicknessResponse = "";
                this.Neglect = this.Neglect = 4;
                this.Tired = this.Tired + 10;
                Console.WriteLine("{0} seems pretty sick. Would you like to take him to the doctor?", this.Name);
                Console.WriteLine("Yes or No?");
                if (sicknessResponse.Equals("yes"))
                {
                    this.Sickness = 0;
                    Console.WriteLine("{0} is doing much better.", this.Name);
                    this.Neglect = this.Neglect - 2; 
                }
                else
                {
                    Console.WriteLine("Okay...");
                    this.Neglect = this.Neglect++;
                }
            }
        }

        public void MischiefMaker()
        {
            Random r = new Random();
            int value = r.Next(1, 6);
            this.Mischief = this.Boredom + this.Neglect;

            if (this.Mischief >= 20)
            {


                switch (value)
                {
                    case 1:
                        Console.WriteLine("Oh no! it looks like {0} got into the pantry and ate all the cheese.", this.Name);
                        this.Hunger = 0;
                        this.Sickness = this.Sickness + 4;
                        this.Boredom = this.Boredom - 3;
                        this.Neglect = this.Neglect + 2;
                        break;
                    case 2:
                        Console.WriteLine("{0} got out of your room and scared your mother! She thought he was a ordinary mouse and swatted him with a broom.", this.Name);
                        this.Hunger = this.Hunger + 2;
                        this.Sickness = this.Sickness + 4;
                        this.Boredom = this.Boredom - 3;
                        this.Neglect = this.Neglect + 3;
                        break;
                    case 3:
                        Console.WriteLine("Whuh-oh. {0} was trying to help you pratice magic and he got zapped.",this.Name);
                        this.Hunger = this.Hunger + 2;
                        this.Sickness = this.Sickness + 6;
                        
                        this.Neglect = this.Neglect + 3;
                        break;
                    case 4:
                        Console.WriteLine("{0} managed to convince you to forgo your studies and play with him all day", this.Name);
                        this.Tired = this.Tired + 4;
                        this.Neglect = 0;
                        this.Boredom = 0;
                        this.Hunger = this.Hunger + 4;
                        break;


                    default:
                        Console.WriteLine("{0} got out of your sight and it took you a while to find him.");
                        break;
                   

                }
            }
        }
    }
    }

