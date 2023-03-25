using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Portable.Text;
using System.Net;
using System.Collections.Generic;
//using System.Text;

namespace XMLReader.Models
{
    public static class XMLGetter
    {
        public static async Task<IEnumerable<yml_catalogShopOffer>> GetXmlText(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;
            
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
            StreamReader responseStream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("windows-1251"));

            XmlSerializer serializer = new XmlSerializer(typeof(yml_catalog));
            yml_catalog catalog = (yml_catalog)serializer.Deserialize(responseStream);
            IEnumerable<yml_catalogShopOffer> offers = catalog.shop.offers;
            return offers;
        }
    }
}