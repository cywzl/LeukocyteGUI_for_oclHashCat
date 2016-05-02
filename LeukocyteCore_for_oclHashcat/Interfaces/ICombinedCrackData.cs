namespace LeukocyteCore_for_oclHashcat.Interfaces
{
    public interface ICombinedCrackData : ICrackDataSource
    {
        string AdditionalSource { get; set; }
        AttackModes AttackMode { get; set; }
        ICrackDataSource SourceBase { get; set; }
        ICrackDataSource AdditionalSourceBase { get; set; }
    }
}
