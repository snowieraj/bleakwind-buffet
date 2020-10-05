/*
* Author: Andrew Yi
* Class name: Entree.cs
* Purpose: Common properties of the item
*/
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing the common properties of entrees
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Property Changed Event Handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Invoking property changed notification
        /// </summary>
        /// <param name="name"></param>
        protected void PropertyChangedNotification(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        /// <summary>
        /// The price of the entree
        /// </summary>
        /// </value>
        /// US currency
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// The calories of the entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Special instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}
