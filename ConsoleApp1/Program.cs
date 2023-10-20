// See https://aka.ms/new-console-template for more information

using DAO;
using Entity;

var dp = new DAOPerson();

//dp.Insert(new Person()
//{
//    Name = "Lucas",
//    BirthDate = new DateTime(2000, 1, 1),
//    Dni = "12345679"
//});

//dp.DeleteByIdOrDni("12345679");

//var result = dp.GetPersons();


dp.Update(new Person()
{
    Id = 16,
    Name = "jose",
    BirthDate = new DateTime(2050, 10, 1),
    Dni = "88888",
});

//dp.Insert2("mierda");


//dp.GetPersonByDni("12345679");


Console.WriteLine("Hello, World!");

