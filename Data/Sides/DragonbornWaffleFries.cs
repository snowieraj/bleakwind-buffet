/*
* Author: Andrew Yi
* Class name: DragonbornWaffleFries.cs
* Purpose: Menu item
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Cajun Fries
    /// </summary>
    public class DragonbornWaffleFries : Side, IOrderItem
    {
        public override string Description => "Crispy fried potato waffle fries.";
        /// <summary>
        /// Setting default size
        /// </summary>
        public DragonbornWaffleFries()

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
                if (Size == Size.Small) return 0.42;
                if (Size == Size.Medium) return 0.76;
                if (Size == Size.Large) return 0.96;
                throw new NotImplementedException($"Unknown size of {Size}");//Dollar sign allows the {}
            }

        }
        /// <summary>
        /// Calories vor different sizes
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 77;
                if (Size == Size.Medium) return 89;
                if (Size == Size.Large) return 100;
                throw new NotImplementedException($"Unknown calories of {Size}");
            }
        }

        /// <summary>
        /// Private backing variable for specials
        /// </summary>
        //private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Special instructions for item
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
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
