using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Pub
{
    public abstract class Human
    {
        protected string name;
        public string[] Actions;
        //abstract methods, these can be overidden in derived classes

        public abstract void Greetings();
        public abstract void OrderDrink(string drinkName);
        public abstract void ConsumeDrink();
        public abstract void PerformAction(int actionNumber);
        public abstract void SelfServer();
        public abstract void Punch(Human other);
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public enum BuzzLevel
        {
            Sober = 1,
            Rare = 2,
            Medium = 3,
            Well_Done = 4,
            Toasted = 5,
            Fairly_Silly = 6,
            Plain_Stupid = 7,
            Wasted = 8,
            Brain_Has_Left_The_Building = 9
        }
        public enum DamgeLevel
        {
            Perfectly_Fine = 1,
            Off_Balance = 2,
            Dizzy = 3,
            Badly_Hurt = 4,
            Unconscious = 5,
            Dead = 6
        }
        // human properties we will want to get and set from the main method

        public BuzzLevel currentBuzzLevel { get; set; }
        public DamgeLevel currentDamgeLevel { get; set; }
    }
}
