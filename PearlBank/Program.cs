using PearlBank.Models;
using System;
using System.Collections.Generic;

namespace PearlBank
{
    public class Program
    {
        public static void Main()
        {
            //Account acc = new Account("a", "b", 0m); //ERROR
            //IAccount account = new IAccount(); //ERROR
            IAccount account = new BabyAccount("a", "b", 0m, "c");

            TraditionalAccount acc1 = new TraditionalAccount("zlatovlaska", "cokoladova", 154338.2m);
            StudentAccount acc2 = new StudentAccount("kocur", "v cizmach", 154.3m, "naj uni na celom svete");
            BabyAccount acc3 = new BabyAccount("anton", "malicky", 15m, "zlatovlaska");

            List<IAccount> listOfTypeInterface = new List<IAccount>();
            listOfTypeInterface.Add(account);
            listOfTypeInterface.Add(acc1);
            listOfTypeInterface.Add(acc2);
            listOfTypeInterface.Add(acc3);
            foreach (var item in listOfTypeInterface)
            {
                Console.WriteLine($"listOfTypeInterface {item.ToString()}");
            }
            //Console.WriteLine($"listOfTypeInterface {listOfTypeInterface[2].ParentName}"); //ERROR

            List<Account> listOfTypeAbstract = new List<Account>();
            //listOfTypeAbstract.Add(account); //ERROR
            listOfTypeAbstract.Add(acc1);
            listOfTypeAbstract.Add(acc2);
            listOfTypeAbstract.Add(acc3);
            foreach (var item in listOfTypeAbstract)
            {
                Console.WriteLine($"listOfTypeAbstract {item.GetBalance()}");
            }
        }
    }
}