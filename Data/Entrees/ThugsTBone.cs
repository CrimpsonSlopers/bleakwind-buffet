using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the tbone
        /// </summary>
        public override double Price => 6.44;

        /// <summary>
        /// Gets the calories of the tbone
        /// </summary>
        public override uint Calories => 982;

        /// <summary>
        /// Gets special instructions for the tbone
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                return instructions;
            }
        }

        /// <summary>
        /// Provides a description for the tbone
        /// </summary>
        /// <returns>A description</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
