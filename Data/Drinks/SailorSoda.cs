using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink, IOrderItem
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        private double price = 1.42;
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 1.42;
                }
                else if (Size == Size.Medium)
                {
                    price = 1.74;
                }
                else
                {
                    price = 2.07;
                }
                return price;
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        private uint calories = 117;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 117;
                }
                else if (Size == Size.Medium)
                {
                    calories = 153;
                }
                else
                {
                    calories = 205;
                }
                return calories;
            }
        }

        /// <summary>
        /// Gets if the drink has a ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Gets the drink flavor
        /// </summary>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;

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
            return $"{Size} {Flavor} Sailor Soda";
        }
    }
}
