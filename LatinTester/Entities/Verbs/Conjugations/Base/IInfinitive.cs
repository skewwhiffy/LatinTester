namespace LatinTester.Entities.Verbs.Conjugations.Base
{
  public interface IInfinitive
  {
    string ActivePresent { get; }
    string ActiveFuture { get; }
    string ActivePerfect { get; }
    string PassivePresent { get; }
    string PassiveFuture { get; }
    string PassivePerfect { get; }
  }
}
