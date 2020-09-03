/*
* Author: Andrew Yi
* Class name: SailorsSoda.cs
* Purpose: Menu item
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorsSoda
    {
        /// <summary>
        /// Default item size
        /// </summary>
        SailorsSoda()
        {
            Size = Size.Small;
        }

        /// <summary>
        /// Size reference
        /// </summary>
        public Size Size { get; set; }
        /// <summary>
        /// Prices for different sizes
        /// </summary>
        public double Price
        {
            get
            {                
                if (Size == Size.Small) return 1.42;
                if (Size == Size.Medium) return 1.74;
                if (Size == Size.Large) return 2.07;
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
                if (Size == Size.Small) return 117;
                if (Size == Size.Medium) return 153;
                if (Size == Size.Large) return 205;
                throw new NotImplementedException($"Unknown calories of {Size}");
            }
        }
        /// <summary>
        /// Ice option defaulted to tr0ue
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Soda flavor defaulted to cherry
        /// </summary>
        public SodaFlavor Soda { get; set; } = SodaFlavor.Cherry;

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
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }
        /// <summary>
        /// Override basic ToString method to return class
        /// </summary>
        /// <returns>Menu item name</returns>
        public override string ToString()
        {
            return $"{Size} {Soda} Sailor Soda";
        }
    }
}
