using System;
using System.Collections.Generic;
using System.Linq;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Base
{
  public class ConjugationEndings : Dictionary<Number, Dictionary<Person, string>>
  {
    public ConjugationEndings(string endingsCsv)
    {
      List<string> endings = endingsCsv.Split(',').Select(e => e.Trim().ToLowerInvariant()).ToList();
      if (endings.Count != 6)
      {
        throw new NotSupportedException("Cannot instantiate endings with count not equal to six");
      }
      AddEntries(endings[0], endings[1], endings[2], endings[3], endings[4], endings[5]);
    }
    
    public ConjugationEndings(string e0, string e1, string e2, string e3, string e4, string e5)
    {
      AddEntries(e0, e1, e2, e3, e4, e5);
    }

    private void AddEntries(string e0, string e1, string e2, string e3, string e4, string e5)
    {
      Add(Number.Singular, new Dictionary<Person, string>
        {
          {Person.First, e0},
          {Person.Second, e1},
          {Person.Third, e2}
        });
      Add(Number.Plural, new Dictionary<Person, string>
        {
          {Person.First, e3},
          {Person.Second, e4},
          {Person.Third, e5}
        });
    }
  }
}
