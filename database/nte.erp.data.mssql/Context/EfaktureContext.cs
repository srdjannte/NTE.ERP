using Microsoft.EntityFrameworkCore;
using InvoiceDB.Data.Model;
#nullable disable

namespace InvoiceDB.Data.Context
{
  public partial class EfaktureContext : DbContext
  {
    public EfaktureContext()
    {
    }

    public EfaktureContext(DbContextOptions<EfaktureContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Document> Documents { get; set; }
    public virtual DbSet<DocumentChange> DocumentChanges { get; set; }
    public virtual DbSet<DocumentDetail> DocumentDetails { get; set; }
    public virtual DbSet<File> Files { get; set; }
    public virtual DbSet<Invoice> Invoices { get; set; }
    public virtual DbSet<InvoiceAdditionalDocumentReference> InvoiceAdditionalDocumentReferences { get; set; }
    public virtual DbSet<InvoiceLegalMonetaryTotal> InvoiceLegalMonetaryTotals { get; set; }
    public virtual DbSet<InvoiceLine> InvoiceLines { get; set; }
    public virtual DbSet<InvoicePeriodCode> InvoicePeriodCodes { get; set; }
    public virtual DbSet<InvoiceTaxExemptionReasonList> InvoiceTaxExemptionReasonLists { get; set; }
    public virtual DbSet<InvoiceTaxSubtotal> InvoiceTaxSubtotals { get; set; }
    public virtual DbSet<InvoiceTypeCode> InvoiceTypeCodes { get; set; }
    public virtual DbSet<Party> Parties { get; set; }
    public virtual DbSet<UnitMeasure> UnitMeasures { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

      modelBuilder.Entity<Document>(entity =>
      {
        entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

        entity.Property(e => e.SyncDate).HasDefaultValueSql("(getdate())");

        entity.HasOne(d => d.File)
                  .WithMany(p => p.Documents)
                  .HasForeignKey(d => d.FileId)
                  .HasConstraintName("FK_DocumentPdf_FileId");
      });

      modelBuilder.Entity<DocumentChange>(entity =>
      {
        entity.Property(e => e.SyncDate).HasDefaultValueSql("(getdate())");
      });

      modelBuilder.Entity<DocumentDetail>(entity =>
      {
        entity.Property(e => e.SyncDate).HasDefaultValueSql("(getdate())");

        entity.HasOne(d => d.Document)
                  .WithOne(p => p.DocumentDetail)
                  //.HasForeignKey(d => DocumentId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_DocumentDetail_DocumentId");
      });

      modelBuilder.Entity<File>(entity =>
      {
        entity.Property(e => e.MimeCode).IsUnicode(false);
      });

      modelBuilder.Entity<Invoice>(entity =>
      {
        entity.Property(e => e.CustomizationId).IsUnicode(false);

        entity.Property(e => e.DocumentCurrencyCode)
                  .IsUnicode(false)
                  .HasDefaultValueSql("('RSD')")
                  .IsFixedLength(true);

        entity.HasOne(d => d.AccountingCustomerParty)
                  .WithMany(p => p.InvoiceAccountingCustomerParties)
                  .HasForeignKey(d => d.AccountingCustomerPartyId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_Invoice_CustomerPartyId");

        entity.HasOne(d => d.AccountingSupplierParty)
                  .WithMany(p => p.InvoiceAccountingSupplierParties)
                  .HasForeignKey(d => d.AccountingSupplierPartyId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_Invoice_SupplierPartyId");

        entity.HasOne(d => d.Document)
                  .WithOne(p => p.Invoice)
                  //.HasForeignKey(d => d.DocumentId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_Invoice_DocumentId");
      });

      modelBuilder.Entity<InvoiceAdditionalDocumentReference>(entity =>
      {
        entity.HasOne(d => d.File)
                  .WithMany(p => p.InvoiceAdditionalDocumentReferences)
                  .HasForeignKey(d => d.FileId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_InvoiceAdditionalDocumentReference_FileId");

        entity.HasOne(d => d.Invoice)
                  .WithMany(p => p.InvoiceAdditionalDocumentReferences)
                  .HasForeignKey(d => d.InvoiceId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_InvoiceAdditionalDocumentReference_InvoiceId");
      });

      modelBuilder.Entity<InvoiceLegalMonetaryTotal>(entity =>
      {
        entity.HasOne(d => d.Invoice)
                  .WithOne(p => p.InvoiceLegalMonetaryTotal)
                  //.HasForeignKey(d => d.InvoiceId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_InvoiceLegalMonetaryTotal_InvoiceId");
      });

      modelBuilder.Entity<InvoiceLine>(entity =>
      {
        entity.HasOne(d => d.Invoice)
                  .WithMany(p => p.InvoiceLines)
                  .HasForeignKey(d => d.InvoiceId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_InvoiceLine_InvoiceId");
      });

      modelBuilder.Entity<InvoicePeriodCode>(entity =>
      {
        entity.Property(e => e.SyncDate).HasDefaultValueSql("(getdate())");
      });

      modelBuilder.Entity<InvoiceTaxExemptionReasonList>(entity =>
      {
        entity.Property(e => e.Article).IsUnicode(false);

        entity.Property(e => e.Paragraph).IsUnicode(false);

        entity.Property(e => e.Point).IsUnicode(false);

        entity.Property(e => e.Subpoint).IsUnicode(false);
      });

      modelBuilder.Entity<InvoiceTaxSubtotal>(entity =>
      {
        entity.HasOne(d => d.Invoice)
                  .WithMany(p => p.InvoiceTaxSubtotals)
                  .HasForeignKey(d => d.InvoiceId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_InvoiceTaxSubtotal_InvoiceId");
      });

      modelBuilder.Entity<InvoiceTypeCode>(entity =>
      {
        entity.Property(e => e.SyncDate).HasDefaultValueSql("(getdate())");
      });

      modelBuilder.Entity<Party>(entity =>
      {
        entity.Property(e => e.EndpointId).IsUnicode(false);
      });

      modelBuilder.Entity<UnitMeasure>(entity =>
      {
        entity.Property(e => e.Code)
                  .IsUnicode(false)
                  .IsFixedLength(true);

        entity.Property(e => e.SyncDate).HasDefaultValueSql("(getdate())");
      });

      OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
  }
}
