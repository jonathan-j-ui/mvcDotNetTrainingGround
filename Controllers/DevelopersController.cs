using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using mvcDotNetTrainingGround.Models;

namespace mvcDotNetTrainingGround.Controllers;

public class DeveloperController : Controller
{
    private Db _db;

    public DeveloperController(Db db)
    {
        _db = db;
    }
}

public class Db
{
    public Db()
    {
        Developers = new List<Developer>()
        {
            new Developer{
            Id = 1, 
            Name = "Stefan",
            Email = "Stefan@gmail.com"
            },
            new Developer{
            Id = 2, 
            Name = "Malin",
            Email = "Malin123@gmail.com"
            }
        };
    }

    public List<Developer> Developers { get; set; }
}