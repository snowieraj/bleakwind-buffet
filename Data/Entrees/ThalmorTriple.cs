/*
* Author: Andrew Yi
* Class name: ThalmorTriple.cs
* Purpose: Menu item
*/using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.
    /// </summary>
    public class ThalmorTriple : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price for the burger
        /// </summary>
        public override double Price => 8.32;
        /// <summary>
        /// Gets the calories for the burger
        /// </summary>
        public override uint Calories => 943;
        /// <summary>
        /// Gets the Bun option
        /// </summary>
        private bool bun = true;
        public bool Bun
        {
            get { return bun; }
            set
            {
                if (bun != value)
                {
                    bun = value;
                    PropertyChangedNotification("Bun");
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }


        /// <summary>
        /// Gets the ketchup option
        /// </summary>       
        private bool ketchup = true;
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                if (ketchup != value)
                {
                    ketchup = value;
                    PropertyChangedNotification("Ketchup");
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }
        /// <summary>
        /// Gets the mustard option
        /// </summary>
        private bool mustard = true;
        public bool Mustard
        {
            get => mustard;

            set
            {
                if (mustard != value)
                {
                    mustard = value;
                    PropertyChangedNotification("Mustard");
                    PropertyChangedNotification("SpecialInstructions");
                }
            }


        }
        /// <summary>
        /// Gets the pickle option
        /// </summary>
        private bool pickle = true;
        public bool Pickle
        {
            get => pickle;
            set
            {
                if (pickle != value)
                {
                    pickle = value;
                    PropertyChangedNotification("Pickle");
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }
        /// <summary>
        /// Gets the cheese option
        /// </summary>
        private bool cheese = true;
        public bool Cheese
        {
            get => cheese;
            set
            {
                if (cheese != value)
                {
                    cheese = value;
                    PropertyChangedNotification("Cheese");
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }
        /// <summary>
        /// Gets the tomato option
        /// </summary>
        private bool tomato = true;
        public bool Tomato
        {
            get => tomato;
            set
            {
                if (tomato != value)
                {
                    tomato = value;
                    PropertyChangedNotification("Tomato");
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }
        /// <summary>
        /// Gets the lettuce option
        /// </summary>
        private bool lettuce = true;
        public bool Lettuce
        {
            get => lettuce;
            set
            {
                if (lettuce != value)
                {
                    lettuce = value;
                    PropertyChangedNotification("Lettuce");
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }
        /// <summary>
        /// Gets the mayo option
        /// </summary>
        private bool mayo = true;
        public bool Mayo
        {
            get => mayo;
            set
            {
                if (mayo != value)
                {
                    mayo = value;
                    PropertyChangedNotification("Mayo");
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }
        /// <summary>
        /// Gets the option for bacon
        /// </summary>
        private bool bacon = true;
        public bool Bacon
        {
            get => bacon;
            set
            {
                if(bacon != value)
                {
                    bacon = value;
                    PropertyChangedNotification("Bacon");
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }
        /// <summary>
        /// Gets the option for egg
        /// </summary>
        private bool egg = true;
        public bool Egg
        {
            get => egg;
            set
            {
                if (egg != value)
                {
                    egg = value;
                    PropertyChangedNotification("Egg");
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }
        /// <summary>
        /// Set name of item
        /// </summary>
        public string Name => this.ToString();
        /// <summary>
        /// Private backing variable for specials
        /// </summary>
        //private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Special instructions for menu item
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                if (!Mustard) instructions.Add("Hold mustard");
                return instructions;
            }
        }
        /// <summary>
        /// Override basic ToString method to return class
        /// </summary>
        /// <returns>Menu item name</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
