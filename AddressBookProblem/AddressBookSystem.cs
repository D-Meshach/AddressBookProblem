using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class AddressBookSystem
    {
        // List<AddressProperties> addressList = new List<AddressProperties>();
        Dictionary<int, AddressProperties> AddBook = new Dictionary<int, AddressProperties>();
        public class AddressProperties
        {
            public string firstName;
            public string lastName;
            public string address;
            public string city;
            public string state;
            public string zip;
            public Int32 phoneNumber;
            public string email;
        }
        public AddressBookSystem() {

            string checks = "n";
            while (checks == "n")
            {
                Console.WriteLine("Enter Option");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option) 
                {
                    case 1:AddSingleContact(); break;
                    default:Console.WriteLine("Worong key");break;
                }
                Console.WriteLine("Do you wish to exit??Y/N");
               checks = Convert.ToString(Console.ReadLine());

            }
        }
        public void AddSingleContact()
        {
            Console.WriteLine("Enter Name:");
           
        string firstName = Convert.ToString(Console.ReadLine());
        string lastName = Convert.ToString(Console.ReadLine());
        string address = Convert.ToString(Console.ReadLine());
        string city = Convert.ToString(Console.ReadLine());
        string state = Convert.ToString(Console.ReadLine());
        string zip = Convert.ToString(Console.ReadLine());
        Console.WriteLine("number");
        int phoneNumber = Convert.ToInt32(Console.ReadLine());
        string email = Convert.ToString(Console.ReadLine());
        AddressProperties ap = new AddressProperties { firstName = firstName, lastName=lastName,address=address,city=city,state=state,zip=zip,phoneNumber=phoneNumber,email=email};
            if (!AddBook.ContainsKey(ap.phoneNumber))
            {
                AddBook[ap.phoneNumber] = ap;
            }
            else {
                Console.WriteLine("Contact With Phone number already exist");
            }
            Console.WriteLine("Saved");
            Console.WriteLine(AddBook.Count());
       
            

        }
        /*public void display()
        {
            Console.WriteLine(dict);
        }*/
        
    }
}
