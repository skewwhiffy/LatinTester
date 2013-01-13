using System;
using System.Collections.Generic;
using LatinTester.Entities.Verbs.Conjugations.Base;
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
        throw new NotSupportedException(string.Format("unrecognised mood of sum : {0}", mood));
      }
      if (!CONJUGATIONS[mood].ContainsKey(voice))
      {
        throw new NotSupportedException(string.Format("unrecognised voice of sum : {0}", voice));
      }
      if (!CONJUGATIONS[mood][voice].ContainsKey(tense))
      {
        throw new NotSupportedException(string.Format("unrecognised tense of sum : {0}", tense));
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
                  {Tense.Present, new Conjugation("sum, es, est, sumus, estis, sunt")},
                  {Tense.Imperfect, new Conjugation("eram, eras, erat, eramus, eratis, erant")},
                  {Tense.Future, new Conjugation("ero, eris, erit, erimus, eritis, erunt")}
                }}
            }},
            {Mood.Subjunctive, new Dictionary<Voice, Dictionary<Tense, IConjugation>>
              {
                {Voice.Active, new Dictionary<Tense, IConjugation>
                  {
                    {Tense.Present, new Conjugation("sim, sis, sit, simus, sitis, sint")},
                    {Tense.Imperfect, new Conjugation("essem, esses, esset, essemus, essetis, essent")}
                  }}
              }}
        };

    #endregion
  }
}
