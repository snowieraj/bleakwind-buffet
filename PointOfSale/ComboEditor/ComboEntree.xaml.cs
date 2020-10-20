/*Andrew Yi
 * Class:ComboEntree.xaml
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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Menu;
using PointOfSale.Entrees;

namespace PointOfSale.ComboEditor
{
    /// <summary>
    /// Interaction logic for ComboEntree.xaml
    /// </summary>
    public partial class ComboEntree : UserControl
    {
        private MenuScreen menuscreen;

        private Combination comboItem;

        private Order orderItem;

        public ComboEntree(MenuScreen screen, Combination combo, Order order)
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

        //Entree Button Event Handlers
        void BriarheartBurger_Click(object sender, RoutedEventArgs e)
        {
            
            
            if (DataContext is Order item)
            {
                BriarheartBurger foodItem = new BriarheartBurger();
                comboItem.Entree = foodItem;
                BriarheartBurgerEdit replacement = new BriarheartBurgerEdit(menuscreen, foodItem, item, comboItem);
                menuscreen.menuBorder.Child = replacement;
            }

        }

        void DoubleDraugr_Click(object sender, RoutedEventArgs e)
        {
            

            if (DataContext is Order item)
            {
                DoubleDraugr foodItem = new DoubleDraugr();
                comboItem.Entree = foodItem;
                DoubleDraugrEdit replacement = new DoubleDraugrEdit(menuscreen, foodItem, item, comboItem);
                menuscreen.menuBorder.Child = replacement;
            }
        }

        void GardenOrcOmelette_Click(object sender, RoutedEventArgs e)
        {
            
            
            if (DataContext is Order item)
            {
                GardenOrcOmelette foodItem = new GardenOrcOmelette();
                comboItem.Entree = foodItem;
                GardenOrcOmeletteEdit replacement = new GardenOrcOmeletteEdit(menuscreen, foodItem, item, comboItem);
                menuscreen.menuBorder.Child = replacement;
            }
        }

        void PhillyPoacher_Click(object sender, RoutedEventArgs e)
        {
            
            
            if (DataContext is Order item)
            {
                PhillyPoacher foodItem = new PhillyPoacher();
                comboItem.Entree = foodItem;
                PhillyPoacherEdit replacement = new PhillyPoacherEdit(menuscreen, foodItem, item, comboItem);
                menuscreen.menuBorder.Child = replacement;
            }
        }

        void SmokehouseSkeleton_Click(object sender, RoutedEventArgs e)
        {
           

            if (DataContext is Order item)
            {
                SmokehouseSkeleton foodItem = new SmokehouseSkeleton();
                comboItem.Entree = foodItem;
                SmokehouseSkeletonEdit replacement = new SmokehouseSkeletonEdit(menuscreen, foodItem, item, comboItem);
                menuscreen.menuBorder.Child = replacement;
            }
        }

        void ThalmorTriple_Click(object sender, RoutedEventArgs e)
        {
            
     
            if (DataContext is Order item)
            {
                ThalmorTriple foodItem = new ThalmorTriple();
                comboItem.Entree = foodItem;
                ThalmorTripleEdit replacement = new ThalmorTripleEdit(menuscreen, foodItem, item, comboItem);
                menuscreen.menuBorder.Child = replacement;
            }
        }

        void ThugsTBone_Click(object sender, RoutedEventArgs e)
        {
       
            if (DataContext is Order item)
            {                
                ThugsTBone foodItem = new ThugsTBone();
                comboItem.Entree = foodItem;
                ThugsTBoneEdit replacement = new ThugsTBoneEdit(menuscreen, foodItem, item, comboItem);
                menuscreen.menuBorder.Child = replacement;
            }
        }
    }
}
