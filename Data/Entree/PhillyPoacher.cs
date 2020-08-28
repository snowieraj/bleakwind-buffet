/*
* Author: Andrew Yi
* Class name: PhillyPoacher.cs
* Purpose: Menu item
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    public class PhillyPoacher
    {
        /// <summary>
        /// Gets price
        /// </summary>
        private double Price => 7.23;
        /// <summary>
        /// Gets calories
        /// </summary>
        public uint Calories => 784;
        /// <summary>
        /// Sirloin choice
        /// </summary>
        public bool Sirloin { get; set; } = true;
        /// <summary>
        /// Onion choice
        /// </summary>
        public bool Onion { get; set; } = true;
        /// <summary>
        /// Roll choice
        /// </summary>
        public bool Roll { get; set; } = true;
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
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }
        /// <summary>
        /// Override basic ToString method to return class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
