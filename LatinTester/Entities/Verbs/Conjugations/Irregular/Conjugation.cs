using LatinTester.Entities.Base;
using LatinTester.Entities.Verbs.Conjugations.Base;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Irregular
{
  public class Conjugation : IConjugation
  {
    private readonly ConjugationEndings _conjugation;

    public Conjugation(string partsCsv)
    {
      _conjugation = new ConjugationEndings(partsCsv);
    }

    public string Get(Person person, Number number)
    {
      return _conjugation.Ending(person, number);
    }
  }
}
