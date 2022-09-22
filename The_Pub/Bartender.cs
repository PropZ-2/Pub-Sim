using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Pub
{
    public class Bartender : Human
    {
        public string[] Recipes = { "Sex on the beach", "Vodka Martine", "Screwdriver", "Bloody Mary", "Alien Turpentine", "Lemon Twister", "Dark and Stormy", "Strawbarry Dakkery", "Old Fashion" };

        public Bartender(string name)
        {
            this.Name = name;
            this.Actions = new string[] {"check the cash register.. yep, it's full!",
                                    "gives the pub dog a fresh bowl of water",
                                    "fills up the peanut bag dispenser.",
                                    "fashes his hands and looks into the sink, and wishes he hadn't!",
                                    "looks in the fridge to check for possible aliens on the lam"};
        }
        public override void Greetings()
        {
            Console.WriteLine("hi there, I'm {0}. this is my bar, and you will be serverd! ", Name);
        }
        public override void SelfServer()
        {
        }
        public override void PerformAction(int actionNumber)
        {
            var chosenAction = this.Actions[actionNumber];
            Console.WriteLine(Name + " " + chosenAction);
        }
        public override void OrderDrink(string currentDrink)
        {
            Console.WriteLine("I'm the bartender - I don't drink {0}", currentDrink);
        }
        public override void ConsumeDrink()
        {
            Console.WriteLine("Barkeep disappears the drink mysteriously, to be scrutinized later on. ");
        }
        public void Comment(Human myCustomer)
        {
            switch (myCustomer.currentBuzzLevel)
            {
                case Human.BuzzLevel.Sober:
                    Console.WriteLine("Hello " + myCustomer.Name + " Your drink is coming right up.. how is the weather outside?");
                    break;
                case Human.BuzzLevel.Rare:
                    Console.WriteLine(myCustomer.Name + " your drink is coming right up. It's a rare treat in here to have a customers like you!");
                    break;
                case Human.BuzzLevel.Medium:
                    Console.WriteLine(myCustomer.Name + " Your drink is coming right up. medium size..");
                    break;
                case Human.BuzzLevel.Well_Done:
                    Console.WriteLine(myCustomer.Name + " you are looking tired. are you well done?");
                    break;
                case Human.BuzzLevel.Toasted:
                    Console.WriteLine(myCustomer.Name + " your face is turning red. I think you have gotten enoghe.");
                    break;
                case Human.BuzzLevel.Fairly_Silly:
                    Console.WriteLine(myCustomer.Name + " you are being silly.");
                    break;
                case Human.BuzzLevel.Plain_Stupid:
                    Console.WriteLine(myCustomer.Name + ". I think you have had enoghe for today.");
                    break;
                case Human.BuzzLevel.Wasted:
                    Console.WriteLine("i'm sorry " + myCustomer.Name + " I'm affrid i can't server you anymore drinks");
                    break;
                default:
                    Console.WriteLine("Moment, sir..");
                    break;
            }
        }
        public void serveDrink(string currentDrink)
        {
            PubSimulator.Wait();
            Console.WriteLine(Name + " serves up a " + currentDrink + " for the customer.");
        }
        public override void Punch(Human other)
        {
        }
    }
}
