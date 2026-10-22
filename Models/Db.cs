namespace mvcDotNetTrainingGround.Models;

public class Db
{
    public Db()
    {
        Developers = new List<Developer>
        {
            new()
            {
                Id = 1,
                Name = "Stefan",
                Email = "Stefan@gmail.com"
            },
            new()
            {
                Id = 2,
                Name = "Malin",
                Email = "Malin123@gmail.com"
            }
        };
    }

    public List<Developer> Developers { get; set; }
}
