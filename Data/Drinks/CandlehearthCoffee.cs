﻿using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink, IOrderItem
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        private double price = .75;
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = .75;
                }
                else if (Size == Size.Medium)
                {
                    price = 1.25;
                }
                else
                {
                    price = 1.75;
                }
                return price;
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        private uint calories = 7;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 7;
                }
                else if (Size == Size.Medium)
                {
                    calories = 10;
                }
                else
                {
                    calories = 20;
                }
                return calories;
            }
        }

        /// <summary>
        /// Gets if the drink has a ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Gets if the drink has a cream
        /// </summary>
        public bool RoomForCream { get; set; } = true;

        /// <summary>
        /// Gets if the drink has a decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

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
                if (RoomForCream) instructions.Add("Add cream");

                return instructions;
            }
        }

        /// <summary>
        /// Provides a description for the drink
        /// </summary>
        /// <returns>A description</returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return $"{Size} Decaf Candlehearth Coffee";
            }
            return $"{Size} Candlehearth Coffee";

        }
    }
}
