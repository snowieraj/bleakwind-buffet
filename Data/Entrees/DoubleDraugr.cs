/*
* Author: Andrew Yi
* Class name: DoubleDraugr.cs
* Purpose: Menu item
*/
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Xml.Schema;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.
    /// </summary>
    public class DoubleDraugr : Entree, IOrderItem
    {
        public override string Description => "Double patty burger on a brioche bun. Comes with ketchup, mustard, " +
            "pickle, cheese, tomato, lettuce, and mayo.";
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 7.32;
        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 843;
        /// <summary>
        /// Gets the Bun option
        /// </summary>
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
        /// Set name of item
        /// </summary>
        public string Name => this.ToString();
        /// <summary>
        /// Private backing variable for specials
        /// </summary>
        //private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Special instruction for menu item
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
            return "Double Draugr";
        }
    }
}
