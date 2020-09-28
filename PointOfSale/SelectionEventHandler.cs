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
    public class SelectionEventHandler : EventArgs
    {
        public IOrderItem item;
    }
}
