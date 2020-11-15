/*
* Author: Andrew Yi
* Class name: SmokehouseSkeleton.cs
* Purpose: Menu item
*/using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem
    {
        public override string Description => " Put some meat on those bones with a small stack of pancakes. " +
            "Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";
        /// <summary>
        /// Gets the price for the breakfast combo
        /// </summary>
        public override double Price => 5.62;
        /// <summary>
        /// Gets the calories for the meal
        /// </summary>
        public override uint Calories => 602;
        /// <summary>
        /// Get the sausage value
        /// </summary>
        private bool sausageLink = true;
        public bool SausageLink
        {
            get => sausageLink;
            set
            {
                if (sausageLink != value)
                {
                    sausageLink = value;
                    PropertyChangedNotification("SausageLink");
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }
        /// <summary>
        /// Gets the option for egg
        /// </summary>
        private bool egg = true;
        public bool Egg
        {
            get => egg;
            set
            {
                if (egg != value)
                {
                    egg = value;
                    PropertyChangedNotification("Egg");
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }
        /// <summary>
        /// Get hashbrown value
        /// </summary>
        private bool hashBrowns = true;
        public bool HashBrowns
        {
            get => hashBrowns;
            set
            {
                if (hashBrowns != value)
                {
                    hashBrowns = value;
                    PropertyChangedNotification("HashBrowns");
                    PropertyChangedNotification("SpecialInstructions");
                }
            }
        }
        /// <summary>
        /// Gets pancake value
        /// </summary>
        private bool pancake = true;
        public bool Pancake
        {
            get => pancake;
            set
            {
                if (pancake != value)
                {
                    pancake = value;
                    PropertyChangedNotification("Pancake");
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
        public override  List<string> SpecialInstructions
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
        /// Set name of item
        /// </summary>
        public string Name => this.ToString();
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
