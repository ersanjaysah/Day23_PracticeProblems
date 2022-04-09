﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23_problems
{
    public class PersonsDetails
    {
        List<Contacts> records = new List<Contacts>(); // using list

        public void DetailsOfPerson()
        {
            if (records.Count == 0)
            {
                Console.WriteLine("AddressBook is empty, please add some records or Address");
            }
            int count = 1;
            foreach (var person in records.ToList())  
            {
                Console.WriteLine("\n\nRecord - " + count);
                Console.WriteLine("First Name : " + person.firstName);
                Console.WriteLine("Last Name : " + person.lastName);
                Console.WriteLine("Address : " + person.address);
                Console.WriteLine("City : " + person.city);
                Console.WriteLine("State : " + person.state);
                Console.WriteLine("Email : " + person.email);
                Console.WriteLine("Zip code : " + person.zip);
                Console.WriteLine("Phone Number : " + person.phoneNumber);
                count++;

            }
        }

        public void AddRecord() // Adding records
        {
            Contacts contact = new Contacts();

            Console.WriteLine("Enter First Name of The Contact to checkfor Duplication: ");
            string name = Console.ReadLine();

            bool flag = records.Any(x => string.Equals(x.firstName, name));// checking for Duplication

            if (flag)
            {
                Console.WriteLine("The given Name is already exist");
            }
            else
            {
               Console.WriteLine("No Duplication found ");

                Console.WriteLine("Enter your First Name : ");
                contact.firstName = Console.ReadLine();
                Console.WriteLine("Enter your Last Name : ");
                contact.lastName = Console.ReadLine();
                Console.WriteLine("Enter your Address : ");
                contact.address = Console.ReadLine();
                Console.WriteLine("Enter your City Name : ");
                contact.city = Console.ReadLine();
                Console.WriteLine("Enter your State Name : ");
                contact.state = Console.ReadLine();
                Console.WriteLine("Enter your Zip Code : ");
                contact.zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Phone Number : ");
                contact.phoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter your Email Address: ");
                contact.email = Console.ReadLine();

                records.Add(contact);
            }
        }
    }
}
