/*
* Author: Andrew Yi
* Class name: SmokehouseSkeleton.cs
* Purpose: Menu item
*/using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.
    /// </summary>
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Gets the price for the breakfast combo
        /// </summary>
        private double Price => 5.62;
        /// <summary>
        /// Gets the calories for the meal
        /// </summary>
        public uint Calories => 602;
        /// <summary>
        /// Get the sausage value
        /// </summary>
        private bool sausageLink = true;
        public bool SausageLink
        {
            get => sausageLink;
            set => sausageLink = value;
        }
        /// <summary>
        /// Gets the option for egg
        /// </summary>
        private bool egg = true;
        public bool Egg
        {
            get => egg;
            set => egg = value;
        }
        /// <summary>
        /// Get hashbrown value
        /// </summary>
        private bool hashBrowns = true;
        public bool HashBrowns
        {
            get => hashBrowns;
            set => hashBrowns = value;
        }
        /// <summary>
        /// Gets pancake value
        /// </summary>
        private bool pancake = true;
        public bool Pancake
        {
            get => pancake;
            set => pancake = value;
        }

        /// <summary>
        /// Private backing variable for specials
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Special instructions for menu item
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!Pancake) instructions.Add("Hold pancakes");
                if (!HashBrowns) instructions.Add("Hold hash browns");

                return instructions;
            }
        }
        /// <summary>
        /// Override basic ToString method to return class
        /// </summary>
        /// <returns>Menu item name</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
