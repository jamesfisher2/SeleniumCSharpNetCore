using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("setup");
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            //writing in TextBox
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

            //marking CheckBox
            Driver.FindElement(By.XPath("//*[@id=\"maincont\"]/div[1]/div[4]/div[2]/div[2]/div/ul/li[1]/label/div[2]")).Click();
            //Driver.FindElement(By.XPath("input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            //Choosing element in ComboBox by custom method
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

            Console.WriteLine("test1");
            Assert.Pass();
        }
    }
}