using System.Collections.Generic;
using System.Linq;
using InvoiceDB.Data.Model;

namespace InvoiceDB.Data.Repository
{
  public interface IEfaktureRepository
  {
    void SetDbConnectionString(string dbConnectionString);
    Document GetDocumentByPurchaseInvoiceId(int purchaseInvoiceId);
    DocumentDetail GetDocumentDetailByPurchaseInvoiceId(int purchaseInvoiceId);
    IQueryable<DocumentChange> GetAllDocumentChanges();
    IQueryable<Document> GetAllDocuments();
    IQueryable<Party> GetParties();
    File GetFileById(int fileId);
    void AddDocument(Document document);
    void AddDocuments(List<Document> documents);
    void AddOrUpdateDocumentDetail(DocumentDetail documentDetail, bool commit);
    void AddOrUpdateDocumentChange(DocumentChange documentChange);
    void AddDocumentChanges(List<DocumentChange> documentChanges);
    void UpdateFiles(List<File> files);
  }
}
