using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InvoiceDB.Data.Context
{
  public partial class EfaktureContext : DbContext
  {
    private readonly bool _showErrorDetails = true;

    public override int SaveChanges()
    {
      try
      {
        ValidateModel();

        return base.SaveChanges();
      }
      catch (Exception ex)
      {
        string errorMessage = _showErrorDetails ? ex.InnerException?.Message ?? ex.Message : string.Empty;

        throw new Exception("Proveriti model eFakture!" + (!string.IsNullOrEmpty(errorMessage) ? Environment.NewLine + errorMessage : string.Empty));
      }
    }

    public void ValidateModel()
    {
      var entries = ChangeTracker.Entries().Where(e => e.State != EntityState.Unchanged);

      var errorMessage = string.Empty;
      List<string> errorMessages = new List<string>();
      foreach (var entry in entries)
      {
        foreach (var prop in entry.CurrentValues.Properties)
        {
          var val = prop.PropertyInfo.GetValue(entry.Entity);

          if (prop.ClrType == typeof(string) && prop.GetMaxLength() < (val ?? string.Empty).ToString().Length)
          {
            errorMessage = $"{prop.ToString()} ~ ({val?.ToString().Length})({val})";


          }
          else if (!prop.IsNullable && val == null)
          {
            errorMessage = $"{prop.ToString()} ~ Property isn't nullable!";
          }

          if (!string.IsNullOrEmpty(errorMessage) && !errorMessages.Contains(errorMessage))
          {
            errorMessages.Add(errorMessage);
          }
        }
      }

      if (errorMessages.Count > 0)
      {
        errorMessage = _showErrorDetails ? string.Join(Environment.NewLine, errorMessages.ToArray()) : string.Empty;

        throw new Exception(errorMessage);
      }
    }
  }
}