/*Author: Andrew Yi
 *Class: MenuScreen.xaml.cs
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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using PointOfSale.Entrees;
using PointOfSale.Drinks;
using PointOfSale.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuScreen.xaml
    /// </summary>
    public partial class MenuScreen : UserControl
    {
        /// <summary>
        /// Buttons Selected
        /// </summary>
        public ButtonSelections buttonSelections = new ButtonSelections();
     

        /// <summary>
        /// Constructs a new MenuScreen
        /// </summary>
        /// <param name="customizeItem">Item Page</param>
        public MenuScreen()
        {
            InitializeComponent();
           
            buttonSelections.SelectedItem += NewOrder_Click;
            menuBorder.Child = buttonSelections;
        }

        
        /// <summary>
        /// new item clicked bring up menu
        /// </summary>
        /// <param name="sender">click</param>
        /// <param name="e">event</param>
        void NewOrder_Click(object sender, SelectionEventHandler e)
        {
            //Entrees
            if (e.item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Entrees.Entree)))
            {
                if (e.item is BriarheartBurger) menuBorder.Child = new BriarheartBurgerEdit(this);
                else if (e.item is DoubleDraugr) menuBorder.Child = new DoubleDraugrEdit(this);
                else if (e.item is GardenOrcOmelette) menuBorder.Child = new GardenOrcOmeletteEdit(this);
                else if (e.item is PhillyPoacher) menuBorder.Child = new PhillyPoacherEdit(this);
                else if (e.item is SmokehouseSkeleton) menuBorder.Child = new SmokehouseSkeletonEdit(this);
                else if (e.item is ThalmorTriple) menuBorder.Child = new ThalmorTripleEdit(this);
                else if (e.item is ThugsTBone) menuBorder.Child = new ThugsTBoneEdit(this);

               
                
            }
            //Drinks
            if (e.item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Drinks.Drink)))
            {
                if (e.item is AretinoAppleJuice) menuBorder.Child = new ArentinoAppleJuiceEdit(this);
                else if (e.item is CandlehearthCoffee) menuBorder.Child = new CandlehearthCoffeeEdit(this);
                else if (e.item is MarkarthMilk) menuBorder.Child = new MarkarthMilkEdit(this);
                else if (e.item is SailorSoda) menuBorder.Child = new SailorSodaEdit(this);
                else if (e.item is WarriorWater) menuBorder.Child = new WarriorWaterEdit(this);
            }
            
            //Sides
            if (e.item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Sides.Side)))
            {
                if (e.item is DragonbornWaffleFries) menuBorder.Child = new DragonbornWaffleFriesEdit(this);
                else if (e.item is FriedMiraak) menuBorder.Child = new FriedMiraakEdit(this);
                else if (e.item is MadOtarGrits) menuBorder.Child = new MadOtarGritsEdit(this);
                else if (e.item is VokunSalad) menuBorder.Child = new VokunSaladEdit(this);
            }

        }

        

        
            

   
      
       
     
    }

}
