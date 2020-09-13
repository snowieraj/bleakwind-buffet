/*
* Author: Andrew Yi
* Class name: VokunSalad.cs
* Purpose: Menu item
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Menu;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A Fruit Salad
    /// </summary>
    public class VokunSalad : Side, IOrderItem
    {
        /// <summary>
        /// Default menu size
        /// </summary>
        public VokunSalad()
        {
            Size = Size.Small;
        }

        
        /// <summary>
        /// Prices for different menu items
        /// </summary>
        public override double Price
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
        public override uint Calories
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
        //private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Special instructions for menu items 
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
            return $"{Size} Vokun Salad";
        }

    }
}
