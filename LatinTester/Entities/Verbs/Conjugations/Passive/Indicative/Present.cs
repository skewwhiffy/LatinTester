using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpUtils;
using LatinTester.Entities.Base;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Entities.Verbs.Conjugations.Base;
using LatinTester.Enums;
using LatinTester.Helpers;

namespace LatinTester.Entities.Verbs.Conjugations.Passive.Indicative
{
  public class Present : IConjugation
  {
    private readonly string _stem;
    private readonly string _firstSingularInfix;
    private readonly string _secondSingularInfix;

    private Present(
      string stem,
      string firstSingularInfix,
      string secondSingularInfix = null,
      string usualInfix = null,
      string thirdPluralInfix = null)
    {
      _stem = stem;
      _firstSingularInfix = firstSingularInfix;
      _secondSingularInfix = secondSingularInfix;
    }

    public static IConjugation Get1(VerbPrincipalParts parts)
    {
      return new Present(parts.Present.TruncateLastChars(1), "", "a");
    }

    public static IConjugation Get2(VerbPrincipalParts parts)
    {
      throw new NotImplementedException();
    }

    public static IConjugation Get3(VerbPrincipalParts parts)
    {
      throw new NotImplementedException();
    }

    public static IConjugation Get4(VerbPrincipalParts parts)
    {
      throw new NotImplementedException();
    }

    public string Get(Person person, Number number)
    {
      return string.Format("{0}{1}{2}", _stem, GetInfix(person, number), ENDINGS.Ending(person, number));
    }

    public string GetInfix(Person person, Number number)
    {
      if (person == Person.First && number == Number.Singular)
      {
        return _firstSingularInfix;
      }
      return _secondSingularInfix;
    }

    private static readonly ConjugationEndings ENDINGS = new ConjugationEndings("or, ris, tur, mur, mini, ntur");
  }
}
