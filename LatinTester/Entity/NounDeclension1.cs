using System;

namespace LatinTester.Entity
{
  public class NounDeclension1 : Noun
  {
    public NounDeclension1(string nominativeSingular, Gender gender = Gender.Feminine)
    {
      if (!nominativeSingular.EndsWith("a"))
      {
        throw new ArgumentException(string.Format("{0} is not a valid first declension noun", nominativeSingular));
      }
      _stem = nominativeSingular.Substring(0, nominativeSingular.Length - 1);
    }

    private readonly string _stem;
    private readonly Gender _gender;

    protected override string GetRegular(Case nounCase, Number number)
    {
      return string.Format("{0}{1}", _stem, GetEnding(nounCase, number));
    }

    protected string GetEnding(Case nounCase, Number number)
    {
      switch (number)
      {
        case Number.Singular:
          switch (nounCase)
          {
            case Case.Nominative:
              return "a";
            default:
              throw new NotImplementedException();
          }
        default:
          throw new NotImplementedException();
      }
    }

    public override Gender Gender
    {
      get { return _gender; }
    }
  }
}
