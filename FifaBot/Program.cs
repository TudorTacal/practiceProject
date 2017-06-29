using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace FifaBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://signin.ea.com/p/web2/login?execution=e798792072s1&initref=https%3A%2F%2Faccounts.ea.com%3A443%2Fconnect%2Fauth%3Fscope%3Dbasic.identity%2Bbasic.persona%2Bsignin%2Boffline%2Bsecurity.challenge%26redirect_uri%3Dhttp%253A%252F%252Fwww.easports.com%252Ffifa%252Flogin_check%26locale%3Den_US%26state%3D0xwLCH8pwJ-oHGdm1Snor07FuZz059HYk1Z2BETctgE%26response_type%3Dcode%26client_id%3DEASFC-web");

            //client.Authenticator = new SimpleAuthenticator("email ", "tunchi6x@podeno.com", "password", "Churu177");
            

            var request = new RestRequest(Method.POST);
            request.AddBody("email", "tunchi6x@podeno.com");
            request.AddBody("password", "Churu177");
            IRestResponse response = client.Execute(request);

            var content = response.Content;
            

            Console.Write(content);
            Console.WriteLine(response.ResponseUri);
            Console.ReadLine();
        }
    }
}
