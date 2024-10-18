namespace Backend.Controllers
{
    public class Repository
    {
        public static List<PersonaDatos> persona = new List<PersonaDatos>
        {
            new PersonaDatos()
            {
                id = 1,
                age = new DateTime(2003,11,07),
                name = "Harry Styles"
            },
            new PersonaDatos()
            {
                id = 2,
                age = new DateTime(2003,09,07),
                name = "Niall Horan"
            },
            new PersonaDatos()
            {
                id = 3,
                age = new DateTime(2003,10,07),
                name = "Liam Payne"
            },
            new PersonaDatos()
            {
                id = 4,
                age = new DateTime(2003,06,07),
                name = "Louis Tomlinson"
            },
            new PersonaDatos()
            {
                id = 5,
                age = new DateTime(2003,02,07),
                name = "Zayn Malik"
            }
        };

    }

    public class PersonaDatos
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime age { get; set; }
        public int email { get; set;}
    }
}
