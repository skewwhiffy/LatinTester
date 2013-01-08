using LatinTester.Entities.PrincipalParts;
using LatinTester.Enums;

namespace LatinTester.Entities.Base
{
  public interface IConjugation
  {
    string Get(Person person, Number number);
  }
}
