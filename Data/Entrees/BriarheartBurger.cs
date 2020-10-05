/*
* Author: Andrew Yi
* Class name: BriarheartBurger.cs
* Purpose: Menu item
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Menu;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.
    /// </summary>
    public class BriarheartBurger : Entree, IOrderItem
    {
  
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 6.32; //lamba syntac property for price
        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 743;


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
                }
            }
        }
        /// <summary>
        /// Private backing variable
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
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }
        /// <summary>
        /// Override basic ToString method to return class
        /// </summary>
        /// <returns>Menu item name</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }

    }
}
