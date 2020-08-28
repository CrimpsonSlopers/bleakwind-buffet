using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad
    {
        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        private double price = .93;
        public double Price
        {
            get
            {
                return price;
            }
            set
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
            }
        }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        private double calories = 41;
        public double Calories
        {
            get
            {
                return calories;
            }
            set
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
