using System;
using System.Collections.Generic;

namespace ConsoleApp67
{
    public class Program
    {
        public static void Main()
        {
                Country c1 = new Country() { Name = "AUS", Code = "AUSTRAILA", Capital = "Camberra" };
                Country c2 = new Country() { Name = "SAF", Code = "SOUTH AFRICA", Capital = "Cape town" };
                Country c3 = new Country() { Name = "IND", Code = "INDIA", Capital = "NEW DELHI" };
                Country c4 = new Country() { Name = "GBR", Code = "UNITED KINGDOM", Capital = "LONDON" };
                Country c5 = new Country() { Name = "CAD", Code = "CANADA", Capital = "OTTAWA" };

                Dictionary<string, Country> dictlist = new Dictionary<string, Country>();
                dictlist.Add(c1.Name, c1 );
                dictlist.Add(c2.Name, c2);
                dictlist.Add(c3.Name, c3);
                dictlist.Add(c4.Name, c4);
                dictlist.Add(c5.Name, c5);

            string userchoice = string.Empty;
            do
            {
                Console.WriteLine("Please enter your country code so we can find you, now we have many messages");
                string strcountry = Console.ReadLine().ToUpper();

                Country resultcountry = dictlist.ContainsKey(strcountry) ? dictlist[strcountry] : null;

                if (resultcountry == null)
                {
                    Console.WriteLine("Country code not valid");
                }
                else
                {
                    Console.WriteLine("Name = {0}, Capital ={1}", resultcountry.Name, resultcountry.Capital);
                }

                do
                {
                    Console.WriteLine("Do you want to continue - YES OR NO ?");
                    userchoice = Console.ReadLine().ToUpper();
                }
                while (userchoice != "NO" && userchoice != "YES");
            }
            while (userchoice == "YES");
        }

        public class Country
        {
            public string Name { get; set; }
            public string Code { get; set; }
            public string Capital { get; set; }
        }
    }
}
