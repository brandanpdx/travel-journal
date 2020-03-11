using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TravelJournal.Models;
using System;

namespace TravelJournal.Tests 
{
  [TestClass]
  public class EntryTests : IDisposable
  {
    public void Dispose()
    {
      Entry.ClearAll();
    }
    [TestMethod]
    public void EntryConstructor_CreatesInstance_NewEntry()
    {
      Entry newEntry = new Entry("Paris", "June 5, 2019", 6, "Drake, Fatma, and Jieun", "We had a great time and ate snails");
      Assert.AreEqual(typeof(Entry), newEntry.GetType());
    }
    [TestMethod]
    public void EntryConstructor_ReturnsLocation_Location()
    {
      
      Entry newEntry = new Entry("Paris", "June 5, 2019", 6, "Drake, Fatma, and Jieun", "We had a great time and ate snails");

      string result = newEntry.Location;

      Assert.AreEqual("Paris", result);
    }
  }
}