/*
* Author: Andrew Yi
* Class name: BriarheartBurger.cs
* Purpose: Menu item
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    public class BriarheartBurger
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        private double Price => 6.32; //lamba syntac property for price
        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public uint Calories => 732;
        /// <summary>
        /// Gets the Bun option
        /// </summary>
        public bool Bun { get; set; } = true;
    
        /// <summary>
        /// Gets the ketchup option
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Ketchup instructions
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold ketchup");
                else specialInstructions.Remove("Hold ketchup");
                ketchup = value;
            }
        }
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
            set => cheese = true;
        }
        /// <summary>
        /// Private backing variable
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Special instructions for menu item
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!ketchup) instructions.Add("Hold ketchup");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }
        /// <summary>
        /// Override basic ToString method to return class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }

    }
}
