﻿/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(entree);
        }

        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.True(entree.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.True(entree.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.True(entree.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher entree = new PhillyPoacher();
            entree.Sirloin = false;
            Assert.False(entree.Sirloin);
            entree.Sirloin = true;
            Assert.True(entree.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher entree = new PhillyPoacher();
            entree.Onion = false;
            Assert.False(entree.Onion);
            entree.Onion = true;
            Assert.True(entree.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher entree = new PhillyPoacher();
            entree.Roll = false;
            Assert.False(entree.Roll);
            entree.Roll = true;
            Assert.True(entree.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.Equal(7.23, entree.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.Equal((uint)784, entree.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher entree = new PhillyPoacher();
            entree.Sirloin = includeSirloin;
            entree.Onion = includeOnion;
            entree.Roll = includeRoll;
            if (!includeSirloin)
            {
                Assert.Contains("Hold sirloin", entree.SpecialInstructions);
            }
            if (!includeOnion)
            {
                Assert.Contains("Hold onions", entree.SpecialInstructions);
            }
            if (!includeRoll)
            {
                Assert.Contains("Hold roll", entree.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.Equal("Philly Poacher", entree.ToString());
        }
    }
}