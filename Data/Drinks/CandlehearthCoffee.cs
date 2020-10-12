/*
* Author: Andrew Yi
* Class name: CandlehearthCoffee.cs
* Purpose: Menu item
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System.ComponentModel;
using System.Xml.Schema;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Coffee
    /// </summary>
    public class CandlehearthCoffee : Drink, IOrderItem
    {
        /// <summary>
        /// Default size for menu item
        /// </summary>
        public CandlehearthCoffee()
        {
            Size = Size.Small;
        }

        public string Name => this.ToString();

        /// <summary>
        /// Prices for different sizes
        /// </summary>
        public override double Price
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
        public override uint Calories
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
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }
        /// <summary>
        /// cream option
        /// </summary>
        private bool roomforcream = false;
        public bool RoomForCream
        {
            get => roomforcream;
            set
            {
                if (roomforcream != value)
                {
                    roomforcream = value;
                    PropertyChangedNotification("RoomForCream");
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }
        /// <summary>
        /// Decaf option
        /// </summary>
        private bool decaf = false;
        public bool Decaf
        {
            get => decaf;
            set
            {
                if (decaf != value)
                {
                    decaf = value;
                    PropertyChangedNotification("Decaf");
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
