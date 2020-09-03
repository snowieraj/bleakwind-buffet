/*
* Author: Andrew Yi
* Class name: VokunSalad.cs
* Purpose: Menu item
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A Fruit Salad
    /// </summary>
    public class VokunSalad
    {
        /// <summary>
        /// Default menu size
        /// </summary>
        VokunSalad()
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
                if (Size == Size.Small) return 0.93;
                if (Size == Size.Medium) return 1.28;
                if (Size == Size.Large) return 1.82;
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
                if (Size == Size.Small) return 41;
                if (Size == Size.Medium) return 52;
                if (Size == Size.Large) return 73;
                throw new NotImplementedException($"Unknown calories of {Size}");
            }
        }

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
 
                return instructions;
            }
        }
        /// <summary>
        /// Override basic ToString method to return class
        /// </summary>
        /// <returns>Menu item name</returns>
        public override string ToString()
        {
            return $"{Size} Vokun Salad";
        }

    }
}
