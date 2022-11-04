using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ConsoleApp4
{
    internal class Program
    {
        private static IWebDriver driver;
        static void Main(string[] args)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://calculator.mctrans.ge/?fbclid=IwAR3zsudrbBgCGAfNnvWgEh2z9wqpKWKSPp6peY6_cQ6WwCjOypFc1vFfkjE");
            Thread.Sleep(2000);

            var collections = driver.FindElement(By.XPath("//*[@id=\"myModal\"]/div/div/div[1]/a"));
            Console.WriteLine(collections);
            //collections.Submit();
            collections.Click();
            Thread.Sleep(2000);
            //collections.SendKeys("Webshop");
            //collections.Submit();

            var Auction = driver.FindElement(By.XPath("//*[@id=\"auc_id\"]"));
            Auction.Click();
            Thread.Sleep(1000);
            for (int i = 2; i < 10; i++)
            {
                var Copart = driver.FindElement(By.XPath("//*[@id=\"auc_id\"]/option["+i+"]"));
                Copart.Click();
                Thread.Sleep(1000);

                var body = driver.FindElement(By.XPath("/html/body"));
                body.Click();
                Thread.Sleep(1000);

                    var State_city = driver.FindElement(By.XPath("//*[@id=\"city_id\"]"));
                    State_city.Click();
                    Thread.Sleep(1000);

                for (int x = 2; x < 235; x++)
                {
                    var AL_ANC = driver.FindElement(By.XPath("//*[@id=\"city_id\"]/option["+x+"]"));
                    AL_ANC.Click();
                  

                    body.Click();

                    var USA_p = driver.FindElement(By.XPath("//*[@id=\"port_id\"]"));
                    USA_p.Click();
         

                    for (int y = 2; y < 8; y++)
                    {

                        var nj = driver.FindElement(By.XPath("//*[@id=\"port_id\"]/option["+y+"]"));
                        nj.Click();
             


                        var body1 = driver.FindElement(By.XPath("/html/body/div/div[1]"));
                        body1.Click();

                        var value = driver.FindElements(By.XPath("//*[@id=\"data3\"]"));
                        foreach (var item in value)
                        {
                            Console.WriteLine(item.Text);
                        }
                    }
                }
            }

        }
    }
}
