/*
* Author: Andrew Yi
* Class name: PhillyPoacher.cs
* Purpose: Menu item
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.
    /// </summary>
    public class PhillyPoacher : Entree, IOrderItem
    {
        /// <summary>
        /// Gets price
        /// </summary>
        public override double Price => 7.23;
        /// <summary>
        /// Gets calories
        /// </summary>
        public override uint Calories => 784;
        /// <summary>
        /// Sirloin choice
        /// </summary>
        private bool sirloin = true;
        public bool Sirloin 
        {
            get => sirloin;
            set
            {
                if (sirloin != value)
                {
                    sirloin = value;
                    PropertyChangedNotification("Sirloin");
                }
            }
        }
        /// <summary>
        /// Onion choice
        /// </summary>
        private bool onion = true;
        public bool Onion
        {
            get => onion;
            set
            {
                if (onion != value)
                {
                    onion = value;
                    PropertyChangedNotification("Onion");
                }
            }
        }
        /// <summary>
        /// Roll choice
        /// </summary>
        private bool roll = true;
        public bool Roll
        {
            get => roll;
            set
            {
                if (roll != value)
                {
                    roll = value;
                    PropertyChangedNotification("Roll");
                }
            }
        }
        /// <summary>
        /// Private backing variable for specials
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Special instructions for menu item
        /// </summary>
        public override List<string> SpecialInstructions
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
        /// <returns>Menu item name</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
