using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// Gets the size of the fries
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the fries
        /// </summary>
        private double price = .42;
        public double Price
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
            set
            { 
            }
        }

        /// <summary>
        /// Gets the calories of the fries
        /// </summary>
        private double calories = 77;
        public double Calories
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
            set
            {
                
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
