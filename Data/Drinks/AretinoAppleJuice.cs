/*
* Author: Andrew Yi
* Class name: ArentinoAppleJuice.cs
* Purpose: Menu item
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Apple Juice
    /// </summary>
    public class AretinoAppleJuice
    {
        
        /// <summary>
        /// Default item size
        /// </summary>
        public AretinoAppleJuice()
        {
            Size = Size.Small;
        }
        

        /// <summary>
        /// Size reference
        /// </summary>
        public Size Size { get; set; } = Size.Small;
        /// <summary>
        /// Price for differents sizes
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 0.62;
                if (Size == Size.Medium) return 0.87;
                if (Size == Size.Large) return 1.01;
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
                if (Size == Size.Small) return 44;
                if (Size == Size.Medium) return 88;
                if (Size == Size.Large) return 132;
                throw new NotImplementedException($"Unknown calories of {Size}");
            }
        }
        /// <summary>
        /// Ice property - option
        /// </summary>
        public bool Ice { get; set; } = false;
  

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
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }
        /// <summary>
        /// Override basic ToString method to return class
        /// </summary>
        /// <returns>Menu item name</returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }
    }
}
