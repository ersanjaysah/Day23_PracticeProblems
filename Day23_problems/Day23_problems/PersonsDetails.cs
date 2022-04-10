using System;
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
                Console.WriteLine("\nRecord - " + count);
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

        public void AddRecord() // Adding records of a person .
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
               Console.WriteLine("No Duplication found ");//if person name not found

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

        public void CheckPersonsNameByCity()  //To Serch the person by city name
        {
            Console.WriteLine("Enter the city Name to find person ");
            string personcity = Console.ReadLine();
            List<Contacts> contacts = records.FindAll(x => (x.city == personcity));

            if (contacts.Count == 0)             //Checking person name
            {
                Console.WriteLine("No person found in that City");
            }
            else
            {

                Console.WriteLine("Displaying the person Details by City: ");
                int temp = 1;
                foreach (Contacts contact in contacts) //will give all the persons details by giving city name
                {
                    Console.WriteLine("Record: " + temp);
                    Console.WriteLine("First name is: " + contact.firstName);
                    Console.WriteLine("Last name is: " + contact.lastName);
                    Console.WriteLine("Address : " + contact.address);
                    Console.WriteLine("City : " + contact.city);
                    Console.WriteLine("State : " + contact.state);
                    Console.WriteLine("Email : " + contact.email);
                    Console.WriteLine("Zip code : " + contact.zip);
                    Console.WriteLine("Phone Number : " + contact.phoneNumber);
                    temp++;
                }
            }
        }

        public void CheckPersonNameByState()   //To Search the person by State name
        {

            Console.WriteLine("Please enter the State to find person name: ");
            string Personstate = Console.ReadLine();
            List<Contacts> contacts1 = records.FindAll(y => (y.state == Personstate));

            if (contacts1.Count == 0)  //Checking the person name
            {
                Console.WriteLine("No person found in that state");
            }
            else
            {

                Console.WriteLine("Displaying the Contact by State: ");
                int count = 1;
                foreach (Contacts contact in contacts1) //will give all the person details by searching state name
                {
                    Console.WriteLine("Record:-" + count);
                    Console.WriteLine("First name is: " + contact.firstName);
                    Console.WriteLine("Last name is: " + contact.lastName);
                    Console.WriteLine("Address : " + contact.address);
                    Console.WriteLine("City : " + contact.city);
                    Console.WriteLine("State : " + contact.state);
                    Console.WriteLine("Email : " + contact.email);
                    Console.WriteLine("Zip code : " + contact.zip);
                    Console.WriteLine("Phone Number : " + contact.phoneNumber);
                    count++;
                }
            }
        }
    }
}
