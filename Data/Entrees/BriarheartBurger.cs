using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger : Entree, IOrderItem
    {

        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 6.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 732;

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

                return instructions;
            }
        }

        /// <summary>
        /// Provides a description for the burger
        /// </summary>
        /// <returns>A description</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
