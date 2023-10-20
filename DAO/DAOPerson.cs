using Entity;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Net;
using System.Text;

namespace DAO
{

    public class DAOPerson
    {
        public static readonly string IdColumn = "Id";
        public static readonly string NameColumn = "Name";
        public static readonly string DniColumn = "Dni";
        public static readonly string BirthDateColumn = "BirthDate";

        public List<Person> GetPersons()
        {
            string query = "SELECT * FROM Persons";

            var result = new List<Person>();
            var dt = Connection.ExecuteReader(query);

            foreach (DataRow item in dt.Rows)
            {
                result.Add(new Person()
                {
                    Id = int.Parse(item[IdColumn].ToString()!),
                    Name = item[NameColumn].ToString()!,
                    Dni = item[DniColumn].ToString()!,
                    BirthDate = DateTime.Parse(item[BirthDateColumn].ToString()!),
                });
            }

            return result;
        }

        public async Task<List<Person>> GetPersonsAsync()
        {
            string query = "SELECT * FROM Persons";

            var result = new List<Person>();
            var dt = await Connection.ExecuteReaderAsync(query);

            foreach (DataRow item in dt.Rows)
            {
                result.Add(new Person()
                {
                    Id = int.Parse(item[IdColumn].ToString()!),
                    Name = item[NameColumn].ToString()!,
                    Dni = item[DniColumn].ToString()!,
                    BirthDate = DateTime.Parse(item[BirthDateColumn].ToString()!),
                });
            }

            return result;
        }

        public Person? GetPersonByDni(string dni)
        {
            string query = "SELECT Id, Name, Dni, BirthDate FROM Persons WHERE Dni=?";

            OleDbParameter[] oleParams = {
                new OleDbParameter("@dni", dni),
            };

            var dt = Connection.ExecuteReader(query, oleParams);

            if (dt == null)
            {
                return null;
            }

            var item = dt.Rows[0];
            return new Person()
            {
                Id = int.Parse(item[IdColumn].ToString()!),
                Name = item[NameColumn].ToString()!,
                Dni = item[DniColumn].ToString()!,
                BirthDate = DateTime.Parse(item[BirthDateColumn].ToString()!),
            };
        }

        public bool Delete(string dni)
        {
            string query = "DELETE FROM Persons WHERE Dni=?";

            OleDbParameter[] oleParams = {
                new OleDbParameter("@dni", dni)
            };

            return Connection.ExecuteNonQuery(query, oleParams);
        }

        public bool Insert(Person person)
        {
            string query = "INSERT INTO Persons (Name, Dni, BirthDate) VALUES (?, ?, ?)";

            OleDbParameter[] oleParams = {
                new OleDbParameter("@name", person.Name),
                new OleDbParameter("@dni", person.Dni),
                new OleDbParameter("@birthdate", person.BirthDate.ToShortDateString()),
            };

            return Connection.ExecuteNonQuery(query, oleParams);
        }

        public bool Update(Person person)
        {
            string query = "UPDATE Persons SET Name=?, Dni=?, BirthDate=? WHERE Id=?";

            OleDbParameter[] oleParams = {
                new OleDbParameter("@name", person.Name),
                new OleDbParameter("@dni", person.Dni),
                new OleDbParameter("@birthname", person.BirthDate),
                new OleDbParameter("@i", person.Id),
            };

            return Connection.ExecuteNonQuery(query, oleParams);
        }

        public bool CheckIfPersonExistByDni(string dni)
        {
            string query = "SELECT 1 FROM Persons WHERE Dni=@dni";

            OleDbParameter[] oleParams = { new OleDbParameter("@dni", dni) };

            var dt = Connection.ExecuteReader(query, oleParams);

            return dt.Rows.Count > 0;
        }
    }
}
