using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms20RepositoryExample.Models
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student GetById(int id);
        Student GetByName(string name);
    }
}
