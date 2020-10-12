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
        
        private MenuScreen menuscreen;
        /// <summary>
        /// Button initializer
        /// </summary>
        public ButtonSelections(MenuScreen menu)
        {
            InitializeComponent();
            menuscreen = menu;
        }

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

        

        //Entree Button Event Handlers
        void BriarheartBurger_Click(object sender, RoutedEventArgs e)
        {
            BriarheartBurger foodItem = new BriarheartBurger();
            if (DataContext is Order item)
            {
                item.Add(foodItem);
                menuscreen.menuBorder.Child = new BriarheartBurgerEdit(menuscreen, foodItem, item);
            }
                        
        }

        void DoubleDraugr_Click(object sender, RoutedEventArgs e)
        {
            DoubleDraugr foodItem = new DoubleDraugr();
            if (DataContext is Order item)
            {
                item.Add(foodItem);
                menuscreen.menuBorder.Child = new DoubleDraugrEdit(menuscreen, foodItem, item);
            }
        }

        void GardenOrcOmelette_Click(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette foodItem = new GardenOrcOmelette();
            if (DataContext is Order item)
            {
                item.Add(foodItem);
                menuscreen.menuBorder.Child = new GardenOrcOmeletteEdit(menuscreen, foodItem, item);
            }
        }
        
        void PhillyPoacher_Click(object sender, RoutedEventArgs e)
        {
            PhillyPoacher foodItem = new PhillyPoacher();
            if (DataContext is Order item)
            {
                item.Add(foodItem);
                menuscreen.menuBorder.Child = new PhillyPoacherEdit(menuscreen, foodItem, item);
            }
        }

        void SmokehouseSkeleton_Click(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton foodItem = new SmokehouseSkeleton();
            if (DataContext is Order item)
            {
                item.Add(foodItem);
                menuscreen.menuBorder.Child = new SmokehouseSkeletonEdit(menuscreen, foodItem, item);
            }
        }

        void ThalmorTriple_Click(object sender, RoutedEventArgs e)
        {
            ThalmorTriple foodItem = new ThalmorTriple();
            if (DataContext is Order item)
            {
                item.Add(foodItem);
                menuscreen.menuBorder.Child = new ThalmorTripleEdit(menuscreen, foodItem, item);
            }
        }

        void ThugsTBone_Click(object sender, RoutedEventArgs e)
        {
            ThugsTBone foodItem = new ThugsTBone();
            if (DataContext is Order item)
            {
                item.Add(foodItem);
                menuscreen.menuBorder.Child = new ThugsTBoneEdit(menuscreen, foodItem, item);
            }
        }
        //Drink Button Event Handlers
        void AretinoAppleJuice_Click(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice drinkItem = new AretinoAppleJuice();
            if (DataContext is Order item)
            {
                item.Add(drinkItem);
                menuscreen.menuBorder.Child = new ArentinoAppleJuiceEdit(menuscreen, drinkItem, item);
            }
        }

        void CandlehearthCoffee_Click(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee drinkItem = new CandlehearthCoffee();
            if (DataContext is Order item)
            {
                item.Add(drinkItem);
                menuscreen.menuBorder.Child = new CandlehearthCoffeeEdit(menuscreen, drinkItem, item);
            }
        }

        void MarkarthMilk_Click(object sender, RoutedEventArgs e)
        {
            MarkarthMilk drinkItem = new MarkarthMilk();
            if (DataContext is Order item)
            {
                item.Add(drinkItem);
                menuscreen.menuBorder.Child = new MarkarthMilkEdit(menuscreen, drinkItem, item);
            }
        }

        void SailorSoda_Click(object sender, RoutedEventArgs e)
        {
            SailorSoda drinkItem = new SailorSoda();
            if (DataContext is Order item)
            {
                item.Add(drinkItem);
                menuscreen.menuBorder.Child = new SailorSodaEdit(menuscreen, drinkItem, item);
            }
        }

        void WarriorWater_Click(object sender, RoutedEventArgs e)
        {
            WarriorWater drinkItem = new WarriorWater();
            if (DataContext is Order item)
            {
                item.Add(drinkItem);
                menuscreen.menuBorder.Child = new WarriorWaterEdit(menuscreen, drinkItem, item);
            }
        }
        //Side Button Event Handlers
        void DragonbornWaffleFries_Click(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries sideItem = new DragonbornWaffleFries();
            if (DataContext is Order item)
            {
                item.Add(sideItem);
                menuscreen.menuBorder.Child = new DragonbornWaffleFriesEdit(menuscreen, sideItem, item);
            }
        }

        void FriedMiraak_Click(object sender, RoutedEventArgs e)
        {
            FriedMiraak sideItem = new FriedMiraak();
            if (DataContext is Order item)
            {
                item.Add(sideItem);
                menuscreen.menuBorder.Child = new FriedMiraakEdit(menuscreen, sideItem, item);
            }
        }

        void MadOtarGrits_Click(object sender, RoutedEventArgs e)
        {
            MadOtarGrits sideItem = new MadOtarGrits();
            if (DataContext is Order item)
            {
                item.Add(sideItem);
                menuscreen.menuBorder.Child = new MadOtarGritsEdit(menuscreen, sideItem, item);
            }
        }

        void VokunSalad_Click(object sender, RoutedEventArgs e)
        {
            VokunSalad sideItem = new VokunSalad();
            if (DataContext is Order item)
            {
                item.Add(sideItem);
                menuscreen.menuBorder.Child = new VokunSaladEdit(menuscreen, sideItem, item);
            }
        }
    }
}
