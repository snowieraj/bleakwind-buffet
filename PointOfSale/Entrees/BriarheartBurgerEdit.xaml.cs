/*Author: Andrew Yi
 *Class: BriarheartBurgerEdit.xaml.cs
 *Purpose: Control the buttons of this item
 */
using BleakwindBuffet.Data.Entrees;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for BriarheartBurgerEdit.xaml
    /// </summary>
    public partial class BriarheartBurgerEdit : UserControl
    {
        //Temp data construct
        BriarheartBurger itemTemp;
        /// <summary>
        /// menu ref
        /// </summary>
        private MenuScreen menuScreen = new MenuScreen();

    

        /// <summary>
        /// Class contrusct to get item chosen
        /// </summary>
        /// <param name="menuItem"></param>
        public BriarheartBurgerEdit(MenuScreen menuItem, BriarheartBurger temp)
        {
            InitializeComponent();
            menuScreen = menuItem;
            DataContext = temp;
            itemTemp = temp;
        }
        /// <summary>
        /// Go back button 
        /// </summary>
        /// <param name="sender">Click</param>
        /// <param name="e">event</param>
        void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            menuScreen.menuBorder.Child = menuScreen.buttonSelections;
        }


    }
}
