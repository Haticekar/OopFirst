// See https://aka.ms/new-console-template for more information


using IntroR2.Business;
using IntroR2.DataAccess.Concretes;
using IntroR2.Entities;

Console.WriteLine("Hello, World!");

CourseManager courseManager = new(new EfCourseDal());
List<Course> courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Id + " " + courses2[i].Name);
}

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678910";
customer1.FirstName="Aslı";
customer1.LastName ="Karayiğit";
customer1.CustomerNumber ="123456";


IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "10987654321";
customer2.FirstName="Özgür";
customer2.LastName ="Atılgan";
customer2.CustomerNumber ="654321";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama IO";
customer3.CustomerNumber = "122333";
customer3.TaxNumber = "9876543";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "ABC";
customer4.CustomerNumber = "333221";
customer4.TaxNumber = "3456789";


//Value Types : int , bool , double ...
//Referance Types : arrays , class , interface ... 

//                          101         102         103     104  REFERANS NUMBER
BaseCustomer[] customers = { customer1, customer2,customer3,customer4 };

//POLYMORPHISM
foreach (BaseCustomer customer in customers)  // veritipi -- BaseCustomer
{
    Console.WriteLine(customer.CustomerNumber + " " +customer.Id);
}



