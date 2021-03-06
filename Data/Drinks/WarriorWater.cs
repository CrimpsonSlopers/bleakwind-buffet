﻿using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink, IOrderItem
    {

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        private double price = 0;
        public override double Price
        {
            get
            {
                return price;
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        private uint calories = 0;
        public override uint Calories
        {
            get
            {
                return calories;
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
        public override List<string> SpecialInstructions
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
