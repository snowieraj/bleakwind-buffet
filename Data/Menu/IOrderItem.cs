/*
* Author: Andrew Yi
* Class name: IOrderItem.cs
* Purpose: Ordered Items
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Menu
{
    /// <summary>
    /// A base class representing the ordered item
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        

        /// <summary>
        /// The price of the item
        /// </summary>
        /// </value>
        /// US Currency
        /// </value>
        double Price { get; }
        /// <summary>
        /// The calories of the item
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// Special Instructions to prepare the item
        /// </summary>
        List<string> SpecialInstructions { get; }

    }
}
