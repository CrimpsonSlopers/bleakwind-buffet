using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk : Drink, IOrderItem
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        private double price = 1.05;
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 1.05;
                }
                else if (Size == Size.Medium)
                {
                    price = 1.11;
                }
                else
                {
                    price = 1.22;
                }
                return price;
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public uint calories = 56;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 56;
                }
                else if (Size == Size.Medium)
                {
                    calories = 72;
                }
                else
                {
                    calories = 93;
                }
                return calories;
            }
        }

        /// <summary>
        /// Gets if the drink has a ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Gets special instructions for the burger
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (Ice) instructions.Add("Add ice");

                return instructions;
            }
        }

        /// <summary>
        /// Provides a description for the drink
        /// </summary>
        /// <returns>A description</returns>
        public override string ToString()
        {
            return $"{Size} Markarth Milk";
        }
    }
}
