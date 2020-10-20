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
using RoundRegister;
using PointOfSale.ComboEditor;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderTicket.xaml
    /// </summary>
    public partial class OrderTicket : UserControl
    {
        /// <summary>
        /// Screen changing
        /// </summary>
        private MenuScreen screen;
        /// <summary>
        /// Ticket Order construct
        /// </summary>
        /// <param name="menuScreen"></param>
        public OrderTicket(MenuScreen menuScreen)
        {
            InitializeComponent();
           
            screen = menuScreen;
            
        }
        /// <summary>
        /// New order ticket created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void NewOrder_Click(object sender, RoutedEventArgs e)
        {
            DependencyObject parent = this;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            }
            while (parent != null && !(parent is MainWindow));
            ((MainWindow)parent).DataContext = new Order();
            screen.menuBorder.Child = new ButtonSelections(screen);
        }
        /// <summary>
        /// Finalize order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            
                screen.menuBorder.Child = new PaymentOptions(screen, this);
            
        }

     

        /// <summary>
        /// Delete an item from the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DeleteItemFromOrder(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var removalItem = (IOrderItem)currentOrder.SelectedItem;
                if (!(order.Remove(removalItem)))
                {
                    MessageBox.Show("Select the item to remove");
                }            
                
            }
            
        }
        /// <summary>
        /// Edit the item selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EditSelecteditem(object sender, RoutedEventArgs e)
        {
            ButtonSelections buttonSelections = new ButtonSelections(screen);

            Combination combo = new Combination(null, null, null);
            
            if (DataContext is Order order)
            {
                var currentItem = ((Button)sender).DataContext;
                if (currentItem is BriarheartBurger bb) screen.menuBorder.Child = new BriarheartBurgerEdit(screen, bb, order, combo);
                else if (currentItem is DoubleDraugr dd) screen.menuBorder.Child = new DoubleDraugrEdit(screen, dd, order, combo);
                else if (currentItem is GardenOrcOmelette go) screen.menuBorder.Child = new GardenOrcOmeletteEdit(screen, go, order, combo);
                else if (currentItem is PhillyPoacher pp) screen.menuBorder.Child = new PhillyPoacherEdit(screen, pp, order, combo);
                else if (currentItem is SmokehouseSkeleton sh) screen.menuBorder.Child = new SmokehouseSkeletonEdit(screen, sh, order, combo);
                else if (currentItem is ThalmorTriple tt) screen.menuBorder.Child = new ThalmorTripleEdit(screen, tt, order, combo);
                else if (currentItem is ThugsTBone ttb) screen.menuBorder.Child = new ThugsTBoneEdit(screen, ttb, order, combo);
                else if (currentItem is AretinoAppleJuice aa) screen.menuBorder.Child = new ArentinoAppleJuiceEdit(screen, aa, order, combo);
                else if (currentItem is CandlehearthCoffee ch) screen.menuBorder.Child = new CandlehearthCoffeeEdit(screen, ch, order, combo);
                else if (currentItem is MarkarthMilk mm) screen.menuBorder.Child = new MarkarthMilkEdit(screen, mm, order, combo);
                else if (currentItem is SailorSoda ss) screen.menuBorder.Child = new SailorSodaEdit(screen, ss, order, combo);
                else if (currentItem is WarriorWater ww) screen.menuBorder.Child = new WarriorWaterEdit(screen, ww, order, combo);
                else if (currentItem is DragonbornWaffleFries db) screen.menuBorder.Child = new DragonbornWaffleFriesEdit(screen, db, order, combo);
                else if (currentItem is FriedMiraak fm) screen.menuBorder.Child = new FriedMiraakEdit(screen, fm, order, combo);
                else if (currentItem is MadOtarGrits mo) screen.menuBorder.Child = new MadOtarGritsEdit(screen, mo, order, combo);
                else if (currentItem is VokunSalad vs) screen.menuBorder.Child = new VokunSaladEdit(screen, vs, order, combo);
                else if (currentItem is Combination comboItem) screen.menuBorder.Child = new ComboEdit(screen, comboItem, order);
                
            }
            
            
        }
       
      
    }
    
}
