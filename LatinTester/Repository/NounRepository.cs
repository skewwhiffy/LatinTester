using System;
using System.Collections.Generic;
using LatinTester.Entity;
using LatinTester.Enums;

namespace LatinTester.Repository
{
  public class NounRepository
  {
    #region Singleton

    static NounRepository()
    {
      Singleton = new NounRepository();
      SetUpNouns();
    }

    public static NounRepository Singleton { get; private set; }
    private NounRepository(){ }

    #endregion

    #region Repository methods

    private readonly Random _random = new Random();
    public Noun RandomNoun
    {
      get
      {
        return AllNouns[_random.Next(AllNouns.Count)];
      }
    }

    #endregion

    #region

    // Not readonly...
    private static List<NounDeclension1> _ones = new List<NounDeclension1>();
    private static List<NounDeclension2> _twos = new List<NounDeclension2>();
    private static List<NounDeclension3> _threes = new List<NounDeclension3>();
    private static List<NounDeclension4> _fours = new List<NounDeclension4>();
    private static List<NounDeclension5> _fives = new List<NounDeclension5>();
    private static List<Noun> _allNouns; 
    private static List<Noun> AllNouns
    {
      get
      {
        if (_allNouns == null)
        {
          _allNouns = new List<Noun>();
          Action<Noun> action = n => _allNouns.Add(n);
          _ones.ForEach(action);
          _twos.ForEach(action);
          _threes.ForEach(action);
          _fours.ForEach(action);
          _fives.ForEach(action);
        }
        return _allNouns;
      }
    } 

    private static void SetUpNouns() // QQ load from disk
    {
      _ones.Add(New1("puella", "puellae", "girl"));
      _threes.Add(New3("comes", "comitis", "comrade", Gender.Masculine, false));
      _threes.Add(New3("caput", "capitis", "head", Gender.Neuter, false));
      _threes.Add(New3("iuvenis", "iuventis", "young man", Gender.Masculine, true));
      _threes.Add(New3("iudex", "iudicis", "judge", Gender.Masculine, false));
      _threes.Add(New3("mors", "mortis", "death", Gender.Feminine, true));
      _threes.Add(New3("multitudo", "multitudinis", "crowd", Gender.Feminine, false));
      _threes.Add(New3("civis", "civis", "citizen", Gender.Masculine, true));
      _threes.Add(New3("ignis", "ignis", "fire", Gender.Feminine, true));
      _threes.Add(New3("os", "oris", "mouth", Gender.Neuter, false));
      _threes.Add(New3("sanguis", "sanguinis", "mouth", Gender.Masculine, false));
    }

    private static NounDeclension1 New1(string nominativeSingular, string genitiveSingular, string english, Gender gender = Gender.Feminine)
    {
      return new NounDeclension1(new NounPrincipalParts(nominativeSingular, genitiveSingular), english, gender);
    }

    private static NounDeclension3 New3(string nominativeSingular, string genitiveSingular, string english, Gender gender, bool iStem)
    {
      return new NounDeclension3(new NounPrincipalParts(nominativeSingular, genitiveSingular), english, gender, iStem);
    }

    #endregion
  }
}
