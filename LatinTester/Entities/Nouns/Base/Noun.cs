using System;
using System.Collections.Generic;
using LatinTester.Entities.PrincipalParts;
using LatinTester.Enums;
using LatinTester.Helpers;

namespace LatinTester.Entities.Nouns.Base
{
  public abstract class Noun
  {
    public string English { get; set; }

    public NounPrincipalParts PrincipalParts
    {
      get { return new NounPrincipalParts(Get(Case.Nominative, Number.Singular), Get(Case.Genitive, Number.Singular)); }
    }

    public string Get(Case nounCase, Number number)
    {
      if (Overrides.ContainsKey(nounCase) && Overrides[nounCase].ContainsKey(number))
      {
        return Overrides[nounCase][number];
      }
      return GetRegular(nounCase, number);
    }

    public void Override(Case nounCase, Number number, String value)
    {
      value = value.ToLowerInvariant();
      if (value == GetRegular(nounCase, number))
      {
        DeleteOverride(nounCase, number);
        return;
      }
      if (!Overrides.ContainsKey(nounCase))
      {
        Overrides.Add(nounCase, new Dictionary<Number, string>());
      }
      Overrides[nounCase][number] = value;
    }

    public void DeleteOverride(Case nounCase, Number number)
    {
      if (!Overrides.ContainsKey(nounCase) || !Overrides[nounCase].ContainsKey(number))
      {
        return;
      }
      Overrides[nounCase].Remove(number);
    }

    protected abstract string GetRegular(Case nounCase, Number number);

    public abstract Gender Gender { get; }

    private readonly Dictionary<Case, Dictionary<Number, string>> _overrides = new Dictionary<Case, Dictionary<Number, string>>();
    protected Dictionary<Case, Dictionary<Number, string>> Overrides
    {
      get { return _overrides; }
    }

    public override string ToString()
    {
      return string.Format("{0}, {1}, '{2}'", PrincipalParts, Gender.ToShortString(), English);
    }
  }
}
