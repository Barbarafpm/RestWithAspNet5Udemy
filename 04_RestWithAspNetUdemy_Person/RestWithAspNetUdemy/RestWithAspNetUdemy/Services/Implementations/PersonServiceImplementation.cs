using RestWithASPNETUdemy.Model;
using System.Collections.Generic;
using System.Threading;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        // Contador responsável por gerar um ID falso
        //  já que não estamos acessando nenhum banco de dados
        private volatile int count;

        // Method responsible for creating a new person.
        // If we had a database this would be the time to persist the data
        public Person Create(Person person)
        {
            return person;
        }

        // Método responsável por excluir uma pessoa de um ID
        public void Delete(long id)
        {
            // Nossa lógica de exclusão viria aqui
        }

        // Método responsável por criar uma nova pessoa,
        // Se tivéssemos um banco de dados este seria o momento de persistir os dados
        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        //Método responsável por retornar uma pessoa
        // como não acessamos nenhum banco de dados estamos retornando um mock
        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Leandro",
                LastName = "Costa",
                Address = "Uberlandia - Minas Gerais - Brasil",
                Gender = "Male"
            };
        }

        // Método responsável por atualizar uma pessoa para
        // sendo mock retornamos a mesma informação passada
        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Address = "Some Address" + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
