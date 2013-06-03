using System;

namespace Sample
{
	public class LoadInfo
	{
		public  LoadInfo ()
		{


		}


		public String GetString (String rest,String root,String children)
		{
			var request = System.Net.HttpWebRequest.Create(string.Format(@"http://1.xenon-world-234.appspot.com/{0}", rest));
			request.ContentType = "application/json";
			request.Method = "GET";
			using (System.Net.HttpWebResponse response = request.GetResponse() as System.Net.HttpWebResponse)
			{
				if (response.StatusCode != System.Net.HttpStatusCode.OK)
					return ("Error fetching data. Server returned status code: "+ response.StatusCode);
				using (System.IO.StreamReader reader = new System.IO.StreamReader(response.GetResponseStream()))
				{
					var content = reader.ReadToEnd();
					if(string.IsNullOrWhiteSpace(content)) {
						return ("Response contained empty body...");
					}
					else {
						//Console.Out.WriteLine("Response Body: \r\n {0}", content);
						var JSON = Newtonsoft.Json.Linq.JObject.Parse (content);
						//Console.WriteLine (JSON["cv-home"]["home"]);
						return (String) JSON[root][children];
					}

				}
			}

		}

	}
}

