using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;



namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var movieStars = name1();
            if (movieStars != null)
            {
                //Console.WriteLine(movieStars);
                for (int i = 0; i < movieStars.Count; i++)
                {
                    Console.WriteLine(movieStars[i].Name + " " + movieStars[i].Surname);
                    Console.WriteLine(movieStars[i].Sex);
                    Console.WriteLine(movieStars[i].Nationality);
                    Console.WriteLine(movieStars[i].get_age(movieStars[i].dateOfBirth) + " years old");
                    Console.WriteLine("");

                }
            }
            else
                return;
        }

        static List<MovieStar> name1()
        {
            string path = @"N:\input.txt"; //Location may vary - in my personal case, it was in that spot

            if (File.Exists(path))
            {
                var movieStars = JsonConvert.DeserializeObject<List<MovieStar>>(File.ReadAllText(path));

#pragma warning disable CS8603 // Possible null reference return.
                return movieStars;
#pragma warning restore CS8603 // Possible null reference return.
            }
            else
                Console.WriteLine("File not found");
                return null;
        }
    }
}
