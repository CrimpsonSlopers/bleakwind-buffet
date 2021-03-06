﻿/*
 * Author: Zachery Brunner
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater drink = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(drink);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater drink = new WarriorWater();
            Assert.True(drink.Ice);
        }

        [Fact]
        public void ShouldNotHaveLemonByDefault()
        {
            WarriorWater drink = new WarriorWater();
            Assert.False(drink.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater drink = new WarriorWater();
            Assert.Equal(Size.Small, drink.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater drink = new WarriorWater();
            drink.Ice = false;
            Assert.False(drink.Ice);
            drink.Ice = true;
            Assert.True(drink.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater drink = new WarriorWater();
            drink.Lemon = true;
            Assert.True(drink.Lemon);
            drink.Lemon = false;
            Assert.False(drink.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater drink = new WarriorWater();
            drink.Size = Size.Large;
            Assert.Equal(Size.Large, drink.Size);
            drink.Size = Size.Medium;
            Assert.Equal(Size.Medium, drink.Size);
            drink.Size = Size.Small;
            Assert.Equal(Size.Small, drink.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater drink = new WarriorWater();
            drink.Size = size;
            Assert.Equal(price, drink.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater drink = new WarriorWater();
            drink.Size = size;
            Assert.Equal(cal, drink.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater drink = new WarriorWater();
            drink.Ice = includeIce;
            drink.Lemon = includeLemon;
            if (!includeIce)
            {
                Assert.Contains("Hold ice", drink.SpecialInstructions);
            }
            if (includeLemon)
            {
                Assert.Contains("Add lemon", drink.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater drink = new WarriorWater();
            drink.Size = size;
            Assert.Equal(name, drink.ToString());
        }
    }
}
