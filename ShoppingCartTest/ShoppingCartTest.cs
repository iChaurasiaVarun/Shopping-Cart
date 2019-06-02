using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart.Models;
using ShoppingCart.Repository;

namespace ShoppingCartTest
{
    /// <summary>
    /// Test cases for Shopping cart pricing
    /// </summary>
    [TestClass]
    public class ShoppingCartTest
    {
        [TestInitialize]
        public void Initialize()
        {

        }

        [TestMethod]
        public void NoDiscountValidDataTest()
        {
            ICart cart = new Cart();
            cart.AddItem(new CartItem("1", 100, 1));
            cart.AddItem(new CartItem("2", 100, 1));
            cart.AddItem(new CartItem("3", 100, 1));

            ICalculateCartPrice calculateCartPrice = new CalculateCartPrice(cart);
            Assert.AreEqual(300, calculateCartPrice.GetCartFinalPrice());
        }

        [TestMethod]
        public void InvalidDiscountValidDataTest()
        {
            ICart cart = new Cart();
            cart.AddItem(new CartItem("1", 100, 1));
            cart.AddItem(new CartItem("2", 100, 1));
            cart.AddItem(new CartItem("3", 100, 1));

            ICalculateCartPrice calculateCartPrice = new CalculateCartPrice(cart, "InvalidDiscount");
            Exception ex = Assert.ThrowsException<Exception>(() => calculateCartPrice.GetCartFinalPrice());
            Assert.AreEqual("InvalidDiscount", ex.Message);
        }

        [TestMethod]
        public void NoItemValidDataTest()
        {
            ICart cart = new Cart();

            ICalculateCartPrice calculateCartPrice = new CalculateCartPrice(cart);
            Assert.AreEqual(0, calculateCartPrice.GetCartFinalPrice());
        }

        [TestMethod]
        public void Buy2Get1WithValidDataTest()
        {
            ICart cart = new Cart();
            cart.AddItem(new CartItem("1", 100, 1));
            cart.AddItem(new CartItem("2", 100, 1));
            cart.AddItem(new CartItem("3", 100, 1));

            ICalculateCartPrice calculateCartPrice = new CalculateCartPrice(cart, "Buy 2 Get 1");
            Assert.AreEqual(200, calculateCartPrice.GetCartFinalPrice());
        }

        [TestMethod]
        public void Buy2Get1WithInvalidMinimumCartValueTest()
        {
            ICart cart = new Cart();
            cart.AddItem(new CartItem("1", 100, 1));
            cart.AddItem(new CartItem("2", 10, 1));
            cart.AddItem(new CartItem("3", 10, 1));

            ICalculateCartPrice calculateCartPrice = new CalculateCartPrice(cart, "Buy 2 Get 1");
            Exception ex = Assert.ThrowsException<Exception>(() => calculateCartPrice.GetCartFinalPrice());
            Assert.AreEqual("MinCartValueError", ex.Message);
        }

        [TestMethod]
        public void Buy2Get1WithInvalidMinimumCartItemTest()
        {
            ICart cart = new Cart();
            cart.AddItem(new CartItem("1", 100, 1));
            cart.AddItem(new CartItem("2", 300, 1));

            ICalculateCartPrice calculateCartPrice = new CalculateCartPrice(cart, "Buy 2 Get 1");
            Exception ex = Assert.ThrowsException<Exception>(() => calculateCartPrice.GetCartFinalPrice());
            Assert.AreEqual( "MinCartItemError", ex.Message);
        }

        [TestCleanup]
        public void TestClean()
        {

        }
    }
}
