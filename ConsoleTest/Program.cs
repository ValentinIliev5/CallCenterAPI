using Newtonsoft.Json.Linq;
using Services;
using System.Net;

string link = "https://localhost:7150/api/Calls/GetByClient/number?number=0887078888";

var client = new WebClient();

string body = "";
body = client.DownloadString(link);

JToken jObject = JToken.Parse(body);

foreach (var item in jObject)
{
    Console.Write(item["startOfCall"] + " - " );
    Console.WriteLine(item["endOfCall"]);
}
