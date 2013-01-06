using System;
using System.Collections.Generic;
using System.Linq;
using LatinTester.Entities.Base;
using LatinTester.Enums;

namespace LatinTesterTest.Entities.Verbs.Conjugations.Base
{
  public abstract class ConjugationTestBase
  {
    protected bool ConjugationWorks(
      IConjugation conj,
      string sing1,
      string sing2,
      string sing3,
      string plu1,
      string plu2,
      string plu3)
    {
      var lookup
        = new Dictionary<Tuple<Person, Number>, string>
          {
            {new Tuple<Person, Number>(Person.First, Number.Singular), sing1},
            {new Tuple<Person, Number>(Person.Second, Number.Singular), sing2},
            {new Tuple<Person, Number>(Person.Third, Number.Singular), sing3},
            {new Tuple<Person, Number>(Person.First, Number.Plural), plu1},
            {new Tuple<Person, Number>(Person.Second, Number.Plural), plu2},
            {new Tuple<Person, Number>(Person.Third, Number.Plural), plu3},
          };
      return lookup.All(kvp => Agrees(conj, kvp.Key.Item1, kvp.Key.Item2, kvp.Value));
    }

    protected bool Agrees(IConjugation conj, Person person, Number number, string value)
    {
      return conj.Get(person, number) == value;
    }
  }
}
