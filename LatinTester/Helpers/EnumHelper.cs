using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatinTester.Enums;
using LatinTester.Exceptions;

namespace LatinTester.Helpers
{
  public static class EnumHelper
  {
    #region Genders

    private readonly static Dictionary<Gender, String> GENDER_SHORT_STRINGS = new Dictionary<Gender, string>
      {
        {Gender.Masculine, "m"},
        {Gender.Feminine, "f"},
        {Gender.Neuter, "n"}
      };

    public static String ToShortString(this Gender gender)
    {
      if (GENDER_SHORT_STRINGS.ContainsKey(gender))
      {
        return GENDER_SHORT_STRINGS[gender];
      }
      throw new GenderNotRecognizedException();
    }

    #endregion
  }
}
