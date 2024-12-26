using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using InvoiceDB.Data.Model;
using InvoiceDB.Data.Context;

namespace InvoiceDB.Data.Repository
{
  public class EfaktureRepository : IEfaktureRepository
  {
    private EfaktureContext _dbContext;

    public EfaktureRepository(EfaktureContext efaktureContext)
    {
      _dbContext = efaktureContext;
    }

    public void SetDbConnectionString(string dbConnectionString)
    {
      _dbContext.Database.GetDbConnection().ConnectionString = dbConnectionString;
      _dbContext.ChangeTracker.Clear();
    }

    #region Get entities

    public virtual Document GetDocumentByPurchaseInvoiceId(int purchaseInvoiceId)
    {
      return _dbContext.Documents.FirstOrDefault(x => x.PurchaseInvoiceId == purchaseInvoiceId && (x.IsActive ?? false));
    }

    public virtual DocumentDetail GetDocumentDetailByPurchaseInvoiceId(int purchaseInvoiceId)
    {
      return _dbContext.DocumentDetails.FirstOrDefault(x => x.Document.PurchaseInvoiceId == purchaseInvoiceId && (x.Document.IsActive ?? false));
    }

    public virtual IQueryable<DocumentChange> GetAllDocumentChanges()
    {
      return _dbContext.DocumentChanges;
    }

    public virtual IQueryable<Document> GetAllDocuments()
    {
      return _dbContext.Documents;
    }

    public virtual IQueryable<Party> GetParties()
    {
      return _dbContext.Parties;
    }

    public virtual File GetFileById(int fileId)
    {
      return _dbContext.Files.FirstOrDefault(x => x.Id == fileId);
    }

    #endregion

    #region Save entities

    public virtual void AddDocument(Document document)
    {
      try
      {
        _dbContext.Documents.Add(document);
        _dbContext.SaveChanges();
      }
      catch //(Exception ex)
      {
        _dbContext.ChangeTracker.Clear();
        throw;
      }
    }

    public virtual void AddDocuments(List<Document> documents)
    {
      try
      {
        _dbContext.Documents.AddRange(documents);
        _dbContext.SaveChanges();
      }
      catch //(Exception ex)
      {
        _dbContext.ChangeTracker.Clear();
        throw;
      }
    }

    public virtual void AddOrUpdateDocumentDetail(DocumentDetail documentDetail, bool commit)
    {
      try
      {
        _dbContext.DocumentDetails.Update(documentDetail);

        if (commit)
        {
          _dbContext.SaveChanges();
        }
      }
      catch //(Exception ex)
      {
        _dbContext.ChangeTracker.Clear();
        throw;
      }
    }

    public virtual void AddOrUpdateDocumentChange(DocumentChange documentChange)
    {
      try
      {
        _dbContext.DocumentChanges.Update(documentChange);
        _dbContext.SaveChanges();
      }
      catch //(Exception ex)
      {
        _dbContext.ChangeTracker.Clear();
        throw;
      }
    }

    public virtual void AddDocumentChanges(List<DocumentChange> documentChanges)
    {
      try
      {
        foreach (var chg in documentChanges)
        {
          _dbContext.DocumentChanges.Add(chg);
        }

        _dbContext.SaveChanges();
      }
      catch //(Exception ex)
      {
        _dbContext.ChangeTracker.Clear();
        throw;
      }
    }

    public virtual void UpdateFiles(List<File> files)
    {
      try
      {
        foreach (var file in files)
        {
          _dbContext.Update(file);
        }

        _dbContext.SaveChanges();
      }
      catch //(Exception ex)
      {
        _dbContext.ChangeTracker.Clear();
        throw;
      }
    }
    #endregion
  }
}
