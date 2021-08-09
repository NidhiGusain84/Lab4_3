using System;
using System.Collections.Generic;

namespace Lab4_3
{
    class Customer
    {
        private string Company;
        private string ContactName;
        private string ContactEmail;
        private string Phone;

        public Customer(string _Company, string _ContactName, string _ContactEmail, string _phone)
        {
            SetCompany(_Company);
            SetContactName(_ContactName);
            SetContactEmail(_ContactEmail);
            SetPhone(_phone);
        }

        public void SetCompany(string _Company)
        {
            Company = _Company;
        }
        public string GetCompany()
        {
            return Company;
        }
        public void SetContactName(string _ContactName)
        {
            ContactName = _ContactName;
        }
        public string GetContactName()
        {
            return ContactName;
        }
        public void SetContactEmail(string _ContactEmail)
        {
            ContactEmail = _ContactEmail;
        }
        public string GetContactEmil()
        {
            return ContactEmail;
        }
        public void SetPhone(string _Phone)
        {
            Phone = _Phone;
        }
        public string GetPhone()
        {
            return Phone;
        }

        public override string ToString()
        {
            return $"\nCompany: {Company}\nContact Name: {ContactName}\nContact Email: {ContactEmail}\nPhone: {Phone}";
        }

    }

    class Program
    {
        static void ListCustomes(List<Customer> customers)
        {
            foreach (Customer cust in customers)
            {
                Console.WriteLine(cust);
            }
        }

        static Customer SearchCompanyByName(List<Customer> customers, string company)
        {
            foreach (Customer cust in customers)
            {
                if (cust.GetCompany().ToLower() == company.ToLower())
                {
                    return cust;
                }
            }
            return null;
        }
        

        static Customer SearchCompanyByPhone(List<Customer> customers, string phone)
        {
            foreach (Customer cust in customers)
            {
                if (cust.GetPhone() == phone)
                {
                    return cust;
                }
            }
            return null;
        }

        static void Main(string[] args)
        {
            Customer c1 = new Customer("ABC Company", "Nidhi Gusain", "nidhi@abccompany", "345-638-5887");
           
            Customer c2 = new Customer("XYZ Company", "Sirisha", "sirisha@xyzcompany", "256-348-8832");          

            List<Customer> customersList = new List<Customer>();
            customersList.Add(c1);
            customersList.Add(c2);           

            Customer myCustomer = new Customer("NG Corporation", "Manit", "manit@ngcorporation", "785-145-4173");
            customersList.Add(myCustomer);

            myCustomer = new Customer("Laksh Pvt Ltd", "Laxman", "laxman@lakshpvtltd", "321-258-6355");
            customersList.Add(myCustomer);

            myCustomer = new Customer("S&M Co.","Nilakshi", "nilakshi@smco", "568-948-3355" );
            customersList.Add(c1);

            ListCustomes(customersList);

            Console.Write("\nEnter company name: ");
            string coName = Console.ReadLine();

           

            myCustomer = SearchCompanyByName(customersList, coName);

            if (myCustomer != null)
            {
                Console.WriteLine("\nCompany details:");
                Console.WriteLine(myCustomer);
            }
            else
            {
                Console.WriteLine("Company not found!");
            }

            


        }
    }
}
