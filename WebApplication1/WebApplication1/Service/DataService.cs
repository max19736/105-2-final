using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace WebApplication1.Service
{
    public class DataService
    {
        private static List<Models.Album> list = new List<Models.Album>();

        static DataService()
        {
            /*
            var item = new Models.Album();

            item.ID = "1";
            item.Genre = "pop";
            item.Title = "The Best Of The Men At Work";
            item.Price = 8;
            item.ImageUrl = @"/Content/Image/Desert.jpg";

            list.Add(item);

            var item2 = new Models.Album();
            item2.ID = "2";
            item2.Genre = "Metal";
            item2.Title = "Black Light Syndrome";
            item2.Price = 20;
            item2.ImageUrl = @"/Content/Image/Desert.jpg";
            list.Add(item2);

            */
        }
        public DataService()
        {

        }

        /*
        public List<Models.Album> LoadAllAlbum()
        {
             
            return list;
        }
        */
        
        public void LoadCandidate()
        {
            using (var webClient = new System.Net.WebClient())
            {
               // var json = webClient(URL);
                // Now parse with JSON.Net
            }
            var baseAddress = "http://www.taichungfes.com.tw/api/Candidate/GetPage";

            var http = (HttpWebRequest)WebRequest.Create(new Uri(baseAddress));
            http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Method = "POST";

            string parsedContent = @"{'PageNo':1,'PageSize':16,'TotalCount':0}";

            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(parsedContent);

            Stream newStream = http.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();

            var response = http.GetResponse();

            var stream = response.GetResponseStream();
            var sr = new StreamReader(stream);
            var content = sr.ReadToEnd();

            //
        }


        public List<Models.Album> LoadAllAlbum()
        {
            List<Models.Album> list = new List<Models.Album>();


            var item = new Models.Album();

            item.number = "1103105316";
            item.name = "李蕙瑄";
            item.photo = @"/Content/image/dodo.jpg";
            item.link = "https://www.youtube.com/watch?v=lo2_XHi_eIw&index=2&list=PLnZUyh2k9Fsd6SuedStL3qIYMP4wtQw3P";


            list.Add(item);

            var item2 = new Models.Album();

            item2.number = "1103105327";
            item2.name = "李偲瑋";
            item2.photo = @"/Content/image/thisway.jpg";
            item2.link = "http://www.hellokittygoaround.com.tw/";
            list.Add(item2);

            var item3 = new Models.Album();

            item3.number = "1103105344";
            item3.name = "林佑宗";
            item3.photo = @"/Content/image/yo.jpg";
            item3.link = "https://zh.wikipedia.org/wiki/%E8%B7%86%E6%8B%B3%E9%81%93";
            list.Add(item3);

            return list;
        }




    }
}