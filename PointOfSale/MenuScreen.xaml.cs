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
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuScreen.xaml
    /// </summary>
    public partial class MenuScreen : UserControl
    {
        private ButtonSelections buttonSelections;
        private OrderTicket orderTicket;
        /// <summary>
        /// Constructs a new MenuScreen
        /// </summary>
        /// <param name="customizeItem">Item Page</param>
        public MenuScreen()
        {
            InitializeComponent();
                     
            buttonSelections = new ButtonSelections(this);
            menuBorder.Child = buttonSelections;

            orderTicket = new OrderTicket(this);
            tickerBorder.Child = orderTicket;

        }

        
        /// <summary>
        /// new item clicked bring up menu
        /// </summary>
        /// <param name="sender">click</param>
        /// <param name="e">event</param>
        void NewOrder_Click(object sender, SelectionEventHandler e)
        {
            if (DataContext is Order order)
            {
                //Entrees
                if (e.item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Entrees.Entree)))
                {
                    if (e.item is BriarheartBurger) menuBorder.Child = new BriarheartBurgerEdit(this, new BriarheartBurger(), order);
                    else if (e.item is DoubleDraugr) menuBorder.Child = new DoubleDraugrEdit(this, new DoubleDraugr(), order);
                    else if (e.item is GardenOrcOmelette) menuBorder.Child = new GardenOrcOmeletteEdit(this, new GardenOrcOmelette(), order);
                    else if (e.item is PhillyPoacher) menuBorder.Child = new PhillyPoacherEdit(this, new PhillyPoacher(), order);
                    else if (e.item is SmokehouseSkeleton) menuBorder.Child = new SmokehouseSkeletonEdit(this, new SmokehouseSkeleton(), order);
                    else if (e.item is ThalmorTriple) menuBorder.Child = new ThalmorTripleEdit(this, new ThalmorTriple(), order);
                    else if (e.item is ThugsTBone) menuBorder.Child = new ThugsTBoneEdit(this, new ThugsTBone(), order);



                }
                //Drinks
                if (e.item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Drinks.Drink)))
                {
                    if (e.item is AretinoAppleJuice) menuBorder.Child = new ArentinoAppleJuiceEdit(this, new AretinoAppleJuice(), order);
                    else if (e.item is CandlehearthCoffee) menuBorder.Child = new CandlehearthCoffeeEdit(this, new CandlehearthCoffee(), order);
                    else if (e.item is MarkarthMilk) menuBorder.Child = new MarkarthMilkEdit(this, new MarkarthMilk(), order);
                    else if (e.item is SailorSoda) menuBorder.Child = new SailorSodaEdit(this, new SailorSoda(), order);
                    else if (e.item is WarriorWater) menuBorder.Child = new WarriorWaterEdit(this, new WarriorWater(), order);
                }

                //Sides
                if (e.item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Sides.Side)))
                {
                    if (e.item is DragonbornWaffleFries) menuBorder.Child = new DragonbornWaffleFriesEdit(this, new DragonbornWaffleFries(), order);
                    else if (e.item is FriedMiraak) menuBorder.Child = new FriedMiraakEdit(this, new FriedMiraak(), order);
                    else if (e.item is MadOtarGrits) menuBorder.Child = new MadOtarGritsEdit(this, new MadOtarGrits(), order);
                    else if (e.item is VokunSalad) menuBorder.Child = new VokunSaladEdit(this, new VokunSalad(), order);
                }
            }

        }

        

        
            

   
      
       
     
    }

}
