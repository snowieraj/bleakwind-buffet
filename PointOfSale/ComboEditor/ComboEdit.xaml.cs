/*Andrew Yi
 * Class:ComboEdit.xaml
 * Purpose: Edit Combination
 */
using BleakwindBuffet.Data.Menu;
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

namespace PointOfSale.ComboEditor
{
    /// <summary>
    /// Interaction logic for ComboEdit.xaml
    /// </summary>
    public partial class ComboEdit : UserControl
    {
        /// <summary>
        /// Menu contructor/ref
        /// </summary>
        private MenuScreen menuScreen;

        //ordered ticket
        private Order orderItem;

        private Combination comboItem;

        public ComboEdit(MenuScreen screen, Combination combo, Order order)
        {
            InitializeComponent();
            menuScreen = screen;
            comboItem = combo;
            orderItem = order;
        }

        void ChangeEntree_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                menuScreen.menuBorder.Child = new ComboEntree(menuScreen, comboItem, order);
            }
        }

        void ChangeSide_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                menuScreen.menuBorder.Child = new ComboSide(menuScreen, comboItem, order);
            }
        }

        void ChangeDrink_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                menuScreen.menuBorder.Child = new ComboDrink(menuScreen, comboItem, order);
            }
        }

        void ConfirmOrder_Click(object sender, RoutedEventArgs e)
        {
            menuScreen.menuBorder.Child = new ButtonSelections(menuScreen);
        }

        void Cancel_Click(object sender, RoutedEventArgs e)
        {
            menuScreen.menuBorder.Child = new ButtonSelections(menuScreen);

            DataContext = orderItem;
            if (DataContext is Order ordered)
            {
                var itemRemoved = comboItem;
                ordered.Remove(itemRemoved);
            }
        }
    }
}
