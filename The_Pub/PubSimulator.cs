using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace The_Pub
{
    class PubSimulator
    {
        private static int delay = 1500;
        public static List<Human> myHumans = new List<Human>();

        public void RunPubSimulation()
        {
            Human andy = new Andy("Andy Capp");
            Human chalkie = new Chalkie("Chalkie");
            Human flo = new Flo("Flo");
            Bartender bartender = new Bartender("George");

            myHumans.Add(andy);
            myHumans.Add(chalkie);
            myHumans.Add(bartender);
            myHumans.Add(flo);

            andy.Greetings();
            chalkie.Greetings();
            bartender.Greetings();
            Wait();

            foreach (Human dude in myHumans)
            {
                int actionInt = RandomInteger(dude.Actions.Count());
                dude.PerformAction(actionInt);
            }
            andy.currentBuzzLevel = Human.BuzzLevel.Sober;
            andy.currentDamgeLevel = Human.DamgeLevel.Perfectly_Fine;
            chalkie.currentBuzzLevel = Human.BuzzLevel.Sober;
            chalkie.currentDamgeLevel = Human.DamgeLevel.Perfectly_Fine;
            flo.currentBuzzLevel = Human.BuzzLevel.Sober;

            for (int counter = 0; counter < bartender.Recipes.Count(); counter++)
            {
                int x = RandomInteger(bartender.Recipes.Count());
                string drinkName = bartender.Recipes[x];
                andy.OrderDrink(drinkName);
                bartender.Comment(andy);
                if (Convert.ToInt32(andy.currentBuzzLevel) >= 8)
                {
                    andy.SelfServer();
                }
                else
                {
                    bartender.serveDrink(drinkName);
                }
                Wait();
                andy.ConsumeDrink();
                chalkie.ConsumeDrink();
                if (Convert.ToInt32(andy.currentBuzzLevel) >= 3)
                    break;

                Console.WriteLine("Andy now has a buzz level of {0}", andy.currentBuzzLevel);
                Wait();
            }
            while(Convert.ToInt32(andy.currentDamgeLevel) < 4 && Convert.ToInt32(chalkie.currentDamgeLevel) < 4)
            {
                chalkie.Punch(andy);
                andy.Punch(chalkie);
            }
            flo.Greetings();
            for (int counter = 0; counter < 2; counter++)
            {
                int x = RandomInteger(bartender.Recipes.Count());
                string drinkName = bartender.Recipes[x];
                flo.OrderDrink(drinkName);
                bartender.Comment(flo);
                flo.ConsumeDrink();
            }
            Console.WriteLine("Flo drags andy home");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            PubSimulator p = new PubSimulator();
            p.RunPubSimulation();
        }
        public static void Wait()
        {
            Thread.Sleep(delay);
        }
        public static int RandomInteger(int max, int min = 0)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
