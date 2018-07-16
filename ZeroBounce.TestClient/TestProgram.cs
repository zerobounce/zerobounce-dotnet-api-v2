using System;
using System.Reflection;

namespace Zerbounce.TestClient
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            var zeroBounceAPI = new ZeroBounce.ZeroBounceAPI();
            zeroBounceAPI.api_key =  "Your API Key";
            zeroBounceAPI.EmailToValidate = "Email Address To Validate";       
            zeroBounceAPI.ip_address =  "IP Address Where Email Registered From";

            zeroBounceAPI.api_key = "8f828cf33aa04a4591a2de5e4ef6bce7";
            zeroBounceAPI.EmailToValidate = "henry@gnail.com";
            zeroBounceAPI.ip_address = "123.123.123.111";


            zeroBounceAPI.ReadTimeOut = 100000; // "Any integer value in milliseconds;
            zeroBounceAPI.RequestTimeOut = 100000; // "Any integer value in milliseconds;

            var apiProperties = zeroBounceAPI.ValidateEmail();
            if (apiProperties != null) { 
                PropertyInfo[] properties =  apiProperties.GetType().GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    Console.WriteLine(property.Name + ": " + property.GetValue(apiProperties));
                }
            }

            //Check Credits
            zeroBounceAPI.api_key = "Your API Key";
            var apiCredits = zeroBounceAPI.GetCredits();
            if (apiCredits != null)
            {
                PropertyInfo[] properties = apiCredits.GetType().GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    Console.WriteLine(property.Name + ": " + property.GetValue(apiCredits));
                }
            }
        }   
    }

}
