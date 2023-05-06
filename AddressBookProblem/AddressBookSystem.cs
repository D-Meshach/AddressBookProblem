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
        Dictionary<string, AddressProperties> AddBook = new Dictionary<string, AddressProperties>();
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
                Console.WriteLine("Enter \n 1) Add Single Contact \n 2) DisplayContact \n 3)Edit Contact \n 4) Remove Contact");
                int option = Convert.ToInt16(Console.ReadLine());

                switch (option) 
                {
                    case 1:AddSingleContact(); break;
                    case 2:display();break;
                    case 3:EditContact();break;
                    case 4:DeleteContact();break;
                    case 5: MultipleContact(); break;
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
            if (!AddBook.ContainsKey(ap.firstName))
            {
                AddBook[ap.firstName] = ap;
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
                KeyValuePair<string, AddressProperties> bookDetail = AddBook.ElementAt(i);
                Console.WriteLine("----" + bookDetail.Value.firstName + " " + bookDetail.Value.lastName+"------");
                Console.WriteLine("Address: "+bookDetail.Value.address);
                Console.WriteLine("City: "+bookDetail.Value.city);
                Console.WriteLine("State: "+bookDetail.Value.state);
                Console.WriteLine("Zip: "+bookDetail.Value.zip);
                Console.WriteLine("phoneNumber: "+bookDetail.Value.phoneNumber);
                Console.WriteLine("Email: "+bookDetail.Value.email);
                

            }
        }
        public void EditContact()
        {
            Console.WriteLine("Enter the name to search");
            string name = Convert.ToString(Console.ReadLine());
            AddBook.ToList().Find(u => u.Value.firstName.Contains("asdf"));
            if (AddBook.ContainsKey(name))
            {
                Console.WriteLine("Update \n 1)lastName \n 2) Address \n 3)city \n 4) state \n  5)Zip \n 6)phone Number \n 7) Email");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:Console.WriteLine("Enter last name");
                        string lastName = Convert.ToString(Console.ReadLine());
                        AddBook[name].lastName=lastName;break;
                    case 2:
                        Console.WriteLine("Enter Address");
                        string address = Convert.ToString(Console.ReadLine());
                        AddBook[name].address = address; break;
                    case 3:
                        Console.WriteLine("Enter City");
                        string city = Convert.ToString(Console.ReadLine());
                        AddBook[name].city = city; break;
                    case 4:
                        Console.WriteLine("Enter state");
                        string state = Convert.ToString(Console.ReadLine());
                        AddBook[name].state = state; break;
                    case 5:
                        Console.WriteLine("Enter zip");
                        string zip = Convert.ToString(Console.ReadLine());
                        AddBook[name].zip = zip; break;
                    case 6:
                        Console.WriteLine("Enter phone number");
                        int phoneNumber = Convert.ToInt32(Console.ReadLine());
                        AddBook[name].phoneNumber = phoneNumber; break;
                    case 7:
                        Console.WriteLine("Enter email");
                        string email = Convert.ToString(Console.ReadLine());
                        AddBook[name].email = email; break;
                }
                
                /*Console.WriteLine("Enter address");
                string address = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter City");
                string city = Convert.ToString(Console.ReadLine());*/
            }
            else 
            {
                Console.WriteLine("No data Found");
            }
           /* var value = AddBook.Where(k => k.Value.firstName.Contains(name)).Select(k => k.Value);
            foreach (var result in value)
            {
                
                Console.WriteLine(result.firstName+"--"+result.lastName);
            }*/
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter the name to remove");
            string name = Convert.ToString(Console.ReadLine());
            if (AddBook.ContainsKey(name))
            {
                AddBook.Remove(name);
            }
            else 
            {
                Console.WriteLine("No such person with first name found");
            }
        }
        //Multiple Contact UC5
        public void MultipleContact()
        {
            Console.WriteLine("Enter the number of contacts");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            
            while (i < num) 
            {
                Console.WriteLine("Enter contact- "+(i+1));
                AddSingleContact();
                i++;
            }
        }

    }
}
