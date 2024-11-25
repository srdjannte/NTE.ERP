namespace nte.erp.core.Export
{
  public enum ExportSendProvider { Skip, File, SEF, MojeRacun };
  public class ExportSend
  {
    public string Name = string.Empty;
    public ExportSendProvider Provider = ExportSendProvider.Skip;
    #region File
    public string FileLocation = string.Empty;
    #endregion
    #region SEF
    public string SEFURI = string.Empty;
    public string SEFApiKey = string.Empty;
    #endregion
    #region MojeRacun
    public string MRURI = string.Empty;
    public string MRUsername = string.Empty;
    public string MRPassword = string.Empty;
    public string MRCompanyID = string.Empty;
    public string MRSoftwareID = string.Empty;
    #endregion
    public void Update(string iName, string iProvider, string iFileLocation, string iSEFURI, string iSEFApiKey, string iMRURI, string iMRUsername, string iMRPassword, string iMRCompanyID, string iMRSoftwareID)
    {
      this.Name = iName;
      if (Enum.TryParse(iProvider, out ExportSendProvider fProvider))
      {
        this.Provider = fProvider;
      }
      #region File
      this.FileLocation = iFileLocation;
      #endregion
      #region SEF
      this.SEFURI = iSEFURI;
      this.SEFApiKey = iSEFApiKey;
      #endregion
      #region MojeRacun
      this.MRURI = iMRURI;
      this.MRUsername = iMRUsername;
      this.MRPassword = iMRPassword;
      this.MRCompanyID = iMRCompanyID;
      this.MRSoftwareID = iMRSoftwareID;
      #endregion
    }

  }
}