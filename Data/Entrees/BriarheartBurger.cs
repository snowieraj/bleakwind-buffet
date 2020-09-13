/*
* Author: Andrew Yi
* Class name: BriarheartBurger.cs
* Purpose: Menu item
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Menu;

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
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Gets the ketchup option
        /// </summary>       
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// Gets the mustard option
        /// </summary>
        private bool mustard = true;
        public bool Mustard
        {
            get => mustard;
            set => mustard = value;
        }
        /// <summary>
        /// Gets the pickle option
        /// </summary>
        private bool pickle = true;
        public bool Pickle
        {
            get => pickle;
            set => pickle = value;
        }
        /// <summary>
        /// Gets the cheese option
        /// </summary>
        private bool cheese = true;
        public bool Cheese
        {
            get => cheese;
            set => cheese = value;
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
