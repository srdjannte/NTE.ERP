namespace nte.erp.core
{
  public class SendResponse
  {
    public bool Status = false;
    public DateTime Started = DateTime.MinValue;
    public DateTime Ended = DateTime.MinValue;
    public string PlainText = string.Empty;
    public string Error = string.Empty;
    public SendResponse()
    {
      this.Started = DateTime.Now;
    }
    public SendResponse(string iError)
    {
      this.Started = DateTime.Now;
      this.Ended = DateTime.Now;
      this.Status = false;
      this.Error = iError;
    }
    public void Update(string iContent)
    {
      this.Ended = DateTime.Now;
      this.Status = false;
      this.PlainText = iContent;

      if (this.PlainText.Contains("Messages"))
      {
        this.Error = this.PlainText;
      }
      else
      {
        this.Status = true;
      }
      //      var fJson = JsonConvert.DeserializeObject<object>(this.PlainText);
    }
    public void UpdateError(string iError, string iContent)
    {
      this.Ended = DateTime.Now;
      this.Status = false;
      this.Error = iError;
      this.PlainText = iContent;
    }
  }
}