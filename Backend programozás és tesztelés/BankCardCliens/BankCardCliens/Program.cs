using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankCardCliens.ServiceReference1;

namespace BankCardCliens
{
    internal class Program
    {
        public static ServiceReference1.Service1Client ServiceReference1 = new ServiceReference1.Service1Client();
        static void Main(string[] args)
        {
            ServiceReference1 = new ServiceReference1.Service1Client();
            BankCard bankCard = new BankCard();
            bankCard = ServiceReference1.GetBankCard();
            Console.WriteLine($"Id: {bankCard.Id}, Nev: {bankCard.Nev}, KartyaSzam: {bankCard.KartyaSzam}, Lejarat: {bankCard.Lejarat}, Kibocsato: {bankCard.Kibocsato}, BiztonsagiKod: {bankCard.BiztonsagiKod}");
            Console.ReadKey();
        }
    }
}
