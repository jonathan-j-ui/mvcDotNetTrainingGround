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