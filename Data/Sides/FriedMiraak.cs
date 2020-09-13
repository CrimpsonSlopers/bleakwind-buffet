using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak : Side, IOrderItem
    {
        /// <summary>
        /// Gets the price of the side
        /// </summary>
        private double price = 1.78;
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 1.78;
                }
                else if (Size == Size.Medium)
                {
                    price = 2.01;
                }
                else
                {
                    price = 2.88;
                }
                return price;
            }
        }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        private uint calories = 151;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 151;
                }
                else if (Size == Size.Medium)
                {
                    calories = 236;
                }
                else
                {
                    calories = 306;
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
        /// Provides a description for the drink
        /// </summary>
        /// <returns>A description</returns>
        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }
    }
}
