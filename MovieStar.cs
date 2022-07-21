using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    [Serializable]
    internal class MovieStar
    {
        public string? dateOfBirth { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Sex { get; set; }
        public string? Nationality { get; set; }

        public int get_age(string dateOfBirth)
        {
            DateTime dob = Convert.ToDateTime(dateOfBirth);
            int age = 0;
            age = DateTime.Now.AddYears(-dob.Year).Year;
            return age;
        }
        /*
        public MovieStar(string aDateOfBirth, string aName, string aSurname, string aSex, string aNationality)
        {
            dateOfBirth = aDateOfBirth;
            name = aName;
            surname = aSurname;
            sex = aSex;
            nationality = aNationality;
        }
        */
    }
}
