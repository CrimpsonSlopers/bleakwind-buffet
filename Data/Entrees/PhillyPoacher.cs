using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// Gets the price of the philly
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// Gets the calories of the philly
        /// </summary>
        public uint Calories => 784;

        /// <summary>
        /// Gets if the philly has a sirloin
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// Gets if the philly has a onion
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// Gets if the philly has a roll
        /// </summary>
        public bool Roll { get; set; } = true;

        /// <summary>
        /// Gets special instructions for the philly
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");

                return instructions;
            }
        }

        /// <summary>
        /// Provides a description for the philly
        /// </summary>
        /// <returns>A description</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
