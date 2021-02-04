using System;

namespace AddressBook
{
    class ContactDetails
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public int zip;
        public int phoneNumber1;
        public int phoneNumber2;
        public string email;


        public ContactDetails(string firstName, string lastName, string address, string city, string state, int zip, int phoneNumber1, int phoneNumber2, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber1 = phoneNumber1;
            this.phoneNumber2 = phoneNumber2;
            this.email = email;

        }
        public string toString()
        {
            return " Details of " + firstName + " " + lastName + " are: " + " Address: " +address + "  City: " + city +"\n"
                                    +"                           "+ " State: " + state + "  Zip: " + zip +"\n"
                                    + "                          "+ " PhoneNumber: " +phoneNumber1 + phoneNumber2 +"\n"
                                    + "                          "+ " Email: " + email;

        }
    }

    class Program
    {
        private int numOfPerson = 0;
        private ContactDetails[] contactDetails;
        public Program()
        {
            contactDetails = new ContactDetails[4];
        }


        public void AddDetails(string firstName, string LastName, string address, string city, string state, int zip, int phoneNumber1, int phoneNumber2, string email)
        {
            contactDetails[numOfPerson] = new ContactDetails(firstName, LastName, address, city, state, zip, phoneNumber1, phoneNumber2, email);
            numOfPerson++;
        }

        public void ComputeDetails()
        {

            for (int i = 0; i < numOfPerson; i++)
            {
                Console.WriteLine(contactDetails[i].toString());
            }
        }

        static void Main(string[] args)
        {
            Program details = new Program();
            for (int numOfPerson = 1; numOfPerson < 4; numOfPerson++)
            {
                string firstName = Console.ReadLine();
                string lastName = Console.ReadLine();
                string address = Console.ReadLine();
                string city = Console.ReadLine();
                string state = Console.ReadLine();
                int zip = Convert.ToInt32(Console.ReadLine());
                int phoneNumber1 = Convert.ToInt32(Console.ReadLine());
                int phoneNumber2 = Convert.ToInt32(Console.ReadLine());
                string email = Console.ReadLine();
                details.AddDetails(firstName, lastName, address, city, state, zip, phoneNumber1, phoneNumber2, email);
            }
            details.ComputeDetails();
        }


    }
}
