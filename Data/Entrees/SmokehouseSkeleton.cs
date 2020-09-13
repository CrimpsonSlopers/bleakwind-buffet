using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the smokehouse
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// Gets the calories of the smokehouse
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// Gets if the smokehouse has a sausage link
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// Gets if the smokehouse has a egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Gets if the smokehouse has a hash brown
        /// </summary>
        public bool HashBrowns { get; set; } = true;

        /// <summary>
        /// Gets if the smokehouse has a pancake
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        /// Gets special instructions for the smokehouse
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancake");

                return instructions;
            }
        }

        /// <summary>
        /// Provides a description for the smokehouse
        /// </summary>
        /// <returns>A description</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
