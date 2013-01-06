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

    private NounRepository()
    {
    }

    #endregion

    #region Repository methods

    private readonly Random _random = new Random();

    public Noun RandomNoun
    {
      get { return AllNouns[_random.Next(AllNouns.Count)]; }
    }

    #endregion

    #region Nouns

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
      SetUpNouns1();
      //SetUpNouns2();
      //SetUpNouns3();
      //SetUpNouns4();
      //SetUpNouns5();
    }

    #region Declension 1

    private static void SetUpNouns1()
    {
      _ones.Add(New1("aqua", "water"));
      _ones.Add(New1("causa", "cause"));
      _ones.Add(New1("cena", "dinner"));
      _ones.Add(New1("copia", "supply"));
      _ones.Add(New1("cura", "care"));
      _ones.Add(New1("femina", "woman"));
      _ones.Add(New1("filia", "daughter"));
      _ones.Add(New1("hora", "hour"));
      _ones.Add(New1("ianua", "door"));
      _ones.Add(New1("luna", "moon"));
      _ones.Add(New1("nauta", "sailor", Gender.Masculine));
      _ones.Add(New1("pecunia", "money"));
      _ones.Add(New1("provincia", "province"));
      _ones.Add(New1("puella", "girl"));
      _ones.Add(New1("Roma", "Rome"));
      _ones.Add(New1("terra", "earth"));
      _ones.Add(New1("turba", "disorder"));
      _ones.Add(New1("via", "road"));
      _ones.Add(New1("victoria", "victory"));
      _ones.Add(New1("villa", "house"));
      _ones.Add(New1("vita", "life"));
    }

    private static NounDeclension1 New1(
      string nominativeSingular,
      string english,
      Gender gender = Gender.Feminine)
    {
      return New1(nominativeSingular, string.Format("{0}e", nominativeSingular), english, gender);
    }

    private static NounDeclension1 New1(
      string nominativeSingular,
      string genitiveSingular,
      string english,
      Gender gender = Gender.Feminine)
    {
      return new NounDeclension1(new NounPrincipalParts(nominativeSingular, genitiveSingular), english, gender);
    }

    #endregion

    #region Declension 2

    private static void SetUpNouns2()
    {
      // QQ Cope with:
      // castra castrorum http://en.wiktionary.org/wiki/castra
      // deus http://en.wiktionary.org/wiki/deus#Latin
      _twos.Add(New2("ager", "agri", "field"));
      _twos.Add(New2("amicus", "friend"));
      _twos.Add(New2("animus", "mind"));
      _twos.Add(New2("annus", "year"));
      _twos.Add(New2("aurum", "gold"));
      _twos.Add(New2("auxilium", "help"));
      _twos.Add(New2("bellum", "war"));
      _twos.Add(New2("cibus", "food"));
      _twos.Add(New2("consilium", "council"));
      _twos.Add(New2("equus", "horse"));
      _twos.Add(New2("filius", "son"));
      _twos.Add(New2("forum", "court"));
      _twos.Add(New2("imperium", "empire"));
      _twos.Add(New2("legatus", "ambassador"));
      _twos.Add(New2("locus", "place"));
      _twos.Add(New2("modus", "measure"));
      _twos.Add(New2("negotium", "business"));
      _twos.Add(New2("numerus", "number"));
      _twos.Add(New2("nuntius", "messenger"));
      _twos.Add(New2("oculus", "eye"));
      _twos.Add(New2("officium", "service"));
      _twos.Add(New2("oppidum", "town"));
      _twos.Add(New2("periculum", "danger"));
      _twos.Add(New2("populus", "people"));
      _twos.Add(New2("proelium", "battle"));
      _twos.Add(New2("puer", "pueri", "boy"));
      _twos.Add(New2("servus", "slave"));
      _twos.Add(New2("signum", "sign"));
      _twos.Add(New2("templum", "temple"));
      _twos.Add(New2("verbum", "word"));
      _twos.Add(New2("vir", "viri", "man"));
    }

    private static NounDeclension2 New2(
      string nominativeSingular,
      string english)
    {
      return New2(nominativeSingular, nominativeSingular.Substring(nominativeSingular.Length - 2) + "i", english);
    }

    private static NounDeclension2 New2(
      string nominativeSingular,
      string genitiveSingular,
      string english)
    {
      return new NounDeclension2(new NounPrincipalParts(nominativeSingular, genitiveSingular), english);
    }

    #endregion

    #region Declension 3

    private static void SetUpNouns3()
    {
      // QQ Deal with vis, http://en.wiktionary.org/wiki/vis#Latin
      _threes.Add(New3("caput", "capitis", "head", Gender.Neuter, false));
      _threes.Add(New3("civis", "civis", "citizen", Gender.Masculine, true));
      _threes.Add(New3("comes", "comitis", "comrade", Gender.Masculine, false));
      _threes.Add(New3("consul", "consulis", "consul", Gender.Masculine, false));
      _threes.Add(New3("dux", "ducis", "leader", Gender.Masculine, false));
      _threes.Add(New3("eques", "equitis", "horseman", Gender.Masculine, false));
      _threes.Add(New3("frater", "fratris", "brother", Gender.Masculine, false));
      _threes.Add(New3("homo", "hominis", "man", Gender.Masculine, false));
      _threes.Add(New3("honor", "honoris", "honour", Gender.Masculine, false));
      _threes.Add(New3("hospes", "hospitis", "host", Gender.Masculine, false));
      _threes.Add(New3("hostis", "hostis", "enemy", Gender.Masculine, true));
      _threes.Add(New3("ignis", "ignis", "fire", Gender.Feminine, true));
      _threes.Add(New3("iudex", "iudicis", "judge", Gender.Masculine, false));
      _threes.Add(New3("iuvenis", "iuventis", "young man", Gender.Masculine, true));
      _threes.Add(New3("legio", "legionis", "legion", Gender.Feminine, false));
      _threes.Add(New3("lex", "legis", "law", Gender.Feminine, false));
      _threes.Add(New3("libertas", "libertatis", "freedom", Gender.Feminine, false));
      _threes.Add(New3("mare", "maris", "sea", Gender.Neuter, true));
      _threes.Add(New3("miles", "militis", "soldire", Gender.Masculine, false));
      _threes.Add(New3("mors", "mortis", "death", Gender.Feminine, true));
      _threes.Add(New3("mos", "moris", "custom", Gender.Masculine, false));
      _threes.Add(New3("multitudo", "multitudinis", "crowd", Gender.Feminine, false));
      _threes.Add(New3("navis", "navis", "ship", Gender.Feminine, true));
      _threes.Add(New3("nomen", "nominis", "name", Gender.Neuter, false));
      _threes.Add(New3("nox", "noctis", "ENGLISH", Gender.Feminine, true));
      _threes.Add(New3("opus", "operis", "work", Gender.Neuter, false));
      _threes.Add(New3("os", "oris", "mouth", Gender.Neuter, false));
      _threes.Add(New3("pater", "patris", "father", Gender.Masculine, false));
      _threes.Add(New3("pax", "pacis", "peace", Gender.Feminine, false));
      _threes.Add(New3("pes", "pedis", "foot", Gender.Masculine, false));
      _threes.Add(New3("princeps", "principis", "leader", Gender.Masculine, false));
      _threes.Add(New3("rex", "regis", "king", Gender.Masculine, false));
      _threes.Add(New3("sacerdos", "sacerdotis", "priest", Gender.Masculine, false));
      _threes.Add(New3("salus", "salutis", "health", Gender.Feminine, false));
      _threes.Add(New3("sanguis", "sanguinis", "mouth", Gender.Masculine, false));
      _threes.Add(New3("scelus", "sceleris", "crime", Gender.Neuter, false));
      _threes.Add(New3("senex", "senis", "old man", Gender.Masculine, true));
      _threes.Add(New3("sermo", "sermonis", "conversation", Gender.Masculine, false));
      _threes.Add(New3("sol", "solis", "sun", Gender.Masculine, false));
      _threes.Add(New3("soror", "sororis", "sister", Gender.Feminine, false));
      _threes.Add(New3("tempus", "temporis", "time", Gender.Neuter, false));
      _threes.Add(New3("urbs", "urbis", "city", Gender.Feminine, true));
      _threes.Add(New3("uxor", "uxoris", "wife", Gender.Feminine, false));
      _threes.Add(New3("virtus", "virtutis", "bravery", Gender.Feminine, false));
      _threes.Add(New3("vox", "vocis", "voice", Gender.Feminine, false));
    }

    private static NounDeclension3 New3(string nominativeSingular, string genitiveSingular, string english, Gender gender, bool iStem)
    {
      return new NounDeclension3(new NounPrincipalParts(nominativeSingular, genitiveSingular), english, gender, iStem);
    }

    #endregion

    #region Declension 4

    private static void SetUpNouns4()
    {
      _fours.Add(New4("domus", "house", Gender.Feminine));
      _fours.Add(New4("exercitus", "army", Gender.Masculine));
      _fours.Add(New4("impetus", "attack", Gender.Masculine));
      _fours.Add(New4("manus", "hand", Gender.Feminine));
      _fours.Add(New4("metus", "fear", Gender.Masculine));
      _fours.Add(New4("portus", "harbour", Gender.Masculine));
      _fours.Add(New4("senatus", "senate", Gender.Masculine));
    }

    private static NounDeclension4 New4(string nominativeSingular, string english, Gender gender)
    {
      return new NounDeclension4(new NounPrincipalParts(nominativeSingular, nominativeSingular), english, gender);
    }

    #endregion

    #region Declension 5

    private static void SetUpNouns5()
    {
      _fives.Add(New5("dies", "day"));
      _fives.Add(New5("fides", "faith"));
      _fives.Add(New5("res", "thing"));
      _fives.Add(New5("spes", "hope"));
    }

    private static NounDeclension5 New5(string nominativeSingular, string english, Gender gender = Gender.Feminine)
    {
      return
        new NounDeclension5(
          new NounPrincipalParts(nominativeSingular,
                                 nominativeSingular.Substring(0, nominativeSingular.Length - 1) + "i"),
                                 english,
                                 gender);
    }

    #endregion

    #endregion
  }
}
