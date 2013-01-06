using System;
using System.Collections.Generic;
using LatinTester.Entities;
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
      //SetUpNouns1();
      //SetUpNouns2();
      SetUpNouns3();
    }

    private static void SetUpNouns1()
    {
      /*
       * aqua
       * causa
       * cena
       * copiae
       * cura
       * femina
       * filia
       * hora
       * ianua
       * luna
       * nauta
       * pecunia
       * provincia
       * Roma
       * terra
       * turba
       * via
       * victoria
       * villa
       * vita
       */
      _ones.Add(New1("puella", "puellae", "girl"));
    }

    private static void SetUpNouns2()
    {
      /*
       * QQ Probably more
       * ager agri
       * amicus
       * animus
       * annus
       * aurum
       * bellum
       * castra castrorum
       * cibus
       * consilium
       * deus
       * filius
       * forum
       * imperium
       * legatus
       * locus
       * modus
       * negotium
       * numerus
       * oculus
       * officium
       * oppidum
       * proelium
       * servus
       * signum
       * templum
       * verbum
       * vir viri
       */
    }

    private static void SetUpNouns3()
    {
      /*
       * civis civis
       * clamor clamoris
       * comes comitis
       * consul consulis
       * dux ducis
       * eques equitis
       * frater fratris
       * homo hominis
       * honor honoris
       * hospes hospitis
       * hostis hostis
       * ignis ignis
       * iudex iudicis
       * iuvenis iuvenis
       * opus operis
       * pes pedis
       * legio legionis
       * lex legis
       * libertas libertatis
       * mare maris
       * miles militis
       * mors mortis
       * mos moris
       * multitudo multitudinis
       * navis navis
       * nomen nominis
       * nox noctis
       * os oris
       * pater patris
       * pax pacis
       * pes pedis
       * princeps principis
       * rex regis
       * sacerdos sacerdotis
       * salus salutis
       * sanguis sanguinis
       * scelus sceleris
       * senex senis
       * sermo sermonis
       * sol solis
       * soror sororis
       * tempus temporis
       * urbs urbis
       * uxor uxoris
       * virtus virtutis
       * vis viris
       * vox vocis
       */

      _threes.Add(New3("caput", "capitis", "head", Gender.Neuter, false));
      _threes.Add(New3("civis", "civis", "citizen", Gender.Masculine, true));
      _threes.Add(New3("comes", "comitis", "comrade", Gender.Masculine, false));
      _threes.Add(New3("iuvenis", "iuventis", "young man", Gender.Masculine, true));
      _threes.Add(New3("ignis", "ignis", "fire", Gender.Feminine, true));
      _threes.Add(New3("iudex", "iudicis", "judge", Gender.Masculine, false));
      _threes.Add(New3("mors", "mortis", "death", Gender.Feminine, true));
      _threes.Add(New3("multitudo", "multitudinis", "crowd", Gender.Feminine, false));
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
