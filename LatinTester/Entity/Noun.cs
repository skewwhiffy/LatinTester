using System;
using System.Collections.Generic;

namespace LatinTester.Entity
{
  public abstract class Noun
  {
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
  }
}
