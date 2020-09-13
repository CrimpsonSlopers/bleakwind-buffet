using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the omelette
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// Gets the calories of the omelette
        /// </summary>
        public override uint Calories => 404;

        /// <summary>
        /// Gets if the omelette has a broccoli
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// Gets if the omelette has a mushrooms
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// Gets if the omelette has a tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Gets if the omelette has a cheese
        /// </summary>
        public bool Cheddar { get; set; } = true;

        /// <summary>
        /// Gets special instructions for the omelette
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");

                return instructions;
            }
        }

        /// <summary>
        /// Provides a description for the omelette
        /// </summary>
        /// <returns>A description</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
