/*
* Author: Andrew Yi
* Class name: MarkarthMilk.cs
* Purpose: Menu item
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// 2% Milk
    /// </summary>
    public class MarkarthMilk : Drink, IOrderItem
    {
        /// <summary>
        /// Default menu size
        /// </summary>
        public MarkarthMilk()
        {
            Size = Size.Small;
        }

 
        /// <summary>
        /// Price for different size
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 1.05;
                if (Size == Size.Medium) return 1.11;
                if (Size == Size.Large) return 1.22;
                throw new NotImplementedException($"Unknown size of {Size}");//Dollar sign allows the {}
            }

        }
        /// <summary>
        /// Calories for different sizes
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 56;
                if (Size == Size.Medium) return 72;
                if (Size == Size.Large) return 93;
                throw new NotImplementedException($"Unknown calories of {Size}");
            }
        }
        /// <summary>
        /// Ice property - option
        /// </summary>
        private bool ice = false;
        public bool Ice
        {
            get => ice;
            set
            {
                if (ice != value)
                {
                    ice = value;
                    PropertyChangedNotification("Ice");
                }
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
            return $"{Size} Markarth Milk";
        }
    }
}
