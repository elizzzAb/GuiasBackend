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
                name = "Elizabeth Abrego"
            },
            new PersonaDatos()
            {
                id = 1,
                age = new DateTime(2003,11,07),
                name = "Elizabeth Abrego"
            },
            new PersonaDatos()
            {
                id = 1,
                age = new DateTime(2003,11,07),
                name = "Elizabeth Abrego"
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
