using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using mvcDotNetTrainingGround.Models;

namespace mvcDotNetTrainingGround.Controllers;

public class DeveloperController : Controller
{
    private Db _db;

    public DeveloperController(DbBatch db)
    {
        _db = db;
    }
}