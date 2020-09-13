using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits : Side, IOrderItem
    {
        /// <summary>
        /// Gets the price of the side
        /// </summary>
        private double price = 1.22;
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 1.22;
                }
                else if (Size == Size.Medium)
                {
                    price = 1.58;
                }
                else
                {
                    price = 1.93;
                }
                return price;
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                return instructions;
            }
        }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        private uint calories = 105;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 105;
                }
                else if (Size == Size.Medium)
                {
                    calories = 142;
                }
                else
                {
                    calories = 179;
                }
                return calories;
            }
        }

        /// <summary>
        /// Provides a description for the drink
        /// </summary>
        /// <returns>A description</returns>
        public override string ToString()
        {
            return $"{Size} Mad Otar Grits";
        }
    }
}
