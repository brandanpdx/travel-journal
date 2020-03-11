using Microsoft.AspNetCore.Mvc; 
using TravelJournal.Models; 
using System.Collections.Generic; 

namespace TravelJournal.Controllers
{
  public class EntriesController : Controller
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
    [HttpPost("/entries")]
    public ActionResult Create(string location, string date, int days, string travelPartners, string journalEntry)
    {
      Entry newEntry = new Entry(location, date, days, travelPartners, journalEntry);
      return RedirectToAction("Index");
    }

  }
}