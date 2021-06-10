using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = GetCode("https://ru.wikipedia.org/wiki/Заглавная_страница").Result;
            FindMatches(text);
            
        }
        static async Task<string> GetCode(string link) {
            using HttpClient client = new HttpClient();
            var wikiLink = link;
            var response = await client.GetAsync(wikiLink);
            string htmlText = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Скачали ответ: {htmlText.Length} символов");
            return htmlText;
        }

        static void FindMatches(string htmlText)
        {
            // Находим все подстроки, подходящие по шаблону:
            MatchCollection linksCollection = Regex.Matches(htmlText,
                @" href=""\/wiki\/(?<name>[a-zA-Z0-9%]+)""");
 
            foreach (Match link in linksCollection)
                Console.WriteLine($" {HttpUtility.UrlDecode(link.Groups["name"].Value)} : {HttpUtility.UrlDecode(link.Value)}");
            
            
        }
        
 
       
    }
}