using HtmlAgilityPack;
using CarDealerships.Common.Models;

namespace CarDealerships.Parser
{
    public class Parser
    {
        public List<CarModel> GetCars()
        {
            List<CarModel> cars = new List<CarModel>();
            var html = @"https://salon.av.by/audi/adverts/";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);
            var nodes = htmlDoc.DocumentNode.SelectNodes("//a[@class='model']");
            if (nodes is not null)
            {
                foreach (HtmlNode item in nodes)
                {
                    cars.Add(new CarModel { Name =item.InnerText, SalonId=1 });
                }
            }
            return cars;
        }
    }
}
