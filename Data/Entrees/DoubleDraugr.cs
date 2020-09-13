﻿/*
* Author: Andrew Yi
* Class name: DoubleDraugr.cs
* Purpose: Menu item
*/
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Xml.Schema;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.
    /// </summary>
    public class DoubleDraugr : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 7.32;
        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 843;
        /// <summary>
        /// Gets the Bun option
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Gets the ketchup option
        /// </summary>       
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// Gets the mustard option
        /// </summary>
        private bool mustard = true;
        public bool Mustard
        {
            get => mustard;
            set => mustard = value;
        }
        /// <summary>
        /// Gets the pickle option
        /// </summary>
        private bool pickle = true;
        public bool Pickle
        {
            get => pickle;
            set => pickle = value;
        }
        /// <summary>
        /// Gets the cheese option
        /// </summary>
        private bool cheese = true;
        public bool Cheese
        {
            get => cheese;
            set => cheese = value;
        }
        /// <summary>
        /// Gets the tomato option
        /// </summary>
        private bool tomato = true;
        public bool Tomato
        {
            get => tomato;
            set => tomato = value;
        }
        /// <summary>
        /// Gets the lettuce option
        /// </summary>
        private bool lettuce = true;
        public bool Lettuce
        {
            get => lettuce;
            set => lettuce = value;
        }
        /// <summary>
        /// Gets the mayo option
        /// </summary>
        private bool mayo = true;
        public bool Mayo
        {
            get => mayo;
            set => mayo = value;
        }

        /// <summary>
        /// Private backing variable for specials
        /// </summary>
        //private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Special instruction for menu item
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Mustard) instructions.Add("Hold mustard");
                return instructions;
            }
        }
        /// <summary>
        /// Override basic ToString method to return class
        /// </summary>
        /// <returns>Menu item name</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
