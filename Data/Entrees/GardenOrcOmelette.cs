/*
* Author: Andrew Yi
* Class name: GardenOrcOmelette.cs
* Purpose: Menu item
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price
        /// </summary>
        public override double Price => 4.57;
        /// <summary>
        /// Gets the cals
        /// </summary>
        public override uint Calories => 404;
        /// <summary>
        /// Broccoli bool
        /// </summary>
        private bool broccoli = true;
        public bool Broccoli
        {
            get => broccoli;
            set
            {
                if (broccoli != value)
                {
                    broccoli = value;
                    PropertyChangedNotification("Broccoli");
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }
        /// <summary>
        /// Set name of item
        /// </summary>
        public string Name => this.ToString();
        /// <summary>
        /// Mushroom bool value
        /// </summary>
        private bool mushrooms = true;
        public bool Mushrooms
        {
            get => mushrooms;
            set
            {
                if (mushrooms != value)
                {
                    mushrooms = value;
                    PropertyChangedNotification("Mushrooms");
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }
        /// <summary>
        /// Tomato bool value
        /// </summary>
        private bool tomato = true;
        public bool Tomato
        {
            get => tomato;
            set
            {
                if (tomato != value)
                {
                    tomato = value;
                    PropertyChangedNotification("Tomato");
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }
        /// <summary>
        /// Cheddar bool value
        /// </summary>
        private bool cheddar = true;
        public bool Cheddar
        {
            get => cheddar;
            set
            {
                if (cheddar != value)
                {
                    cheddar = value;
                    PropertyChangedNotification("Cheddar");
                    PropertyChangedNotification("SpecialInstructions");
                }
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
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");

                return instructions;
            }
        }
        /// <summary>
        /// Override basic ToString method to return class
        /// </summary>
        /// <returns>Menu item name</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
