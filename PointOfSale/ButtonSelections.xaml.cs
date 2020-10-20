/*Author: Andrew Yi
 *Class: ButtonSelection.xaml.cs
 *Purpose: Control the buttons of this item
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data.Sides;
using PointOfSale.ComboEditor;
using PointOfSale.Drinks;
using PointOfSale.Entrees;
using PointOfSale.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ButtonSelections.xaml
    /// </summary>
    public partial class ButtonSelections : UserControl
    {
        //Screen changing
        private MenuScreen menuscreen;
        /// <summary>
        /// Button initializer
        /// </summary>
        public ButtonSelections(MenuScreen menu)
        {
            InitializeComponent();
            menuscreen = menu;
           
        }
        /// <summary>
        /// New order created
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
            
        }
        /// <summary>
        /// Create a combo item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Combo_Click(object sender, RoutedEventArgs e)
        {
 
            Combination combo = new Combination(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            if (DataContext is Order item)
            {
                item.Add(combo);
                menuscreen.menuBorder.Child = new ComboEdit(menuscreen, combo, item);

            }
            
        }
       
        //Entree Button Event Handlers
        void BriarheartBurger_Click(object sender, RoutedEventArgs e)
        {
            BriarheartBurger foodItem = new BriarheartBurger();
            Combination combo = new Combination(null, null, null);
            if (DataContext is Order item ) 
            {
                item.Add(foodItem);
                menuscreen.menuBorder.Child = new BriarheartBurgerEdit(menuscreen, foodItem, item, combo);
            }
                        
        }

        void DoubleDraugr_Click(object sender, RoutedEventArgs e)
        {
            DoubleDraugr foodItem = new DoubleDraugr();
            Combination combo = new Combination(null, null, null);
            if (DataContext is Order item)
            {
                item.Add(foodItem);
                menuscreen.menuBorder.Child = new DoubleDraugrEdit(menuscreen, foodItem, item, combo);
            }
        }

        void GardenOrcOmelette_Click(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette foodItem = new GardenOrcOmelette();
            Combination combo = new Combination(null, null, null);
            if (DataContext is Order item)
            {
                item.Add(foodItem);
                menuscreen.menuBorder.Child = new GardenOrcOmeletteEdit(menuscreen, foodItem, item, combo);
            }
        }
        
        void PhillyPoacher_Click(object sender, RoutedEventArgs e)
        {
            PhillyPoacher foodItem = new PhillyPoacher();
            Combination combo = new Combination(null, null, null);
            if (DataContext is Order item )
            {
                item.Add(foodItem);
                menuscreen.menuBorder.Child = new PhillyPoacherEdit(menuscreen, foodItem, item, combo);
            }
        }

        void SmokehouseSkeleton_Click(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton foodItem = new SmokehouseSkeleton();
            Combination combo = new Combination(null, null, null);
            if (DataContext is Order item)
            {
                item.Add(foodItem);
                menuscreen.menuBorder.Child = new SmokehouseSkeletonEdit(menuscreen, foodItem, item, combo);
            }
        }

        void ThalmorTriple_Click(object sender, RoutedEventArgs e)
        {
            ThalmorTriple foodItem = new ThalmorTriple();
            Combination combo = new Combination(null, null, null);
            if (DataContext is Order item)
            {
                item.Add(foodItem);
                menuscreen.menuBorder.Child = new ThalmorTripleEdit(menuscreen, foodItem, item, combo);
            }
        }

        void ThugsTBone_Click(object sender, RoutedEventArgs e)
        {
            ThugsTBone foodItem = new ThugsTBone();
            Combination combo = new Combination(null, null, null);
            if (DataContext is Order item)
            {
                item.Add(foodItem);
                menuscreen.menuBorder.Child = new ThugsTBoneEdit(menuscreen, foodItem, item, combo);
            }
        }
        //Drink Button Event Handlers
        void AretinoAppleJuice_Click(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice drinkItem = new AretinoAppleJuice();
            Combination combo = new Combination(null, null, null);
            if (DataContext is Order item)
            {
                item.Add(drinkItem);
                menuscreen.menuBorder.Child = new ArentinoAppleJuiceEdit(menuscreen, drinkItem, item, combo);
            }
        }

        void CandlehearthCoffee_Click(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee drinkItem = new CandlehearthCoffee();
            Combination combo = new Combination(null, null, null);
            if (DataContext is Order item)
            {
                item.Add(drinkItem);
                menuscreen.menuBorder.Child = new CandlehearthCoffeeEdit(menuscreen, drinkItem, item, combo);
            }
        }

        void MarkarthMilk_Click(object sender, RoutedEventArgs e)
        {
            MarkarthMilk drinkItem = new MarkarthMilk();
            Combination combo = new Combination(null, null, null);
            if (DataContext is Order item)
            {
                item.Add(drinkItem);
                menuscreen.menuBorder.Child = new MarkarthMilkEdit(menuscreen, drinkItem, item, combo);
            }
        }

        void SailorSoda_Click(object sender, RoutedEventArgs e)
        {
            SailorSoda drinkItem = new SailorSoda();
            Combination combo = new Combination(null, null, null);
            if (DataContext is Order item)
            {
                item.Add(drinkItem);
                menuscreen.menuBorder.Child = new SailorSodaEdit(menuscreen, drinkItem, item, combo);
            }
        }

        void WarriorWater_Click(object sender, RoutedEventArgs e)
        {
            WarriorWater drinkItem = new WarriorWater();
            Combination combo = new Combination(null, null, null);
            if (DataContext is Order item)
            {
                item.Add(drinkItem);
                menuscreen.menuBorder.Child = new WarriorWaterEdit(menuscreen, drinkItem, item, combo);
            }
        }
        //Side Button Event Handlers
        void DragonbornWaffleFries_Click(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries sideItem = new DragonbornWaffleFries();
            Combination combo = new Combination(null, null, null);
            if (DataContext is Order item)
            {
                item.Add(sideItem);
                menuscreen.menuBorder.Child = new DragonbornWaffleFriesEdit(menuscreen, sideItem, item, combo);
            }
        }

        void FriedMiraak_Click(object sender, RoutedEventArgs e)
        {
            FriedMiraak sideItem = new FriedMiraak();
            Combination combo = new Combination(null, null, null);
            if (DataContext is Order item)
            {
                item.Add(sideItem);
                menuscreen.menuBorder.Child = new FriedMiraakEdit(menuscreen, sideItem, item, combo);
            }
        }

        void MadOtarGrits_Click(object sender, RoutedEventArgs e)
        {
            MadOtarGrits sideItem = new MadOtarGrits();
            Combination combo = new Combination(null, null, null);
            if (DataContext is Order item)
            {
                item.Add(sideItem);
                menuscreen.menuBorder.Child = new MadOtarGritsEdit(menuscreen, sideItem, item, combo);
            }
        }

        void VokunSalad_Click(object sender, RoutedEventArgs e)
        {
            VokunSalad sideItem = new VokunSalad();
            Combination combo = new Combination(null, null, null);
            if (DataContext is Order item)
            {
                item.Add(sideItem);
                menuscreen.menuBorder.Child = new VokunSaladEdit(menuscreen, sideItem, item, combo);
            }
        }
    }
}
