/*
* Author: Andrew Yi
* Class name: Side.cs
* Purpose: Common properties of the item
*/
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common properties of sides
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size { get; set; }//Declared here and overrided in different classes
        /// <summary>
        /// The price of the side
        /// </summary>
        /// </value>
        /// In US dollars
        /// </value>
        public abstract double Price { get; }//Always going to overriding these
        /// <summary>
        /// The calories of the side
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Special Instructions to prepare the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
