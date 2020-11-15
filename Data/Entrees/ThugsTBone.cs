/*
* Author: Andrew Yi
* Class name: ThugsTBone.cs
* Purpose: Menu item
*/using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Juicy T-Bone not much else to say
    /// </summary>
    public class ThugsTBone : Entree, IOrderItem
    {
        public override string Description => "Juicy T-Bone, not much else to say.";
        /// <summary>
        /// Gets the price
        /// </summary>
        public override double Price => 6.44;
        /// <summary>
        /// Gets the calories
        /// </summary>
        public override uint Calories => 982;
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
