using PointOfSale;
using System;
using System.Collections.Generic;
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

namespace RoundRegister
{
    /// <summary>
    /// Interaction logic for CashOption.xaml
    /// </summary>
    public partial class CashOption : UserControl
    {
        private MenuScreen menuScreen;
        public CashOption()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Return the button menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnToMenu_Click(object sender, RoutedEventArgs e)
        {
            
        }
        /// <summary>
        /// Finalze sale 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FinalizeSale_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
