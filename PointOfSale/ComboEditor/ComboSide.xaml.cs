/*Andrew Yi
 * Class:ComboSide.xaml
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
using BleakwindBuffet.Data.Sides;
using PointOfSale.Sides;


namespace PointOfSale.ComboEditor
{
    /// <summary>
    /// Interaction logic for ComboSide.xaml
    /// </summary>
    public partial class ComboSide : UserControl
    {

        /// <summary>
        /// Menu contructor/ref
        /// </summary>
        private MenuScreen menuscreen;

        //ordered ticket
        private Order orderItem;

        private Combination comboItem;

        public ComboSide(MenuScreen screen, Combination combo, Order order)
        {
            InitializeComponent();
            menuscreen = screen;
            comboItem = combo;
            orderItem = order;
        }

        void ReturnToComboEdit(object sender, RoutedEventArgs e)
        {
            menuscreen.menuBorder.Child = new ComboEdit(menuscreen, comboItem, orderItem);
        }

        //Side Button Event Handlers
        void DragonbornWaffleFries_Click(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries sideItem = new DragonbornWaffleFries();
            
            if (DataContext is Order item)
            {

                comboItem.Side = sideItem;
                DragonbornWaffleFriesEdit replacement = new DragonbornWaffleFriesEdit(menuscreen, sideItem, item, comboItem);
                menuscreen.menuBorder.Child = replacement;
            }
        }

        void FriedMiraak_Click(object sender, RoutedEventArgs e)
        {
            FriedMiraak sideItem = new FriedMiraak();
            
            if (DataContext is Order item)
            {

                comboItem.Side = sideItem;
                FriedMiraakEdit replacement = new FriedMiraakEdit(menuscreen, sideItem, item, comboItem);
                menuscreen.menuBorder.Child = replacement;
            }
        }

        void MadOtarGrits_Click(object sender, RoutedEventArgs e)
        {
            MadOtarGrits sideItem = new MadOtarGrits();
            
            if (DataContext is Order item)
            {

                comboItem.Side = sideItem;
                MadOtarGritsEdit replacement = new MadOtarGritsEdit(menuscreen, sideItem, item, comboItem);
                menuscreen.menuBorder.Child = replacement;
            }
        }

        void VokunSalad_Click(object sender, RoutedEventArgs e)
        {
            VokunSalad sideItem = new VokunSalad();
            
            if (DataContext is Order item)
            {

                comboItem.Side = sideItem;
                VokunSaladEdit replacement = new VokunSaladEdit(menuscreen, sideItem, item, comboItem);
                menuscreen.menuBorder.Child = replacement;
            }
        }

    }
}
