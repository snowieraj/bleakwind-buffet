/*
* Author: Andrew Yi
* Class name: Drink.cs
* Purpose: Common properties of the item
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size { get; set; }//Declared here and overrided in different classes
        /// <summary>
        /// The price of the drink
        /// </summary>
        /// </value>
        /// In US dollars
        /// </value>
        public abstract double Price { get; }//Always going to overriding these
        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Special Instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}
