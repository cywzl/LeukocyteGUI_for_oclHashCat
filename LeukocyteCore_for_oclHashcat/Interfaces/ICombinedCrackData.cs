namespace LeukocyteCore_for_oclHashcat.Interfaces
{
    public interface ICombinedCrackData : ICrackDataSource
    {
        string AdditionalSource { get; set; }
    }
}
