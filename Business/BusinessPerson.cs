using DAO;
using Entity;

namespace Business
{
    public class BusinessPerson
    {
        private DAOPerson _daoPerson;
        public BusinessPerson()
        {
            this._daoPerson = new DAOPerson();
        }
        public bool AddNewPerson(Person person)
        {
            bool exist = this._daoPerson.CheckIfPersonExistByDni(person.Dni);

            if (exist)
            {
                throw new Exception("DNI" + person.Dni + " exists already");
            }

            return this._daoPerson.Insert(person);

        }

        public bool DeletePersonByDni(string dni)
        {
            return this._daoPerson.Delete(dni);
        }

        public bool UpdatePerson(Person person)
        {
            return this._daoPerson.Update(person);
        }

        public Person ObtainPersonByDni(string dni)
        {
            var person = this._daoPerson.GetPersonByDni(dni);
            if (person == null)
            {
                throw new Exception("The person does not exist");
            }

            return person;
        }

        public List<Person> GetAllPersons()
        {
            // TODO: adds some filter in order to avoid retrieving bunch of unnecessary data
            // this will be aimed in the params

            return this._daoPerson.GetPersons();

        }

        public async Task<List<Person>> GetAllPersonsAsync() {
            // TODO: adds some filter in order to avoid retrieving bunch of unnecessary data
            // this will be aimed in the params
            return await this._daoPerson.GetPersonsAsync();
        }
    }
}