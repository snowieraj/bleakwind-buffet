/*
* Author: Andrew Yi
* Class name: WarriorWater.cs
* Purpose: Menu item
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Water
    /// </summary>
    public class WarriorWater
    {
        /// <summary>
        /// Default menu item size
        /// </summary>
        WarriorWater()
        {
            Size = Size.Small;
        }

        /// <summary>
        /// Size reference
        /// </summary>
        public Size Size { get; set; }
        /// <summary>
        /// Prices for different menu items
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 0;
                if (Size == Size.Medium) return 0;
                if (Size == Size.Large) return 0;
                throw new NotImplementedException($"Unknown size of {Size}");//Dollar sign allows the {}
            }

        }
        /// <summary>
        /// Calories for different menu items
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 0;
                if (Size == Size.Medium) return 0;
                if (Size == Size.Large) return 0;
                throw new NotImplementedException($"Unknown calories of {Size}");
            }
        }
        /// <summary>
        /// Ice option default
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Lemon option defualt
        /// </summary>
        public bool Lemon { get; set; } = false;

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
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }
        /// <summary>
        /// Override basic ToString method to return class
        /// </summary>
        /// <returns>Menu item name</returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }
    }
}
