using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using BankCard;
using System.ServiceModel.Description;

namespace Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uri uri = new Uri("http://localhost:5000");
            WebHttpBinding binding = new WebHttpBinding();
            using (ServiceHost serviceHost = new ServiceHost(typeof(BankCard.Service1), uri))
            {
                ServiceEndpoint endpoint = serviceHost.AddServiceEndpoint(typeof(BankCard.IService1), binding, "");
                endpoint.EndpointBehaviors.Add(new WebHttpBehavior());
                serviceHost.Open();
                Console.WriteLine($"A szerver elindult {DateTime.Now}");
                Console.ReadKey();
                serviceHost.Close();
            };
        }
        }
    }

