using Newtonsoft.Json;
using System.Net;

namespace Searching_OMBD.Models
{
    public class MovieDAL
    {
        public static MovieModel GetMovie(string input)
        {
            string id = "9b6b282b";

            //Adjust here
            //setup
            string url = $"https://www.omdbapi.com/?t={input}&apikey={id}";
            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            //save the response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert it to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Adjust here
            //convert to C#
            MovieModel result = JsonConvert.DeserializeObject<MovieModel>(JSON);
            return result;
        }
    }
}
