using System;
using System.Collections.Generic;
using System.Linq;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Entities.Verbs.Conjugations.Base;
using LatinTester.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatinTesterTest.Entities.Verbs.Conjugations.TestBase
{
  public abstract class ConjugationTestBase
  {
    protected readonly static VerbPrincipalParts INVALID =
      new VerbPrincipalParts("doesNotEndInOActually", "notAnInfinitive", "notAPerfect", "notASupine");

    protected static readonly VerbPrincipalParts AMO =
      new VerbPrincipalParts("amo", "amare", "amavi", "amatum");
    protected static readonly VerbPrincipalParts HABEO =
      new VerbPrincipalParts("habeo", "habere", "habui", "habitum");

    protected static readonly VerbPrincipalParts MITTO =
      new VerbPrincipalParts("mitto", "mittere", "misi", "missum");

    protected static readonly VerbPrincipalParts CAPIO =
      new VerbPrincipalParts("capio", "capere", "cepi", "captum");

    protected static readonly VerbPrincipalParts AUDIO =
      new VerbPrincipalParts("audio", "audire", "audivi", "auditum");

    private static string ConjugationWorks(IConjugation conj, string expected)
    {
      List<string> expectedSplit = expected.Split(',').Select(e => e.Trim().ToLowerInvariant()).ToList();
      return ConjugationWorks(
        conj,
        expectedSplit[0],
        expectedSplit[1],
        expectedSplit[2],
        expectedSplit[3],
        expectedSplit[4],
        expectedSplit[5]);
    }

    private static string ConjugationWorks(
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
      return string.Join("; ",
                         lookup
                           .Where(kvp => !Agrees(conj, kvp.Key.Item1, kvp.Key.Item2, kvp.Value))
                           .Select(
                             kvp =>
                             string.Format("Expected '{0}', but got '{1}'", kvp.Value,
                                           conj.Get(kvp.Key.Item1, kvp.Key.Item2))));
    }

    protected static bool Agrees(IConjugation conj, Person person, Number number, string value)
    {
      return conj.Get(person, number) == value;
    }

    protected static void AssertConjugationWorks(IConjugation conj, string expected)
    {
      Assert.AreEqual("", ConjugationWorks(conj, expected));
    }
  }
}
