/*Author: Andrew Yi
 *Class: AretinoAppleJuiceEdit.xaml.cs
 *Purpose: Control the buttons of this item
 */
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

namespace PointOfSale.Drinks
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ArentinoAppleJuiceEdit : UserControl
    {
        /// <summary>
        /// Menu contructor/ref
        /// </summary>
        private MenuScreen menuScreen = new MenuScreen();
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="menuItem"></param>
        public ArentinoAppleJuiceEdit(MenuScreen menuItem)
        {
            InitializeComponent();
            menuScreen = menuItem;
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
