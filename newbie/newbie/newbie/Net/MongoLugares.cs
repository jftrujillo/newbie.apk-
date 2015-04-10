using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;
using Windows.Web.Http.Headers;

namespace newbie.Net
{
    public class MongoLugares<T>
    {

        public interface IMongo
        {
           
            void loadDocumentsLugares(List<T> documents);

        }

        const String URL_BASE = "https://api.mongolab.com/api/1/databases/";

        HttpClient client;
        String url;
        String apiKey;
        IMongo iMongo;


        public MongoLugares(String apiKey, String dbName, String collectionName)
        {
            client = new HttpClient();

            this.apiKey = "apiKey=" + apiKey;

            url = URL_BASE + dbName + "/collections/" + collectionName + "?" + this.apiKey;

        }

        public async void insertDocument(T document)
        {
            JsonSerializerSettings property
                = new JsonSerializerSettings();

            property.NullValueHandling
                = NullValueHandling.Ignore;

            String json = JsonConvert.SerializeObject(document, Formatting.None, property);

            HttpStringContent content = new HttpStringContent(json);

            HttpMediaTypeHeaderValue contentType = new HttpMediaTypeHeaderValue("application/json");
            content.Headers.ContentType = contentType;

            await client.PostAsync(new Uri(url), content);


        }



        public async void findAllDocumentsLugares(IMongo iMongo)
        {

            HttpResponseMessage msg = await client.GetAsync(new Uri(url));
            String jsonArray = msg.Content.ToString();

            List<T> data = JsonConvert.DeserializeObject<List<T>>(jsonArray);

            iMongo.loadDocumentsLugares(data);

        }

    }
}

