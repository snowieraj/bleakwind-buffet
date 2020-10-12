using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;


namespace BleakwindBuffet.Data.Menu
{
    public class Combination : IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Property notification when side, entree, drink change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        
        

        /// <summary>
        /// Drink property changed
        /// </summary>
        private Drink drink;
        public Drink Drink
        {
            get { return drink; }
            set
            {
                if (drink != value)
                {
                    if (drink != null) entree.PropertyChanged -= SelectedItemChangedListener;
                    drink = value;
                    entree.PropertyChanged += SelectedItemChangedListener;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                }
            }
        }
        /// <summary>
        /// Side property changed
        /// </summary>
        private Side side;
        public Side Side
        {
            get => side;
            set
            {
                if (side != value)
                {
                    if (side != null) entree.PropertyChanged -= SelectedItemChangedListener;
                    side = value;
                    entree.PropertyChanged += SelectedItemChangedListener;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                }
            }
        }
        /// <summary>
        /// Entry property changed
        /// </summary>
        private Entree entree;
        public Entree Entree
        {
            get => entree;
            set
            {
                if (entree != value)
                {
                    if (entree != null) entree.PropertyChanged -= SelectedItemChangedListener;
                    entree = value;
                    entree.PropertyChanged += SelectedItemChangedListener;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                }
            }
        }


        public Combination(Entree entree, Side side, Drink drink)
        {
            this.entree = entree;
            this.side = side;
            this.drink = drink;
        }

        /// <summary>
        /// Special instructions changed
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> special = new List<string>();
                special.Add(Entree.ToString());
                special.AddRange(Entree.SpecialInstructions);
                special.Add(Side.ToString());
                special.AddRange(Side.SpecialInstructions);
                special.Add(Drink.ToString());
                special.AddRange(Drink.SpecialInstructions);
                return special;
            }
        }
        /// <summary>
        /// Total price
        /// </summary>
        public double Price => Drink.Price + Entree.Price + Side.Price;
        /// <summary>
        /// Total calories
        /// </summary>
        public uint Calories => Drink.Calories + Entree.Calories + Side.Calories;

        void SelectedItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            switch(e.PropertyName)
            {
                case "Price":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    break;
                case "Calories":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    break;
                case "SpecialInstructions":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    break;
            }
        }

    }
}
