/*
* Author: Andrew Yi
* Class name: Drink.cs
* Purpose: Common properties of the item
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Xml.Schema;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink : INotifyPropertyChanged
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
        /// Deafult Size 
        /// </summary>
        protected Size size = Size.Small;
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size //Declared here and overrided in different classes
        {
            get => size;
            set
            {
                if (size!= value)
                {
                    size = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
            }
        }
      
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
