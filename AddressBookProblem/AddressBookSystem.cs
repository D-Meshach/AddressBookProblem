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
                Console.WriteLine("Enter \n 1) Add Single Contact \n 2) DisplayContact");
                int option = Convert.ToInt16(Console.ReadLine());

                switch (option) 
                {
                    case 1:AddSingleContact(); break;
                    case 2:display();break;
                    default:Console.WriteLine("Worong key");break;
                }
                Console.WriteLine("Do you wish to exit??Y/N");
               checks = Convert.ToString(Console.ReadLine());

            }
        }
        public void AddSingleContact()
        {
        Console.WriteLine("Enter First Name:");
        string firstName = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter Last Name:");
        string lastName = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter Address:");
        string address = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter City:");
        string city = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter State:");
        string state = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter Zip:");
        string zip = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter Phone number");
        int phoneNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Email");
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
        public void display()
        {
            // KeyValuePair<int, AddressProperties> keypair = AddBook.OrderBy(p=>p.Value.firstName);
            for (int i = 0; i < AddBook.Count(); i++)
            {
                KeyValuePair<int, AddressProperties> bookDetail = AddBook.ElementAt(i);
                Console.WriteLine("----" + bookDetail.Value.firstName + " " + bookDetail.Value.lastName+"------");
                Console.WriteLine("Address: "+bookDetail.Value.address);
                Console.WriteLine("City: "+bookDetail.Value.city);
                Console.WriteLine("State: "+bookDetail.Value.state);
                Console.WriteLine("Zip: "+bookDetail.Value.zip);
                Console.WriteLine("phoneNumber: "+bookDetail.Value.phoneNumber);
                Console.WriteLine("Email: "+bookDetail.Value.email);

            }
        }

    }
}
