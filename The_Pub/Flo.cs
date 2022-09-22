using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Pub
{
    class Flo:Human
    {
        public Flo(string name)
        {
            this.Name = name; //access protect memeber name
            this.Actions = new string[] { "looks for Andy", "looks at the drinks menu", "decides to go for a wee" };
        }
        public override void Greetings()
        {
            Console.WriteLine("Hi there, I'm {0}. I'm looking for me 'usbend!", Name);
        }
        public override void PerformAction(int actionNumber)
        {
            var chosenAction = this.Actions[actionNumber];
            Console.WriteLine(Name + " " + chosenAction);
        }
        public override void OrderDrink(string currentDrink)
        {
            Console.WriteLine("Hey, Bartender - I'd like a {0}", currentDrink);
        }
        public override void ConsumeDrink()
        {
            Random rnd = new Random();
            string[] drinkEffect = { " *yells* this is disguesting", " the drink hits him hard", " *makes him all jittery*", };
            int drinkF = rnd.Next(drinkEffect.Length);
            Console.WriteLine(Name + " {0}", drinkEffect[drinkF]);
            if (currentBuzzLevel != Human.BuzzLevel.Brain_Has_Left_The_Building)
            {
                this.currentBuzzLevel = this.currentBuzzLevel + 1;
            }
        }
        public override void SelfServer()
        {
            Console.WriteLine(Name + "jumps over the counter and serves him self a drink.");
        }
        public override void Punch(Human other)
        {
            Console.WriteLine(Name + " punches " + other.Name);
            other.currentDamgeLevel += 1;
            Console.WriteLine(Name + " : " + currentDamgeLevel);
        }
    }
}
