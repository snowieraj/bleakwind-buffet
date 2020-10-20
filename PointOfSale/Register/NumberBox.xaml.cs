using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale.Register
{
    /// <summary>
    /// Interaction logic for NumberBox.xaml
    /// </summary>
    public partial class NumberBox : UserControl, INotifyPropertyChanged
    {

        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(NumberBox), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Property event notifier 
        /// </summary>
        /// <param name="name"></param>
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public NumberBox()
        {
            InitializeComponent();
     
        }
        /// <summary>
        /// Get set the current value of the box
        /// </summary>
        public int Value
        {
            get => (int)GetValue(ValueProperty);
            set
            {
                SetValue(ValueProperty, value);
                OnPropertyChanged("Value");
            }
        }
        //Add one to the box
        void Increment_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            Value++;
        }
        //Sub one from the box
        void Decrement_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            if(Value > 0)
            {
                Value--;
            }
            else
            {
                Value = 0;
            }
        }

    }
}
