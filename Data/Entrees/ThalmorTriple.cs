using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 8.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 943;

        /// <summary>
        /// Gets if the burger has a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Gets if the burger has a ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Gets if the burger has a mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Gets if the burger has a pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Gets if the burger has a cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Gets if the burger has a tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Gets if the burger has a lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Gets if the burger has a mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Gets if the burger has a bacon
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// Gets if the burger has a egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Gets special instructions for the burger
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");

                return instructions;
            }
        }

        /// <summary>
        /// Provides a description for the burger
        /// </summary>
        /// <returns>A description</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
