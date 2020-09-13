using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad : Side, IOrderItem
    {
        /// <summary>
        /// Gets the price of the side
        /// </summary>
        private double price = .93;
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = .93;
                }
                else if (Size == Size.Medium)
                {
                    price = 1.28;
                }
                else
                {
                    price = 1.82;
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
        private uint calories = 41;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 41;
                }
                else if (Size == Size.Medium)
                {
                    calories = 52;
                }
                else
                {
                    calories = 73;
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
            return $"{Size} Vokun Salad";
        }
    }
}
