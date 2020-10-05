/*
* Author: Andrew Yi
* Class name: ArentinoAppleJuice.cs
* Purpose: Menu item
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Apple Juice
    /// </summary>
    public class AretinoAppleJuice : Drink, IOrderItem
    {
        
        /// <summary>
        /// Default item size
        /// </summary>
        public AretinoAppleJuice()
        {
            Size = Size.Small;
        }
        

        /// <summary>
        /// Price for differents sizes
        /// </summary>
        public override double Price
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
        public override uint Calories
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
        /// Special instructions for menu item
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
            return $"{Size} Aretino Apple Juice";
        }
    }
}
