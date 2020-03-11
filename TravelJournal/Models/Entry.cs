using System;
namespace TravelJournal.Models
{
  public class Entry
  { 
    public string Location { get; set; }
    public string Date { get; set; }
    public int Days { get; set; }
    public string TravelPartners { get; set; }
    public string JournalEntry { get; set; }
    public int Id { get; }
    private static List<Entry> _instances = new List<Entry> {};

    public Entry(string location, string date, int days, string travelPartners, string journalEntry)
    {
      Location = location;
      Date = date; 
      Days = days; 
      TravelPartners = travelPartners; 
      JournalEntry = journalEntry; 
      _instances.Add(this);
      Id = _instances.Count; 
    }

    public static List<Item> GetAll()
    {
      if (_instances.Count == 0)
      {
        Console.WriteLine("No Entries Found");
      }
      return _instances; 
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Item Find(int searchId)
    {
      return _instances[searchId - 1];
    }
                              
  }
}