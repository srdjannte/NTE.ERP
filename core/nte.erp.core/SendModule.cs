using Newtonsoft.Json;
using nte.erp.core.Export;
using System.Net;
using System.Text;

namespace nte.erp.core
{
  public class SendModule : IDisposable
  {
    public SendModule() { }
    private async Task<HttpResponseMessage> SendRequestAsync(string adaptiveUri, string request, HttpClient httpClient)
    {
      HttpResponseMessage responseMessage = null;
      try
      {
        responseMessage = await httpClient.PostAsync(adaptiveUri, new StringContent(request, Encoding.UTF8, "application/json"));
        var contents = await responseMessage.Content.ReadAsStringAsync();
      }
      catch (Exception ex)
      {
        if (responseMessage == null)
        {
          responseMessage = new HttpResponseMessage
          {
            StatusCode = HttpStatusCode.InternalServerError,
            ReasonPhrase = $"Error: {ex.Message}"
          };
        }
      }

      return responseMessage;
    }
    public SendResponse SendData(string iFile, ExportSend iSend)
    {
      if (string.IsNullOrEmpty(iSend.MRURI))
      {
        return new SendResponse("URL is Empty, Not Calling API!");
      }

      if (string.IsNullOrEmpty(iFile))
      {
        return new SendResponse("Message Body is Empty, Not Calling API!");
      }

      try
      {
        using (HttpClient client = new HttpClient())
        {
          SendResponse fRes = new SendResponse();
          var request = JsonConvert.SerializeObject(new SendRequest
          {
            Username = Convert.ToInt32(iSend.MRUsername),
            Password = iSend.MRPassword,
            CompanyId = iSend.MRCompanyID,
            SoftwareId = iSend.MRSoftwareID,
            File = iFile
          });

          var response = this.SendRequestAsync(iSend.MRURI, request, client);
          //response.ConfigureAwait(true);
          var contents = response.Result.Content.ReadAsStringAsync();

          if (contents.Exception != null)
          {
            string fError = contents.Exception.Message;
            // Utils.WriteLine($"API Error: {fError}");
            fRes.UpdateError(fError, contents.Result);

            return fRes;
          }

          string fContent = contents.Result.ToString();
          // Utils.WriteLine($"API Response: {fContent}");
          fRes.Update(fContent);

          return fRes;
        }
      }
      catch (Exception ex)
      {
        return new SendResponse(ex.Message);
      }

      //return new SendResponse("Error: unknown!");
    }

    public SendResponse SendData(string iId, string iBody, ExportItem iExport)
    {
      SendResponse fRes = new SendResponse();

      try
      {
        switch (iExport.Send.Provider)
        {
          case ExportSendProvider.Skip:
            fRes.Status = true;
            // Utils.WriteLine($"SKIPPED Send Data");
            break;
          case ExportSendProvider.File:
            if (string.IsNullOrEmpty(iExport.Send.FileLocation))
            {
              return new SendResponse("File Location is Empty, Xml not saved!");
            }
            string fFileName = iExport.Send.FileLocation;

            if (fFileName.EndsWith("\\"))
            {
              fFileName += string.Format("Export-{0}-{1}.xml", iId, DateTime.Now.ToString("yyyyMMdd-HHmmSS"));
            }
            else
            {
              fFileName = fFileName.Replace("ID", iId);
              fFileName = fFileName.Replace("DATE", DateTime.Now.ToString("yyyyMMdd"));
              fFileName = fFileName.Replace("TIME", DateTime.Now.ToString("HHmmSS"));
            }

            // Utils.WriteLine($"Send Data to {fFileName}");
            File.WriteAllText(fFileName, iBody);
            fRes.Status = true;
            break;
          case ExportSendProvider.SEF:
            break;
          case ExportSendProvider.MojeRacun:
            if (string.IsNullOrEmpty(iExport.Send.MRURI))
            {
              return new SendResponse("URL is Empty, Not Calling API!");
            }

            if (string.IsNullOrEmpty(iBody))
            {
              return new SendResponse("Message Body is Empty, Not Calling API!");
            }

            using (HttpClient client = new HttpClient())
            {
              var request = JsonConvert.SerializeObject(new SendRequest
              {
                Username = Convert.ToInt32(iExport.Send.MRUsername),
                Password = iExport.Send.MRPassword,
                CompanyId = iExport.Send.MRCompanyID,
                SoftwareId = iExport.Send.MRSoftwareID,
                File = iBody
              });

              var response = this.SendRequestAsync(iExport.Send.MRURI, request, client);
              //response.ConfigureAwait(true);
              var contents = response.Result.Content.ReadAsStringAsync();

              if (contents.Exception != null)
              {
                string fError = contents.Exception.Message;
                // Utils.WriteLine($"API Error: {fError}");
                fRes.UpdateError(fError, contents.Result);

                return fRes;
              }

              string fContent = contents.Result.ToString();
              // Utils.WriteLine($"API Response: {fContent}");
              fRes.Update(fContent);
            }
            break;
        }
      }
      catch (Exception ex)
      {
        return new SendResponse(ex.Message);
      }

      return fRes;
      //return new SendResponse("Error: unknown!");
    }

    public void Dispose()
    {

    }
  }
}
