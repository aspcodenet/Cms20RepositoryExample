using System.Collections.Generic;
using System.Linq;

namespace Cms20RepositoryExample.Models
{
    public class FakeStudentRepository : IStudentRepository
    {
        public List<Student> GetAll()
        {
            var l = new List<Student>();
            l.Add(new Student { Age=12,Id=1,Name="Stefan" });
            l.Add(new Student { Age = 13, Id = 2, Name = "Oliver" });
            l.Add(new Student { Age = 14, Id = 3, Name = "Josefine" });
            return l;
        }

        public Student GetById(int id)
        {
            return GetAll().FirstOrDefault(r => r.Id == id);
        }

        public Student GetByName(string name)
        {
            return GetAll().FirstOrDefault(r => r.Name == name);
        }
    }
}