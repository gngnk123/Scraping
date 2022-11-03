using System;
using HtmlAgilityPack;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using System.Net.Http;
using System.Threading.Tasks;
using System.IO;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            gethtmlscrapping();
            Console.ReadLine();
        }

        private static async void gethtmlscrapping()
        {
            HtmlWeb Web = new HtmlWeb();
            HtmlDocument Document = Web.Load("http://calculator.mctrans.ge/?fbclid=IwAR3LU0nR35Vbodu84PKGUxskEomVOkinavhrLW1XfwOyw1hO7_o5RlX1O9I");


            //var title = Document.DocumentNode.SelectNodes("/html/body/div/div[1]/h4/text()n").First().InnerText;
            var title1 = Document.DocumentNode.SelectNodes("//*[@id=\"auc_id\"]/option");
            var title2 = Document.DocumentNode.SelectNodes("//*[@id=\"city_id\"]/option");
            var title3 = Document.DocumentNode.SelectNodes("//*[@id=\"port_id\"]/option");
            //Console.WriteLine(title);
            for (int i = 1; i < title1.ToList().Count; i++)
            {
                Console.Write(title1.ToList()[i].InnerText + "       ");
            }
            /*for (int i = 1; i < title1.ToList().Count; i++)
            {
                var title4 = Document.DocumentNode.SelectNodes("//*[@id=\"city_id\"]/option");

                for (int x = 0; x < title4.ToList().Count; x++)
                {
                    
                    Console.Write(title4.ToList()[x].InnerText + "       ");
                }
            }*/

            


            //title1.ToList().ForEach(x => Console.Write(Document.DocumentNode.SelectNodes("//*[@id=\"city_id\"]/option"))) ;
            //title2.ToList().ForEach(x => Console.WriteLine(x.InnerText));

        }
    }
}



/*var httpclient = new HttpClient();
var html =await httpclient.GetStringAsync(url);

var htmldocument =new HtmlDocument();
htmldocument.LoadHtml(html);*/



/* var productlist = htmldocument.DocumentNode.Descendants("div")
     .Where(node => node.GetAttributeValue("p", "").Contains(""))
     .ToList();*/

//.Equals("content")).ToList();

//var programmerLinks = htmldocument.DocumentNode.SelectNodes("//li[not(contains(@class, 'tocsection'))]");
/*Console.WriteLine(productlist);
List<string> wikiLink = new List<string>();

foreach (var link in productlist)
{
    wikiLink.Add(link.ToString());
    Console.WriteLine(link.ToString);
}*/



/* foreach (var product in productlist)
 {

     Console.WriteLine(product.GetAttributeValue("href", ""));
 }*/

//Console.WriteLine(url);
//Console.Write(httpclient);
//Console.Write(html);