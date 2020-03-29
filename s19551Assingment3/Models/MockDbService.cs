using s19551Assingment3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s19551Assingment3.Models
{
    public class MockDbService : IDbService
    {
        private static IEnumerable<Student> _students;

        static MockDbService()
        {
            _students = new List<Student> {
                new Student{Id=1, Name="Aram",Surname="Aramyan",IndexNumber="s1234" },
                new Student{Id=2, Name="Pogos",Surname="Pogosyan",IndexNumber="s1235" },
            };
        }
        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}
