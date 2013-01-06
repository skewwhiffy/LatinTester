using System;
using System.Collections.Generic;
using System.Linq;
using CsharpUtils;
using LatinTester.Enums;
using LatinTester.Repository;

namespace LatinTester.Entities
{
  public class NounTestQuestion
  {
    private static readonly NounRepository REPO = NounRepository.Singleton;

    public List<Noun> Nouns { get; private set; }
    public Case Case { get; private set; }
    public List<Case> Cases { get; private set; } 

    public NounTestQuestion()
    {
      Nouns = new List<Noun>();
      for (int i = 0; i < 10; i ++) // QQ 10 should be configurable
      {
        Nouns.Add(REPO.RandomNoun); // QQ Config groups, cases etc.
      }
      var random = new Random();
      List<Case> cases = EnumHelper.GetValues<Case>();
      Case = cases[random.Next(cases.Count)];
      Cases = Nouns.Select(n => RandomHelper.NextFairCoin ? Case : cases[random.Next(cases.Count)]).ToList();
      if (!Cases.Contains(Case))
      {
        Cases[random.Next(Cases.Count)] = Case;
      }
    }
  }
}
