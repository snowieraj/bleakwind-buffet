/*
* Author: Andrew Yi
* Class name: GardenOrcOmelette.cs
* Purpose: Menu item
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        /// <summary>
        /// Gets the price
        /// </summary>
        private double Price => 4.57;
        /// <summary>
        /// Gets the cals
        /// </summary>
        private uint Calories => 404;
        /// <summary>
        /// Broccoli bool
        /// </summary>
        public bool Broccoli { get; set; } = true;
        /// <summary>
        /// Mushroom bool value
        /// </summary>
        public bool Mushrooms { get; set; } = true;
        /// <summary>
        /// Tomato bool value
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// Cheddar bool value
        /// </summary>
        public bool Cheddar { get; set; } = true;

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
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");

                return instructions;
            }
        }
        /// <summary>
        /// Override basic ToString method to return class
        /// </summary>
        /// <returns>Menu item name</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
