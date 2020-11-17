using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace MapShot
{
    public class KaKaoAPI
    {

        public List<string> Search(string qstr)
        {
            string url = "https://dapi.kakao.com/v2/local/search/address.json";
            string query = string.Format("{0}?query={1}", url, qstr);

            List<string> locale = new List<string>();

            WebRequest request = WebRequest.Create(query);

            string rkey = "개발자 키";
            string header = "KakaoAK " + rkey;
            request.Headers.Add("Authorization", header);
            request.UseDefaultCredentials = true;
            request.PreAuthenticate = true;
            request.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string json = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic dob = js.Deserialize<dynamic>(json);

            dynamic docs = dob["documents"];
            object[] buf = docs;


            for (int i = 0; i < buf.Length; i++)
            {
                string lname = docs[i]["address_name"];
                string x = docs[i]["x"];
                string y = docs[i]["y"];
                locale.Add(lname);
                locale.Add(x);
                locale.Add(y);
            }

            return locale;
        }

    }

}
