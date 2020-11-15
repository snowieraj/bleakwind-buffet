/*
* Author: Andrew Yi
* Class name: WarriorWater.cs
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
    /// Water
    /// </summary>
    public class WarriorWater : Drink, IOrderItem
    {
        public override string Description => "It's water. Just water.";
        /// <summary>
        /// Default menu item size
        /// </summary>
        public WarriorWater()
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
                if (Size == Size.Small) return 0;
                if (Size == Size.Medium) return 0;
                if (Size == Size.Large) return 0;
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
                if (Size == Size.Small) return 0;
                if (Size == Size.Medium) return 0;
                if (Size == Size.Large) return 0;
                throw new NotImplementedException($"Unknown calories of {Size}");
            }
        }
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
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }
        /// <summary>
        /// Lemon option defualt
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get => lemon;
            set
            {
                if (lemon != value)
                {
                    lemon = value;
                    PropertyChangedNotification("Lemon");
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }
        /// <summary>
        /// Set name of item
        /// </summary>
        public string Name => this.ToString();
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
