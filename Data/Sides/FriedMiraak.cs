﻿/*
* Author: Andrew Yi
* Class name: FriedMiraak.cs
* Purpose: Menu item
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Hash Brown Pancakes
    /// </summary>
    public class FriedMiraak : Side, IOrderItem
    {
        public override string Description => "Perfectly prepared hash brown pancakes.";
        /// <summary>
        /// Default item size
        /// </summary>
        public FriedMiraak()
        {
            Size = Size.Small;
        }
        //Gets the name of item
        public string Name => this.ToString();

        /// <summary>
        /// Prices for different sizes
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 1.78;
                if (Size == Size.Medium) return 2.01;
                if (Size == Size.Large) return 2.88;
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
                if (Size == Size.Small) return 151;
                if (Size == Size.Medium) return 236;
                if (Size == Size.Large) return 306;
                throw new NotImplementedException($"Unknown calories of {Size}");
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

                return instructions;
            }
        }
        /// <summary>
        /// Override basic ToString method to return class
        /// </summary>
        /// <returns>Menu item name</returns>
        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }
    }
}
