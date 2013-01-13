namespace LatinTester.Entities.Verbs.Conjugations.Base
{
  public interface IImperative
  {
    string ActiveSingular { get; }
    string ActivePlural { get; }
    string PassiveSingular { get; }
    string PassivePlural { get; }
  }
}
