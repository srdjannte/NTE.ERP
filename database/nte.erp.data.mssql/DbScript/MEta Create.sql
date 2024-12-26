SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
USE [efakture]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[erp_info]') AND type in (N'U'))
DROP TABLE [dbo].[erp_info]
GO
CREATE TABLE [dbo].[erp_info](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Uid] [uniqueidentifier] NOT NULL,
	[StateUid] [varchar](128) NULL,
	[SyncDate] [datetime],
	[SyncRevId] [int] NOT NULL,
	[SyncSessionUid] [uniqueidentifier] NOT NULL,

	[ApiKey] [nvarchar](256) NOT NULL,
	[LicenceType] [nvarchar](256) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
	[ContactName] [nvarchar](128) NULL,
	[ContactEmail] [nvarchar](128) NULL,
	[AddressStreetName] [nvarchar](256) NULL,
	[AddressCityName] [nvarchar](128) NULL,
	[AddressPostalZone] [nvarchar](128) NULL,
	[AddressCountryIdentificationCode] [nvarchar](32) NULL,
	[TaxSchemeId] [nvarchar](128) NULL,
	[TaxSchemeCompanyId] [nvarchar](128) NULL,
	[TaxSchemeRegistrationName] [nvarchar](128) NULL,
	[LegalEntityCompanyId] [nvarchar](32) NULL,
	[LegalEntityRegistrationName] [nvarchar](256) NULL,
	[Source] [xml] NULL,
	[Destination] [xml] NULL,
)
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[erp_invoice_in]') AND type in (N'U'))
DROP TABLE [dbo].[erp_invoice_in]
GO
CREATE TABLE [dbo].[erp_invoice_in](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Uid] [uniqueidentifier] NOT NULL,
	[InfoUid] [uniqueidentifier] NOT NULL,
	[StateUid] [varchar](128) NOT NULL,
	[SyncDate] [datetime],
	[SyncRevId] [int] NOT NULL,
	[SyncSessionUid] [uniqueidentifier] NOT NULL,

	[DocumentId] [int] NOT NULL,
	[CustomizationId] [varchar](128) NULL,

	[InvoiceId] [nvarchar](128) NULL,
	[IssueDate] [datetime] NOT NULL,
	[DueDate] [date] NULL,
	[TaxPointDate] [date] NULL,
	[InvoiceTypeCode] [int] NOT NULL,
	[DocumentCurrencyCode] [char](3) NULL,
	[InvoicePeriodCode] [int] NOT NULL,
	[AccountingSupplierPartyId] [int] NOT NULL,
	[AccountingCustomerPartyId] [int] NOT NULL,
	[ActualDeliveryDate] [datetime] NULL,
	[PaymentMeansId] [nvarchar](64) NULL,
	[PaymentMeansCode] [int] NOT NULL,
	[PaymentId] [nvarchar](64) NULL,
	[PayerFinancialAccountId] [nvarchar](256) NULL,
	[PayeeFinancialAccountId] [nvarchar](256) NULL,
	[TotalAmount] [decimal](19, 2) NOT NULL,
	[Note] [nvarchar](max) NULL,
	[DocumentReferenceId] [nvarchar](128) NULL,
	[ContractDocumentReferenceId] [nvarchar](256) NULL,
	[OriginatorDocumentReferenceId] [nvarchar](128) NULL,
	[OrderReferenceId] [nvarchar](512) NULL,
	[SourceXml] [xml] NULL
)
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[erp_invoice_in_line]') AND type in (N'U'))
DROP TABLE [dbo].[erp_invoice_in_line]
GO
CREATE TABLE [dbo].[erp_invoice_in_line](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Uid] [uniqueidentifier] NOT NULL,
	[InfoUid] [uniqueidentifier] NOT NULL,
	[StateUid] [uniqueidentifier] NOT NULL,
	[SyncDate] [datetime],
	[SyncRevId] [int] NOT NULL,
	[SyncSessionUid] [uniqueidentifier] NOT NULL,

	[InvoiceId] [int] NOT NULL,
	[LineId] [nvarchar](32) NULL,
	[InvoicedQuantity] [decimal](19, 2) NOT NULL,
	[InvoicedQuantityUnitCode] [nvarchar](32) NULL,
	[LineExtensionAmount] [decimal](19, 2) NOT NULL,
	[AllowanceChargeIndicator] [bit] NOT NULL,
	[AllowanceChargeMultiplierFactorNumeric] [decimal](19, 2) NOT NULL,
	[AllowanceChargeAmount] [decimal](19, 2) NOT NULL,
	[Name] [nvarchar](1024) NULL,
	[SellersItemIdentification] [nvarchar](512) NULL,
	[ClassifiedTaxCategory] [nvarchar](6) NULL,
	[ClassifiedTaxCategoryPercent] [decimal](5, 2) NOT NULL,
	[ClassifiedTaxCategoryTaxScheme] [nvarchar](6) NULL,
	[PriceAmount] [decimal](19, 2) NOT NULL,
)
GO

