﻿/*
* Author: Andrew Yi
* Class name: MadOtarGrits.cs
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
    /// Cheesy Grits
    /// </summary>
    public class MadOtarGrits : Side, IOrderItem
    {
        public override string Description => "Cheesey Grits.";
        /// <summary>
        /// Default item sizes 
        /// </summary>
        public MadOtarGrits()
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
                if (Size == Size.Small) return 1.22;
                if (Size == Size.Medium) return 1.58;
                if (Size == Size.Large) return 1.93;
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
                if (Size == Size.Small) return 105;
                if (Size == Size.Medium) return 142;
                if (Size == Size.Large) return 179;
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
            return $"{Size} Mad Otar Grits";
        }
    }
}
