/*Andrew Yi
 * Class:ComboDrink.xaml
 * Purpose: Edit Combination
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
using BleakwindBuffet.Data.Drinks;
using PointOfSale.Drinks;
using BleakwindBuffet.Data.Menu;

namespace PointOfSale.ComboEditor
{
    /// <summary>
    /// Interaction logic for ComboDrink.xaml
    /// </summary>
    public partial class ComboDrink : UserControl
    {

        private MenuScreen menuscreen;

        private Combination comboItem;

        private Order orderItem;

        public ComboDrink(MenuScreen screen, Combination combo, Order order)
        {
            InitializeComponent();
            DataContext = order;
            menuscreen = screen;
            comboItem = combo;
        }


        void ReturnToComboEdit(object sender, RoutedEventArgs e)
        {
            menuscreen.menuBorder.Child = new ComboEdit(menuscreen, comboItem, orderItem);
        }

        //Drink Event Handlers
        void AretinoAppleJuice_Click(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice drinkItem = new AretinoAppleJuice();
       
            if (DataContext is Order item)
            {
                comboItem.Drink = drinkItem;
                ArentinoAppleJuiceEdit replacement = new ArentinoAppleJuiceEdit(menuscreen, drinkItem, item, comboItem);
                menuscreen.menuBorder.Child = replacement;
            }
        }

        void CandlehearthCoffee_Click(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee drinkItem = new CandlehearthCoffee();
      
            if (DataContext is Order item)
            {
                comboItem.Drink = drinkItem;
                CandlehearthCoffeeEdit replacement = new CandlehearthCoffeeEdit(menuscreen, drinkItem, item, comboItem);
                menuscreen.menuBorder.Child = replacement;
            }
        }

        void MarkarthMilk_Click(object sender, RoutedEventArgs e)
        {
            MarkarthMilk drinkItem = new MarkarthMilk();
       
            if (DataContext is Order item)
            {
                comboItem.Drink = drinkItem;
                MarkarthMilkEdit replacement = new MarkarthMilkEdit(menuscreen, drinkItem, item, comboItem);
                menuscreen.menuBorder.Child = replacement;
            }
        }

        void SailorSoda_Click(object sender, RoutedEventArgs e)
        {
            SailorSoda drinkItem = new SailorSoda();
        
            if (DataContext is Order item)
            {
                comboItem.Drink = drinkItem;
                SailorSodaEdit replacement = new SailorSodaEdit(menuscreen, drinkItem, item, comboItem);
                menuscreen.menuBorder.Child = replacement;
            }
        }

        void WarriorWater_Click(object sender, RoutedEventArgs e)
        {
            WarriorWater drinkItem = new WarriorWater();
        
            if (DataContext is Order item)
            {

                comboItem.Drink = drinkItem;
                WarriorWaterEdit replacement = new WarriorWaterEdit(menuscreen, drinkItem, item, comboItem);
                menuscreen.menuBorder.Child = replacement;
            }
        }
    }
}
