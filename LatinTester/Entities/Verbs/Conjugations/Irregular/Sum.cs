using System;
using System.Collections.Generic;
using LatinTester.Entities.Base;
using LatinTester.Enums;

namespace LatinTester.Entities.Verbs.Conjugations.Irregular
{
  public static class Sum
  {
    #region Facade

    public static IConjugation Get(Mood mood, Voice voice, Tense tense)
    {
      if (!CONJUGATIONS.ContainsKey(mood))
      {
        throw new NotSupportedException(string.Format("unrecognised mood : {0}", mood));
      }
      if (!CONJUGATIONS[mood].ContainsKey(voice))
      {
        throw new NotSupportedException(string.Format("unrecognised voice : {0}", voice));
      }
      if (!CONJUGATIONS[mood][voice].ContainsKey(tense))
      {
        throw new NotSupportedException(string.Format("unrecognised tense : {0}", tense));
      }
      return CONJUGATIONS[mood][voice][tense];
    }

    #endregion

    #region

    private static readonly Dictionary<Mood, Dictionary<Voice, Dictionary<Tense, IConjugation>>> CONJUGATIONS
      = new Dictionary<Mood, Dictionary<Voice, Dictionary<Tense, IConjugation>>>
        {
          {Mood.Indicative, new Dictionary<Voice, Dictionary<Tense, IConjugation>> 
            {
              {Voice.Active, new Dictionary<Tense, IConjugation>
                {
                  {Tense.Present, new Conjugation("sum, es, est, sumus, estis, sunt")}
                }}
            }}
        };

    #endregion
  }
}
