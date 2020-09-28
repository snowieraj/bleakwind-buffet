/*Author: Andrew Yi
 *Class: ButtonSelection.xaml.cs
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ButtonSelections.xaml
    /// </summary>
    public partial class ButtonSelections : UserControl
    {
        /// <summary>
        /// Event handler when selected item
        /// </summary>
        public event EventHandler<SelectionEventHandler> SelectedItem;
        /// <summary>
        /// Button initializer
        /// </summary>
        public ButtonSelections()
        {
            InitializeComponent();
        }
        //Entree Button Event Handlers
        void BriarheartBurger_Click(object sender, RoutedEventArgs e)
        {
            BriarheartBurger foodItem = new BriarheartBurger();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = foodItem });
            
            
        }

        void DoubleDraugr_Click(object sender, RoutedEventArgs e)
        {
            DoubleDraugr foodItem = new DoubleDraugr();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = foodItem });
        }

        void GardenOrcOmelette_Click(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette foodItem = new GardenOrcOmelette();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = foodItem });
        }
        
        void PhillyPoacher_Click(object sender, RoutedEventArgs e)
        {
            PhillyPoacher foodItem = new PhillyPoacher();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = foodItem });
        }

        void SmokehouseSkeleton_Click(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton foodItem = new SmokehouseSkeleton();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = foodItem });
        }

        void ThalmorTriple_Click(object sender, RoutedEventArgs e)
        {
            ThalmorTriple foodItem = new ThalmorTriple();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = foodItem });
        }

        void ThugsTBone_Click(object sender, RoutedEventArgs e)
        {
            ThugsTBone foodItem = new ThugsTBone();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = foodItem });
        }
        //Drink Button Event Handlers
        void AretinoAppleJuice_Click(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice drinkItem = new AretinoAppleJuice();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = drinkItem });
        }

        void CandlehearthCoffee_Click(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee drinkItem = new CandlehearthCoffee();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = drinkItem });
        }

        void MarkarthMilk_Click(object sender, RoutedEventArgs e)
        {
            MarkarthMilk drinkItem = new MarkarthMilk();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = drinkItem });
        }

        void SailorSoda_Click(object sender, RoutedEventArgs e)
        {
            SailorSoda drinkItem = new SailorSoda();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = drinkItem });
        }

        void WarriorWater_Click(object sender, RoutedEventArgs e)
        {
            WarriorWater drinkItem = new WarriorWater();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = drinkItem });
        }
        //Side Button Event Handlers
        void DragonbornWaffleFries_Click(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries sideItem = new DragonbornWaffleFries();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = sideItem });
        }

        void FriedMiraak_Click(object sender, RoutedEventArgs e)
        {
            FriedMiraak sideItem = new FriedMiraak();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = sideItem });
        }

        void MadOtarGrits_Click(object sender, RoutedEventArgs e)
        {
            MadOtarGrits sideItem = new MadOtarGrits();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = sideItem });
        }

        void VokunSalad_Click(object sender, RoutedEventArgs e)
        {
            VokunSalad sideItem = new VokunSalad();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = sideItem });
        }
    }
}
