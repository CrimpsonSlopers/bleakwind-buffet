using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries : Side, IOrderItem
    {
        /// <summary>
        /// Gets the price of the fries
        /// </summary>
        private double price = .42;
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = .42;
                }
                else if (Size == Size.Medium)
                {
                    price = .76;
                }
                else
                {
                    price = .96;
                }
                return price;
            }
        }

        /// <summary>
        /// Gets the calories of the fries
        /// </summary>
        private uint calories = 77;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 77;
                }
                else if (Size == Size.Medium)
                {
                    calories = 89;
                }
                else
                {
                    calories = 100;
                }
                return calories;
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
        /// Provides a description for the fries
        /// </summary>
        /// <returns>A description</returns>
        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
