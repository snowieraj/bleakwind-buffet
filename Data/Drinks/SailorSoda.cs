/*
* Author: Andrew Yi
* Class name: SailorsSoda.cs
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
    /// Old-Fashioned Soda
    /// </summary>
    public class SailorSoda : Drink, IOrderItem
    {
        /// <summary>
        /// Default item size
        /// </summary>
        public SailorSoda()
        {
            Size = Size.Small;
        }

        //Size is now Virtual

        /// <summary>
        /// Prices for different sizes
        /// </summary>
        public override double Price
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
        public override uint Calories 
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
        /// <summary>
        /// Ice property - option
        /// </summary>
        private bool ice = true;
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
        /// Soda flavor defaulted to cherry
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get => flavor;
            set
            {
                if (flavor != value)
                {
                    flavor = value;
                    PropertyChangedNotification("Flavor");
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
            return $"{Size} {Flavor} Sailor Soda";
        }
    }
}
