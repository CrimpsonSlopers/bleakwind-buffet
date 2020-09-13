using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink, IOrderItem
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        private double price = .62;
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = .62;
                }
                else if (Size == Size.Medium)
                {
                    price = .87;
                }
                else
                {
                    price = 1.01;
                }
                return price;
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        private uint calories = 44;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 44;
                }
                else if (Size == Size.Medium)
                {
                    calories = 88;
                }
                else
                {
                    calories = 132;
                }
                return calories;
            }
        }

        /// <summary>
        /// Gets if the drink has a ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Gets special instructions for the drink
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
            return $"{Size} Aretino Apple Juice";
        }
    }
}
