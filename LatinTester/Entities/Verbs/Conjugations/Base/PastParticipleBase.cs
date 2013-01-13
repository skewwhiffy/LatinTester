using System;
using CsharpUtils;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Base
{
  public abstract class PastParticipleBase : IConjugation
  {
    private readonly string _stem;

    protected PastParticipleBase(VerbPrincipalParts parts)
    {
      string pastParticiple = parts.Supine;
      if (!pastParticiple.EndsWithOneOf("us", "um"))
      {
        throw new NotSupportedException(string.Format("Past participle '{0}' does not end in 'um' or 'us'",
                                                      pastParticiple));
      }
      _stem = pastParticiple.TruncateLastChars(2);
    }

    protected abstract IConjugation AuxiliaryVerb { get; }

    public string Get(Person person, Number number)
    {
      return string.Format("{0}{1} {2}", _stem, number == Number.Singular ? "us": "i", AuxiliaryVerb.Get(person, number));
    }
  }
}
