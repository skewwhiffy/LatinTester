using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Base
{
  public interface IConjugation
  {
    string Get(Person person, Number number);
  }
}
