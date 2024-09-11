using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference1;

namespace Client
{
    internal class Program
    {
        public static ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        static void Main(string[] args)
        {
            client = new ServiceReference1.Service1Client();
            Allat allat = new Allat();
            allat = client.GetAnimal();
            Console.WriteLine(allat.Name);
            Console.WriteLine(allat.weight);

            Console.ReadKey();
        }
    }
}
