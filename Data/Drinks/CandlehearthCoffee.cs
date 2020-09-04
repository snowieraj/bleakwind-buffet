/*
* Author: Andrew Yi
* Class name: CandlehearthCoffee.cs
* Purpose: Menu item
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Coffee
    /// </summary>
    public class CandlehearthCoffee
    {
        /// <summary>
        /// Default size for menu item
        /// </summary>
        public CandlehearthCoffee()
        {
            Size = Size.Small;
        }


        public Size Size { get; set; }
        /// <summary>
        /// Prices for different sizes
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 0.75;
                if (Size == Size.Medium) return 1.25;
                if (Size == Size.Large) return 1.75;
                throw new NotImplementedException($"Unknown size of {Size}");//Dollar sign allows the {}
            }

        }
        /// <summary>
        /// Calories for different sizes 
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 7;
                if (Size == Size.Medium) return 10;
                if (Size == Size.Large) return 20;
                throw new NotImplementedException($"Unknown calories of {Size}");
            }
        }
        /// <summary>
        /// Ice option
        /// </summary>
        public bool Ice { get; set; } = false;
        /// <summary>
        /// cream option
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        /// <summary>
        /// Decaf option
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Private backing variable for specials
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Special instructions for menu items
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                
                return instructions;
            }
        }
        /// <summary>
        /// Override basic ToString method to return class
        /// </summary>
        /// <returns>Menu item name</returns>
        public override string ToString()
        {
            if (!Decaf) return $"{Size} Candlehearth Coffee";
            else
            {
                return $"{Size} Decaf Candlehearth Coffee";
            }
        }
    }
}
