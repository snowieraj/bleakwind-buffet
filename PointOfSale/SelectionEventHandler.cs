/*Author: Andrew Yi
 * Class: SelectionEventHandler.cs
 * Purpose: Allow items from Data solution to be used in wpf
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Chooses items in Data
    /// </summary>
    public class SelectionEventHandler : EventArgs
    {
        //Menu items 
        public IOrderItem item;
    }
}
