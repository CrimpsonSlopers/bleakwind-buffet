using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        private double price = 0;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        private double calories = 0;
        public double Calories
        {
            get
            {
                return calories;
            }
            set
            {
                calories = value;
            }
        }

        /// <summary>
        /// Gets if the drink has a ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Gets if the drink has a lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Gets special instructions for the drink
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");

                return instructions;
            }
        }

        /// <summary>
        /// Provides a description for the drink
        /// </summary>
        /// <returns>A description</returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }
    }
}
