using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace SonarQube.Sample.Test
{
    [Binding]
    public class ShoppingCartSteps
    {
        public string MemberLevel { get; private set; }
        public int Price { get; private set; }
        public object TotalPrice { get; private set; }

        [Given(@"會員等級是 ""(.*)""")]
        public void 假設會員等級是(string memberLevel)
        {
            this.MemberLevel = memberLevel;
        }
        
        [Given(@"購物金額為 ""(.*)"" 元")]
        public void 假設購物金額為元(int price)
        {
            this.Price = price;
        }
        
        [When(@"計算總金額")]
        public void 當計算總金額()
        {
            var shoppingCart = new ShoppingCart();
            this.TotalPrice = shoppingCart.Calculate(this.MemberLevel, this.Price);
        }
        
        [Then(@"總金額是 ""(.*)"" 元")]
        public void 那麼總金額是元(int totalPrice)
        {
            Assert.AreEqual(this.TotalPrice, totalPrice);
        }
    }
}
