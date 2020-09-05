/*
* Author: Andrew Yi
* Class name: ThalmorTriple.cs
* Purpose: Menu item
*/using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.
    /// </summary>
    public class ThalmorTriple
    {
        /// <summary>
        /// Gets the price for the burger
        /// </summary>
        public double Price => 8.32;
        /// <summary>
        /// Gets the calories for the burger
        /// </summary>
        public uint Calories => 943;
        /// <summary>
        /// Gets the Bun option
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Gets the ketchup option
        /// </summary>
        private bool ketchup = true;
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
            set => cheese = value;
        }
        /// <summary>
        /// Gets the tomato option
        /// </summary>
        private bool tomato = true;
        public bool Tomato
        {
            get => tomato;
            set => tomato = value;
        }
        /// <summary>
        /// Gets the lettuce option
        /// </summary>
        private bool lettuce = true;
        public bool Lettuce
        {
            get => lettuce;
            set => lettuce = value;
        }
        /// <summary>
        /// Gets the mayo option
        /// </summary>
        private bool mayo = true;
        public bool Mayo
        {
            get => mayo;
            set => mayo = value;
        }
        /// <summary>
        /// Gets the option for bacon
        /// </summary>
        private bool bacon = true;
        public bool Bacon
        {
            get => bacon;
            set => bacon = value;
        }
        /// <summary>
        /// Gets the option for egg
        /// </summary>
        private bool egg = true;
        public bool Egg
        {
            get => egg;
            set => egg = value;
        }
        /// <summary>
        /// Private backing variable for specials
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
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold eggs");
                if (!mustard) instructions.Add("Hold mustard");
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
