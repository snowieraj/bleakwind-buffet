/*
* Author: Andrew Yi
* Class name: IOrderItem.cs
* Purpose: Ordered Items
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using System.Net.Http;

namespace BleakwindBuffet.Data.Menu
{
    /// <summary>
    /// Creating an order
    /// </summary>
    public class Order : INotifyPropertyChanged, ICollection<IOrderItem>, INotifyCollectionChanged

    {
        //Property Changed Event Handler
        public event PropertyChangedEventHandler PropertyChanged;
        //Notify the Collection Event Handler
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        //List of item in the order
        private List<IOrderItem> list = new List<IOrderItem>();
        /// <summary>
        /// Adding to the order/list
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {

            list.Add(item);
            item.PropertyChanged += CollectionChangedListener;
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));


        }
        /// <summary>
        /// Update the collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));

            }
            if (e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
        /// <summary>
        /// Revoving from the list
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(IOrderItem item)
        {
            int index = list.FindIndex(i => i == item);
            var remove = list.Remove(item);

            try { 
                CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                return remove;
            }
            catch (Exception e)
            {
                return false;
            }
           

        }
        /// <summary>
        /// Sales Tax rate
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;
        /// <summary>
        /// Subtotal of items
        /// </summary>
        public double Subtotal
        {
            get
            {
                double temp = 0;
                foreach (IOrderItem item in list)
                {
                    temp += item.Price;

                }
                return temp;
            }
        }
        /// <summary>
        /// Total tax of items
        /// </summary>
        public double Tax { get => Subtotal * SalesTaxRate; } 
        /// <summary>
        /// Total of items
        /// </summary>
        public double Total { get => Subtotal + Tax; }

        /// <summary>
        /// Calories of total items
        /// </summary>
        public uint Calories
        {
            get
            {
                uint temp = 0;
                foreach (IOrderItem item in list)
                {
                    temp += item.Calories;

                }
                return temp;
            }
        }

        
        /// <summary>
        /// Count of items
        /// </summary>
        public int Count => list.Count;
        //Read only 
        public bool IsReadOnly => false;
        /// <summary>
        /// Copy to function not used though
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

      
        /// <summary>
        /// Clear list
        /// </summary>
        public void Clear()
        {
            foreach (IOrderItem a in list)
            {
                a.PropertyChanged -= CollectionChangedListener;
            }
            list.Clear();
        }
        /// <summary>
        /// What is contained search in the list
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(IOrderItem item)
        {
            return list.Contains(item);
        }
        /// <summary>
        /// Copy to list
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public void CopyTo(IOrderItem[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

    
        /// <summary>
        /// Ie Getter
        /// </summary>
        /// <returns>list enum</returns>
        IEnumerator<IOrderItem> IEnumerable<IOrderItem>.GetEnumerator()
        {
            return list.GetEnumerator();
        }
        /// <summary>
        /// Get list
        /// </summary>
        /// <returns>list enum</returns>
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)list).GetEnumerator();
        }
        /// <summary>
        /// Next order number
        /// </summary>
        private static uint nextOrderNumber = 1;
        /// <summary>
        /// Order number
        /// </summary>
        public uint Number { get; set; }

        /// <summary>
        /// Order construct - increments the next order number
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
        }

    }
}
