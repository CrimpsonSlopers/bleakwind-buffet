/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            BriarheartBurger entree = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(entree);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger entree = new BriarheartBurger();
            Assert.True(entree.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger entree = new BriarheartBurger();
            Assert.True(entree.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger entree = new BriarheartBurger();
            Assert.True(entree.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger entree = new BriarheartBurger();
            Assert.True(entree.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger entree = new BriarheartBurger();
            Assert.True(entree.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger entree = new BriarheartBurger();
            entree.Bun = false;
            Assert.False(entree.Bun);
            entree.Bun = true;
            Assert.True(entree.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger entree = new BriarheartBurger();
            entree.Ketchup = false;
            Assert.False(entree.Ketchup);
            entree.Ketchup = true;
            Assert.True(entree.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger entree = new BriarheartBurger();
            entree.Mustard = false;
            Assert.False(entree.Mustard);
            entree.Mustard = true;
            Assert.True(entree.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger entree = new BriarheartBurger();
            entree.Pickle = false;
            Assert.False(entree.Pickle);
            entree.Pickle = true;
            Assert.True(entree.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger entree = new BriarheartBurger();
            entree.Cheese = false;
            Assert.False(entree.Cheese);
            entree.Cheese = true;
            Assert.True(entree.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger entree = new BriarheartBurger();
            Assert.Equal(6.32, entree.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger entree = new BriarheartBurger();
            Assert.Equal((uint)732, entree.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger entree = new BriarheartBurger();
            entree.Bun = includeBun;
            entree.Ketchup = includeKetchup;
            entree.Mustard = includeMustard;
            entree.Pickle = includePickle;
            entree.Cheese = includeCheese;
            if (!includeBun)
            {
                Assert.Contains("Hold bun", entree.SpecialInstructions);
            }
            if (!includeKetchup)
            {
                Assert.Contains("Hold ketchup", entree.SpecialInstructions);
            }
            if (!includeMustard)
            {
                Assert.Contains("Hold mustard", entree.SpecialInstructions);
            }
            if (!includePickle)
            {
                Assert.Contains("Hold pickle", entree.SpecialInstructions);
            }
            if (!includeCheese)
            {
                Assert.Contains("Hold cheese", entree.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger entree = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", entree.ToString());
        }
    }
}