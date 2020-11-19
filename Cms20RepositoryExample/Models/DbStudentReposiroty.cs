using System.Collections.Generic;

namespace Cms20RepositoryExample.Models
{
    public class DbStudentReposiroty : IStudentRepository
    {
        public List<Student> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Student GetByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}