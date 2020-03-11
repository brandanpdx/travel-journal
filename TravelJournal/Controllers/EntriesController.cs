using Microsoft.AspNetCore.Mvc; 
using TravelJournal.Models; 
using System.Collections.Generic; 

namespace TravelJournal.Controllers
{
  public class EntriesController : Controllers
  {
    [HttpGet("/entries")]
    public ActionResult Index()
    {
      List<Entry> allEntries = Entry.GetAll();
      return View(allEntries);
    }
    [HttpGet("/entries/new")]
    public ActionResult New()
    {
      return View();
    }
    
  }
}