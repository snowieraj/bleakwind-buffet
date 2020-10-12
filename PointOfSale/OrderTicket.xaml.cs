/*Author: Andrew Yi
 *Class: OrderTicket.xaml
 *Purpose: Keep track of what has been ordered
 */

using PointOfSale.Drinks;
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
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using PointOfSale.Entrees;
using PointOfSale.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderTicket.xaml
    /// </summary>
    public partial class OrderTicket : UserControl
    {
        private MenuScreen screen;

        public OrderTicket(MenuScreen menuScreen)
        {
            InitializeComponent();
           
            screen = menuScreen;
        }
      
       
        void DeleteItemFromOrder(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var removalItem = (IOrderItem)currentOrder.SelectedItem;
                order.Remove(removalItem);
            }
        }

        private void EditSelecteditem(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var currentItem = ((Button)sender).DataContext;
                if (currentItem is BriarheartBurger bb) screen.menuBorder.Child = new BriarheartBurgerEdit(screen, bb, order);
                else if (currentItem is DoubleDraugr dd) screen.menuBorder.Child = new DoubleDraugrEdit(screen, dd, order);
                else if (currentItem is GardenOrcOmelette go) screen.menuBorder.Child = new GardenOrcOmeletteEdit(screen, go, order);
                else if (currentItem is PhillyPoacher pp) screen.menuBorder.Child = new PhillyPoacherEdit(screen, pp, order);
                else if (currentItem is SmokehouseSkeleton sh) screen.menuBorder.Child = new SmokehouseSkeletonEdit(screen, sh, order);
                else if (currentItem is ThalmorTriple tt) screen.menuBorder.Child = new ThalmorTripleEdit(screen, tt, order);
                else if (currentItem is ThugsTBone ttb) screen.menuBorder.Child = new ThugsTBoneEdit(screen, ttb, order);
                else if (currentItem is AretinoAppleJuice aa) screen.menuBorder.Child = new ArentinoAppleJuiceEdit(screen, aa, order);
                else if (currentItem is CandlehearthCoffee ch) screen.menuBorder.Child = new CandlehearthCoffeeEdit(screen, ch, order);
                else if (currentItem is MarkarthMilk mm) screen.menuBorder.Child = new MarkarthMilkEdit(screen, mm, order);
                else if (currentItem is SailorSoda ss) screen.menuBorder.Child = new SailorSodaEdit(screen, ss, order);
                else if (currentItem is WarriorWater ww) screen.menuBorder.Child = new WarriorWaterEdit(screen, ww, order);
                else if (currentItem is DragonbornWaffleFries db) screen.menuBorder.Child = new DragonbornWaffleFriesEdit(screen, db, order);
                else if (currentItem is FriedMiraak fm) screen.menuBorder.Child = new FriedMiraakEdit(screen, fm, order);
                else if (currentItem is MadOtarGrits mo) screen.menuBorder.Child = new MadOtarGritsEdit(screen, mo, order);
                else if (currentItem is VokunSalad vs) screen.menuBorder.Child = new VokunSaladEdit(screen, vs, order);

            }
        }
       
    }
    
}
