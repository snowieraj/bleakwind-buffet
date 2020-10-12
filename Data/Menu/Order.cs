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

namespace BleakwindBuffet.Data.Menu
{
    public class Order : INotifyPropertyChanged, ICollection<IOrderItem>, INotifyCollectionChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        private List<IOrderItem> list = new List<IOrderItem>();
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

        public bool Remove(IOrderItem item)
        {
            int index = list.FindIndex(i => i == item);
            var remove = list.Remove(item);
            

            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            return remove;
        }




        public double SalesTaxRate { get; set; } = 0.12;
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
        public double Tax { get => Subtotal * SalesTaxRate; } 
        public double Total { get => Subtotal + Tax; }
        uint Calories
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

        

        public int Count => list.Count;

        public bool IsReadOnly => false;

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

      

        public void Clear()
        {
            foreach (IOrderItem a in list)
            {
                a.PropertyChanged -= CollectionChangedListener;
            }
            list.Clear();
        }

        public bool Contains(IOrderItem item)
        {
            return list.Contains(item);
        }

        public void CopyTo(IOrderItem[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

    

        IEnumerator<IOrderItem> IEnumerable<IOrderItem>.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)list).GetEnumerator();
        }

        private static uint nextOrderNumber = 1;

        public uint Number { get; set; }


        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
        }

    }
}
