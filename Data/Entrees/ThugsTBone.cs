/*
* Author: Andrew Yi
* Class name: thusTBone.cs
* Purpose: Menu item
*/using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Juicy T-Bone not much else to say
    /// </summary>
    public class ThugsTBone
    {
        /// <summary>
        /// Gets the price
        /// </summary>
        private double Price => 6.44;
        /// <summary>
        /// Gets the calories
        /// </summary>
        public uint Calories => 982;

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
               
                return instructions;
            }
        }
        /// <summary>
        /// Override basic ToString method to return class
        /// </summary>
        /// <returns>Menu item name</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
