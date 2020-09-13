using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Menu
{
    public interface IOrderItem
    {
        public double Price { get;}


        public uint Calories { get; }


        public List<string> SpecialInstructions { get; }
    }
}
