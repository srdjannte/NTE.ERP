USE [master]
GO

IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'eFakture')
BEGIN
	CREATE DATABASE eFakture
END
ELSE
BEGIN
	
	PRINT N'Baza ''eFakture'' je već kreirana'
	--DROP DATABASE eFakture
END
GO

USE eFakture
GO

IF OBJECT_ID('dbo.UnitMeasure') IS NOT NULL
    DROP TABLE dbo.UnitMeasure

CREATE TABLE dbo.UnitMeasure
(
    Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Code CHAR(3) NOT NULL UNIQUE,
    NameCyr NVARCHAR(32) NOT NULL,
	NameLat NVARCHAR(32) NOT NULL,
	NameEng NVARCHAR(32) NOT NULL,
	SyncDate DATETIME NOT NULL DEFAULT GETDATE()
)

INSERT INTO dbo.UnitMeasure(Code, NameCyr, NameLat, NameEng, SyncDate)
VALUES('H87', N'kом', N'kom', N'pc', GETDATE()),
('KGM', N'kг', N'kg', N'kg', GETDATE()),
('KMT', N'kм', N'km', N'km', GETDATE()),
('GRM', N'г', N'g', N'g', GETDATE()),
('MTR', N'м', N'm', N'm', GETDATE()),
('LTR', N'л', N'l', N'l', GETDATE()),
('TNE', N'т', N't', N't', GETDATE()),
('MTK', N'м2', N'm2', N'm2', GETDATE()),
('MTQ', N'м3', N'm3', N'm3', GETDATE()),
('MIN', N'мин', N'min', N'min', GETDATE()),
('HUR', N'ч', N'h', N'h', GETDATE()),
('DAY', N'д', N'd', N'd', GETDATE()),
('MON', N'М', N'M', N'M', GETDATE()),
('ANN', N'год', N'god', N'y', GETDATE())

IF OBJECT_ID('dbo.InvoiceTypeCode') IS NOT NULL
    DROP TABLE dbo.InvoiceTypeCode

CREATE TABLE dbo.InvoiceTypeCode
(
    Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Code INT NOT NULL UNIQUE,
    NameCyr NVARCHAR(32) NOT NULL,
	NameLat NVARCHAR(32) NOT NULL,
	NameEng NVARCHAR(32) NOT NULL,
	SyncDate DATETIME NOT NULL DEFAULT GETDATE()
)

INSERT INTO dbo.InvoiceTypeCode(Code, NameCyr, NameLat, NameEng, SyncDate)
VALUES(380, N'комерцијална фактура', N'komercijalna faktura', N'comercial invoice', GETDATE()),
(381, N'књижно одобрење', N'knjižno odobrenje', N'credit note', GETDATE()),
(383, N'књижно задужење', N'knjižno zaduženje', N'debit note', GETDATE()),
(386, N'авансна фактура', N'avansna faktura', N'advance invoice', GETDATE())

IF OBJECT_ID('dbo.InvoicePeriodCode') IS NOT NULL
    DROP TABLE dbo.InvoicePeriodCode

CREATE TABLE dbo.InvoicePeriodCode
(
    Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Code INT NOT NULL UNIQUE,
    NameCyr NVARCHAR(32) NOT NULL,
	NameLat NVARCHAR(32) NOT NULL,
	NameEng NVARCHAR(64) NOT NULL,
	SyncDate DATETIME NOT NULL DEFAULT GETDATE()
)

INSERT INTO dbo.InvoicePeriodCode(Code, NameCyr, NameLat, NameEng, SyncDate)
VALUES(3, N'према датуму издавања фактуре', N'prema datumu izdavanja fakture', N'according to the date of issue of the invoice', GETDATE()),
(35, N'према датуму промета', N'prema datumu prometa', N'according to the date of turnover', GETDATE()),
(432, N'према датуму плаћања', N'prema datumu plaćanja', N'according to the date of payment', GETDATE())


IF OBJECT_ID('dbo.InvoiceTaxExemptionReasonList') IS NOT NULL
    DROP TABLE dbo.InvoiceTaxExemptionReasonList

CREATE TABLE dbo.InvoiceTaxExemptionReasonList
(
    Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ReasonId INT UNIQUE NOT NULL,
	[Key] NVARCHAR(32) NOT NULL,
	[Law] NVARCHAR(128) NOT NULL,
	Article VARCHAR(4) NOT NULL,
	Paragraph VARCHAR(4) NULL,
	Point VARCHAR(4) NULL,
	Subpoint VARCHAR(4) NULL,
	[Text] NVARCHAR(1024) NOT NULL,
	FreeFormNote NVARCHAR(1024) NULL,
	ActiveFrom DATETIME NOT NULL,
	ActiveTo DATETIME NULL,
	Category NVARCHAR(2) NULL
)

INSERT INTO dbo.InvoiceTaxExemptionReasonList(ReasonId, [Key], Law, Article, Paragraph, Point, Subpoint, Text, FreeFormNote, ActiveFrom, ActiveTo, Category)
VALUES(1, N'PDV-RS-10-2-1', N'Zakon o Porezu na dodatu vrednost', '10', '2', '1', NULL, N'Poreski dužnik je primalac dobara ili usluga, obveznik PDV, za promet sekundarnih sirovina i usluga koje su neposredno povezane sa tim dobrima, izvršen od strane drugog obveznika PDV', NULL, '2022-02-28', NULL, N'AE'),
(2, N'PDV-RS-10-2-2', N'Zakon o Porezu na dodatu vrednost', '10', '2', '2', NULL, N'Poreski dužnik je primalac dobara, obveznik PDV, za promet građevinskih objekata i ekonomski deljivih celina u okviru tih objekata, uključujući i vlasničke udele na tim dobrima, izvršen od strane drugog obveznika PDV, u slučaju kada je ugovorom na osnovu kojeg se vrši promet tih dobara predviđeno da će se na taj promet obračunati PDV u skladu sa ovim zakonom', NULL, '2022-02-28', NULL, N'AE'),
(3, N'PDV-RS-10-2-3', N'Zakon o Porezu na dodatu vrednost', '10', '2', '3', NULL, N'Poreski dužnik je primalac dobara i usluga iz oblasti građevinarstva, obveznik PDV, odnosno lice iz člana 9. stav 1. ovog zakona, za promet izvršen od strane obveznika PDV, ako je vrednost tog prometa veća od 500.000 dinara, bez PDV', NULL, '2022-02-28', NULL, N'AE'),
(4, N'PDV-RS-10-2-4', N'Zakon o Porezu na dodatu vrednost', '10', '2', '4', NULL, N'Poreski dužnik je primalac električne energije i prirodnog gasa koji se isporučuju preko prenosne, transportne i distributivne mreže, obveznik PDV koji je ova dobra nabavio radi dalje prodaje, za promet električne energije i prirodnog gasa izvršen od strane drugog obveznika PDV', NULL, '2022-02-28', NULL, N'AE'),
(5, N'PDV-RS-10-2-5-1', N'Zakon o Porezu na dodatu vrednost', '10', '2', '5', '1', N'Poreski dužnik je primalac dobara ili usluga, obveznik PDV, za promet izvršen od strane drugog obveznika PDV, i to kod prometa hipotekovane nepokretnosti kod realizacije hipoteke u skladu sa zakonom kojim se uređuje hipoteka', NULL, '2022-02-28', NULL, N'AE'),
(6, N'PDV-RS-10-2-5-2', N'Zakon o Porezu na dodatu vrednost', '10', '2', '5', '2', N'Poreski dužnik je primalac dobara ili usluga, obveznik PDV, za promet izvršen od strane drugog obveznika PDV, i to kod prometa predmeta založnog prava kod realizacije ugovora o zalozi u skladu sa zakonom kojim se uređuje založno pravo na pokretnim stvarima', NULL, '2022-02-28', NULL, N'AE'),
(7, N'PDV-RS-10-2-5-3', N'Zakon o Porezu na dodatu vrednost', '10', '2', '5', '3', N'Poreski dužnik je primalac dobara ili usluga, obveznik PDV, za promet izvršen od strane drugog obveznika PDV, i to kod prometa dobara ili usluga nad kojima se sprovodi izvršenje u izvršnom postupku u skladu sa zakonom', NULL, '2022-02-28', NULL, N'AE'),
(8, N'PDV-RS-11-1-1', N'Zakon o Porezu na dodatu vrednost', '11', '1', '1', NULL, N'Mesto prometa dobara je inostranstvo - mesto u kojem se dobro nalazi u trenutku slanja ili prevoza do primaoca ili, po njegovom nalogu, do trećeg lica, ako dobro šalje ili prevozi isporučilac, primalac ili treće lice, po njegovom nalogu', NULL, '2022-02-28', NULL, N'O'),
(9, N'PDV-RS-11-1-2', N'Zakon o Porezu na dodatu vrednost', '11', '1', '2', NULL, N'Mesto prometa dobara je inostranstvo - mesto ugradnje ili montaže dobra, ako se ono ugrađuje ili montira od strane isporučioca ili, po njegovom nalogu, od strane trećeg lica', NULL, '2022-02-28', NULL, N'O'),
(10, N'PDV-RS-11-1-3', N'Zakon o Porezu na dodatu vrednost', '11', '1', '3', NULL, N'Mesto prometa dobara je inostranstvo - mesto u kojem se dobro nalazi u trenutku isporuke, ako se dobro isporučuje bez otpreme, odnosno prevoza', NULL, '2022-02-28', NULL, N'O'),
(11, N'PDV-RS-11-1-4', N'Zakon o Porezu na dodatu vrednost', '11', '1', '4', NULL, N'Mesto prometa dobara je inostranstvo - mesto u kojem primalac električne energije, prirodnog gasa i energije za grejanje, odnosno hlađenje, čija se isporuka vrši preko prenosne, transportne i distributivne mreže, a koji je ova dobra nabavio radi dalje prodaje, ima sedište ili stalnu poslovnu jedinicu kojima se dobra isporučuju', NULL, '2022-02-28', NULL, N'O'),
(12, N'PDV-RS-11-1-5', N'Zakon o Porezu na dodatu vrednost', '11', '1', '5', NULL, N'Mesto prometa dobara je inostranstvo - mesto prijema vode, električne energije, prirodnog gasa i energije za grejanje, odnosno hlađenje, za krajnju potrošnju', NULL, '2022-02-28', NULL, N'O'),
(13, N'PDV-RS-11-3', N'Zakon o Porezu na dodatu vrednost', '11', '3', NULL, NULL, N'Izuzetno od stava 1. tačka 3) ovog člana, ako se promet dobara vrši na brodu, odnosno u letilici ili vozu u toku prevoza putnika, mestom prometa smatra se mesto polaska broda, letilice ili voza, koje se nalazi u inostranstvu', NULL, '2022-02-28', NULL, N'O'),
(14, N'PDV-RS-12-4', N'Zakon o Porezu na dodatu vrednost', '12', '4', NULL, NULL, N'Ako se promet usluga vrši poreskom obvezniku, mestom prometa usluga smatra se mesto u inostranstvu u kojem primalac usluga ima sedište ili stalnu poslovnu jedinicu ako se promet usluga vrši stalnoj poslovnoj jedinici koja se ne nalazi u mestu u kojem primalac usluga ima sedište, odnosno mesto u inostranstvu u kojem primalac usluga ima prebivalište ili boravište', NULL, '2022-02-28', NULL, N'O'),
(15, N'PDV-RS-12-6-1', N'Zakon o Porezu na dodatu vrednost', '12', '6', '1', NULL, N'Mestom prometa usluga u vezi sa nepokretnostima, uključujući i usluge posredovanja kod prometa nepokretnosti, smatra se mesto u inostranstvu u kojem se nalazi nepokretnost', NULL, '2022-02-28', NULL, N'O'),
(16, N'PDV-RS-12-6-2', N'Zakon o Porezu na dodatu vrednost', '12', '6', '2', NULL, N'Mestom prometa usluga prevoza lica, smatra se mesto gde se obavlja prevoz, a ako se prevoz obavlja i u Republici i u inostranstvu, odredbe ovog zakona primenjuju se samo na deo prevoza izvršen u Republici - deo usluge prevoza koji se vrši u inostranstvu', NULL, '2022-02-28', NULL, N'O'),
(17, N'PDV-RS-12-6-3', N'Zakon o Porezu na dodatu vrednost', '12', '6', '3', NULL, N'Mestom prometa usluga prevoza dobara koja se pruža licu koje nije poreski obveznik, smatra se mesto gde se obavlja prevoz, a ako se prevoz obavlja i u Republici i u inostranstvu, odredbe ovog zakona primenjuju se samo na deo prevoza izvršen u Republici - deo usluge prevoza koji se vrši u inostranstvu', NULL, '2022-02-28', NULL, N'O'),
(18, N'PDV-RS-12-6-4-1', N'Zakon o Porezu na dodatu vrednost', '12', '6', '4', '1', N'Mestom prometa usluga smatra se mesto gde su usluge stvarno pružene, ako se radi o uslugama koje se odnose na prisustvovanje kulturnim, umetničkim, sportskim, naučnim, obrazovnim, zabavnim ili sličnim događajima (sajmovi, izložbe i dr.), uključujući i pomoćne usluge u vezi sa prisustvovanjem tim događajima, čije je mesto prometa u inostranstvu', NULL, '2022-02-28', NULL, N'O'),
(19, N'PDV-RS-12-6-4-2', N'Zakon o Porezu na dodatu vrednost', '12', '6', '4', '2', N'Mestom prometa usluga smatra se mesto gde su usluge stvarno pružene, ako se radi o uslugama organizatora događaja iz podtačke (1) ove tačke, pruženih licu koje nije poreski obveznik, čije je mesto prometa u inostranstvu', NULL, '2022-02-28', NULL, N'O'),
(20, N'PDV-RS-12-6-4-3', N'Zakon o Porezu na dodatu vrednost', '12', '6', '4', '3', N'Mestom prometa usluga smatra se mesto gde su usluge stvarno pružene, ako se radi o pomoćnim uslugama u vezi sa prevozom, kao što su utovar, istovar, pretovar i slično, pruženih licu koje nije poreski obveznik, čije je mesto prometa u inostranstvu', NULL, '2022-02-28', NULL, N'O'),
(21, N'PDV-RS-12-6-4-4', N'Zakon o Porezu na dodatu vrednost', '12', '6', '4', '4', N'Mestom prometa usluga smatra se mesto gde su usluge stvarno pružene, ako se radi o uslugama procene pokretnih stvari, odnosno radova na pokretnim stvarima pruženih licu koje nije poreski obveznik, čije je mesto prometa u inostranstvu', NULL, '2022-02-28', NULL, N'O'),
(22, N'PDV-RS-12-6-4-5', N'Zakon o Porezu na dodatu vrednost', '12', '6', '4', '5', N'Mestom prometa usluga smatra se mesto gde su usluge stvarno pružene, ako se radi o uslugama predaje jela i pića za konzumaciju na licu mesta, čije je mesto prometa u inostranstvu', NULL, '2022-02-28', NULL, N'O'),
(23, N'PDV-RS-12-6-5', N'Zakon o Porezu na dodatu vrednost', '12', '6', '5', NULL, N'Mestom prometa usluga iznajmljivanja prevoznih sredstava na kraći vremenski period, smatra se mesto u inostranstvu u kojem se prevozno sredstvo stvarno stavlja na korišćenje primaocu usluge', NULL, '2022-02-28', NULL, N'O'),
(24, N'PDV-RS-12-6-6', N'Zakon o Porezu na dodatu vrednost', '12', '6', '6', NULL, N'Mestom prometa usluga iznajmljivanja prevoznih sredstava, osim iz tačke 5) ovog stava, pruženih licu koje nije poreski obveznik, smatra se mesto u inostranstvu u kojem to lice ima sedište, prebivalište ili boravište', NULL, '2022-02-28', NULL, N'O'),
(25, N'PDV-RS-12-6-7-1', N'Zakon o Porezu na dodatu vrednost', '12', '6', '7', '1', N'Mestom prometa usluga koje se pružaju licu koje nije poreski obveznik, smatra se mesto sedišta, prebivališta ili boravišta primaoca usluga, koje se nalazi u inostranstvu, ako se radi o uslugama prenosa, ustupanja i davanja na korišćenje autorskih i srodnih prava, prava na patente, licence, zaštitne znakove i druga prava intelektualne svojine', NULL, '2022-02-28', NULL, N'O'),
(26, N'PDV-RS-12-6-7-2', N'Zakon o Porezu na dodatu vrednost', '12', '6', '7', '2', N'Mestom prometa usluga koje se pružaju licu koje nije poreski obveznik, smatra se mesto sedišta, prebivališta ili boravišta primaoca usluga, koje se nalazi u inostranstvu, ako se radi o uslugama oglašavanja', NULL, '2022-02-28', NULL, N'O'),
(27, N'PDV-RS-12-6-7-3', N'Zakon o Porezu na dodatu vrednost', '12', '6', '7', '3', N'Mestom prometa usluga koje se pružaju licu koje nije poreski obveznik, smatra se mesto sedišta, prebivališta ili boravišta primaoca usluga, koje se nalazi u inostranstvu, ako se radi o uslugama savetnika, inženjera, advokata, revizora i sličnih usluga, kao i prevodilaca za usluge prevođenja, uključujući i prevođenje u pisanom obliku', NULL, '2022-02-28', NULL, N'O'),
(28, N'PDV-RS-12-6-7-4', N'Zakon o Porezu na dodatu vrednost', '12', '6', '7', '4', N'Mestom prometa usluga koje se pružaju licu koje nije poreski obveznik, smatra se mesto sedišta, prebivališta ili boravišta primaoca usluga, koje se nalazi u inostranstvu, ako se radi o uslugama obrade podataka i ustupanja, odnosno davanja informacija, uključujući i informacije o poslovnim postupcima i iskustvu', NULL, '2022-02-28', NULL, N'O'),
(29, N'PDV-RS-12-6-7-5', N'Zakon o Porezu na dodatu vrednost', '12', '6', '7', '5', N'Mestom prometa usluga koje se pružaju licu koje nije poreski obveznik, smatra se mesto sedišta, prebivališta ili boravišta primaoca usluga, koje se nalazi u inostranstvu, ako se radi o uslugama preuzimanja obaveze da se u potpunosti ili delimično odustane od obavljanja neke delatnosti ili od korišćenja nekog prava iz ove tačke', NULL, '2022-02-28', NULL, N'O'),
(30, N'PDV-RS-12-6-7-6', N'Zakon o Porezu na dodatu vrednost', '12', '6', '7', '6', N'Mestom prometa usluga koje se pružaju licu koje nije poreski obveznik, smatra se mesto sedišta, prebivališta ili boravišta primaoca usluga, koje se nalazi u inostranstvu, ako se radi o uslugama bankarskog i finansijskog poslovanja i poslovanja u oblasti osiguranja, uključujući reosiguranje, osim iznajmljivanja sefova', NULL, '2022-02-28', NULL, N'O'),
(31, N'PDV-RS-12-6-7-7', N'Zakon o Porezu na dodatu vrednost', '12', '6', '7', '7', N'Mestom prometa usluga koje se pružaju licu koje nije poreski obveznik, smatra se mesto sedišta, prebivališta ili boravišta primaoca usluga, koje se nalazi u inostranstvu, ako se radi o uslugama stavljanja na raspolaganje osoblja', NULL, '2022-02-28', NULL, N'O'),
(32, N'PDV-RS-12-6-7-8', N'Zakon o Porezu na dodatu vrednost', '12', '6', '7', '8', N'Mestom prometa usluga koje se pružaju licu koje nije poreski obveznik, smatra se mesto sedišta, prebivališta ili boravišta primaoca usluga, koje se nalazi u inostranstvu, ako se radi o uslugama iznajmljivanja pokretnih stvari, osim prevoznih sredstava', NULL, '2022-02-28', NULL, N'O'),
(33, N'PDV-RS-12-6-7-9', N'Zakon o Porezu na dodatu vrednost', '12', '6', '7', '9', N'Mestom prometa usluga koje se pružaju licu koje nije poreski obveznik, smatra se mesto sedišta, prebivališta ili boravišta primaoca usluga, koje se nalazi u inostranstvu, ako se radi o uslugama omogućavanja pristupa mreži prirodnog gasa, mreži za prenos električne energije i mreži za grejanje, odnosno hlađenje, transporta i distribucije putem tih mreža, kao i drugih usluga koje su neposredno povezane sa tim uslugama', NULL, '2022-02-28', NULL, N'O'),
(34, N'PDV-RS-12-6-7-10', N'Zakon o Porezu na dodatu vrednost', '12', '6', '7', '10', N'Mestom prometa usluga koje se pružaju licu koje nije poreski obveznik, smatra se mesto sedišta, prebivališta ili boravišta primaoca usluga, koje se nalazi u inostranstvu, ako se radi o uslugama telekomunikacija', NULL, '2022-02-28', NULL, N'O'),
(35, N'PDV-RS-12-6-7-11', N'Zakon o Porezu na dodatu vrednost', '12', '6', '7', '11', N'Mestom prometa usluga koje se pružaju licu koje nije poreski obveznik, smatra se mesto sedišta, prebivališta ili boravišta primaoca usluga, koje se nalazi u inostranstvu, ako se radi o uslugama radijskog i televizijskog emitovanja', NULL, '2022-02-28', NULL, N'O'),
(36, N'PDV-RS-12-6-7-12', N'Zakon o Porezu na dodatu vrednost', '12', '6', '7', '12', N'Mestom prometa usluga koje se pružaju licu koje nije poreski obveznik, smatra se mesto sedišta, prebivališta ili boravišta primaoca usluga, koje se nalazi u inostranstvu, ako se radi o uslugama pruženim elektronskim putem', NULL, '2022-02-28', NULL, N'O'),
(37, N'PDV-RS-12-6-8', N'Zakon o Porezu na dodatu vrednost', '12', '6', '8', NULL, N'Mestom prometa usluga posredovanja kod prometa dobara ili usluga koja se pruža licu koje nije poreski obveznik, smatra se mesto u kojem je izvršen promet dobara ili usluga koji je predmet posredovanja, koje je u inostranstvu', NULL, '2022-02-28', NULL, N'O'),
(38, N'PDV-RS-12-6-9', N'Zakon o Porezu na dodatu vrednost', '12', '6', '9', NULL, N'Izuzetno od stava 6. tačka 4) podtačka (5) ovog člana, ako se usluge predaje jela i pića za konzumaciju na licu mesta faktički pružaju na brodu, odnosno u letilici ili vozu u toku prevoza putnika, mestom prometa smatra se mesto polaska broda, letilice ili voza, koje je u inostranstvu', NULL, '2022-02-28', NULL, N'O'),
(39, N'PDV-RS-17-4-2', N'Zakon o Porezu na dodatu vrednost', '17', '4', '2', NULL, N'Osnovica ne sadrži iznose koje obveznik naplaćuje u ime i za račun drugog, ako te iznose prenosi licu u čije ime i za čiji račun je izvršio naplatu i ako su ti iznosi posebno evidentirani', NULL, '2022-02-28', NULL, N'O'),
(40, N'PDV-RS-17-4-3', N'Zakon o Porezu na dodatu vrednost', '17', '4', '3', NULL, N'Osnovica ne sadrži iznose koje obveznik potražuje za izdatke koje je platio u ime i za račun primaoca dobara ili usluga, ako su ti iznosi posebno evidentirani', NULL, '2022-02-28', NULL, N'O'),
(41, N'PDV-RS-25-1-1', N'Zakon o Porezu na dodatu vrednost', '25', '1', '1', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza u prometu novca i kapitala, i to kod poslovanja i posredovanja u poslovanju zakonskim sredstvima plaćanja, osim papirnog i kovanog novca koji se ne koristi kao zakonsko sredstvo plaćanja ili ima numizmatičku vrednost', NULL, '2022-02-28', NULL, N'E'),
(42, N'PDV-RS-25-1-1a', N'Zakon o Porezu na dodatu vrednost', '25', '1', '1a', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza u prometu novca i kapitala, i to kod prenosa virtuelnih valuta i zamene virtuelnih valuta za novčana sredstva u skladu sa zakonom kojim se uređuje digitalna imovina', NULL, '2022-02-28', NULL, N'E'),
(43, N'PDV-RS-25-1-2', N'Zakon o Porezu na dodatu vrednost', '25', '1', '2', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza u prometu novca i kapitala, i to kod poslovanja i posredovanja u poslovanju akcijama, udelima u društvima i udruženjima, obveznicama i drugim hartijama od vrednosti, osim poslovanja koje se odnosi na čuvanje i upravljanje hartijama od vrednosti', NULL, '2022-02-28', NULL, N'E'),
(44, N'PDV-RS-25-1-3', N'Zakon o Porezu na dodatu vrednost', '25', '1', '3', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza u prometu novca i kapitala, i to kod kreditnih poslova, uključujući posredovanje, kao i novčanih pozajmica', NULL, '2022-02-28', NULL, N'E'),
(45, N'PDV-RS-25-1-4', N'Zakon o Porezu na dodatu vrednost', '25', '1', '4', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza u prometu novca i kapitala, i to kod preuzimanja obaveza, garancija i drugih sredstava obezbeđenja, uključujući posredovanje', NULL, '2022-02-28', NULL, N'E'),
(46, N'PDV-RS-25-1-5', N'Zakon o Porezu na dodatu vrednost', '25', '1', '5', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza u prometu novca i kapitala, i to kod poslovanja i posredovanja u poslovanju depozitima, tekućim i žiro računima, nalozima za plaćanje, kao i platnim prometom i doznakama', NULL, '2022-02-28', NULL, N'E'),
(47, N'PDV-RS-25-1-6', N'Zakon o Porezu na dodatu vrednost', '25', '1', '6', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza u prometu novca i kapitala, i to kod poslovanja i posredovanja u poslovanju novčanim potraživanjima, čekovima, menicama i drugim sličnim hartijama od vrednosti, osim naplate potraživanja za druga lica', NULL, '2022-02-28', NULL, N'E'),
(48, N'PDV-RS-25-1-7', N'Zakon o Porezu na dodatu vrednost', '25', '1', '7', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza u prometu novca i kapitala, i to kod poslovanja društava za upravljanje investicionim fondovima u skladu sa propisima kojima se uređuju investicioni fondovi', NULL, '2022-02-28', NULL, N'E'),
(49, N'PDV-RS-25-1-8', N'Zakon o Porezu na dodatu vrednost', '25', '1', '8', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza u prometu novca i kapitala, i to kod poslovanja društava za upravljanje dobrovoljnim penzijskim fondovima u skladu sa propisima kojima se uređuju dobrovoljni penzijski fondovi i penzijski planovi', NULL, '2022-02-28', NULL, N'E'),
(50, N'PDV-RS-25-2-1', N'Zakon o Porezu na dodatu vrednost', '25', '2', '1', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet usluga osiguranja i reosiguranja, uključujući prateće usluge posrednika i agenta (zastupnika) u osiguranju', NULL, '2022-02-28', NULL, N'E'),
(51, N'PDV-RS-25-2-2', N'Zakon o Porezu na dodatu vrednost', '25', '2', '2', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet zemljišta, kao i na davanje u zakup tog zemljišta', NULL, '2022-02-28', NULL, N'E'),
(52, N'PDV-RS-25-2-3', N'Zakon o Porezu na dodatu vrednost', '25', '2', '3', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet objekata, osim prvog prenosa prava raspolaganja na novoizgrađenim građevinskim objektima ili ekonomski deljivim celinama u okviru tih objekata i prvog prenosa vlasničkog udela na novoizgrađenim građevinskim objektima ili ekonomski deljivim celinama u okviru tih objekata, kao i prometa objekata i ekonomski deljivih celina u okviru tih objekata, uključujući i vlasničke udele na tim dobrima, u slučaju kada je ugovorom na osnovu kojeg se vrši promet tih dobara, zaključenim između obveznika PDV, predviđeno da će se na taj promet obračunati PDV, pod uslovom da sticalac obračunati PDV može u potpunosti odbiti kao prethodni porez', NULL, '2022-02-28', NULL, N'E'),
(53, N'PDV-RS-25-2-3a', N'Zakon o Porezu na dodatu vrednost', '25', '2', '3a', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet dobara i usluga za koje pri nabavci obveznik nije imao pravo na odbitak prethodnog poreza', NULL, '2022-02-28', NULL, N'E'),
(54, N'PDV-RS-25-2-3b', N'Zakon o Porezu na dodatu vrednost', '25', '2', '3b', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet dobara za koja je u prethodnoj fazi prometa postojala obaveza plaćanja poreza u skladu sa zakonom kojim se uređuju porezi na imovinu', NULL, '2022-02-28', NULL, N'E'),
(55, N'PDV-RS-25-2-5', N'Zakon o Porezu na dodatu vrednost', '25', '2', '5', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet udela, hartija od vrednosti, poštanskih vrednosnica, taksenih i drugih važećih vrednosnica po njihovoj utisnutoj vrednosti u Republici, osim vlasničkih udela iz člana 4. ovog zakona', NULL, '2022-02-28', NULL, N'E'),
(56, N'PDV-RS-25-2-6', N'Zakon o Porezu na dodatu vrednost', '25', '2', '6', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet poštanskih usluga od strane javnog preduzeća, kao i sa njima povezanih isporuka dobara', NULL, '2022-02-28', NULL, N'E'),
(57, N'PDV-RS-25-2-7', N'Zakon o Porezu na dodatu vrednost', '25', '2', '7', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet usluga koje pružaju zdravstvene ustanove u skladu sa propisima koji regulišu zdravstvenu zaštitu, uključujući i smeštaj, negu i ishranu bolesnika u tim ustanovama, osim apoteka i apotekarskih ustanova', NULL, '2022-02-28', NULL, N'E'),
(58, N'PDV-RS-25-2-8', N'Zakon o Porezu na dodatu vrednost', '25', '2', '8', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet usluga koje pružaju lekari, stomatolozi ili druga lica u skladu sa propisima koji regulišu zdravstvenu zaštitu', NULL, '2022-02-28', NULL, N'E'),
(59, N'PDV-RS-25-2-9', N'Zakon o Porezu na dodatu vrednost', '25', '2', '9', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet usluga i isporuke zubne protetike u okviru delatnosti zubnog tehničara, kao i isporuka zubne protetike od strane stomatologa', NULL, '2022-02-28', NULL, N'E'),
(60, N'PDV-RS-25-2-10', N'Zakon o Porezu na dodatu vrednost', '25', '2', '10', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet ljudskih organa, tkiva, telesnih tečnosti i ćelija, krvi i majčinog mleka', NULL, '2022-02-28', NULL, N'E'),
(61, N'PDV-RS-25-2-11', N'Zakon o Porezu na dodatu vrednost', '25', '2', '11', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet usluga socijalnog staranja i zaštite, dečje zaštite i zaštite mladih, usluga ustanova socijalne zaštite, kao i sa njima neposredno povezanog prometa dobara i usluga od strane lica registrovanih za obavljanje tih delatnosti', NULL, '2022-02-28', NULL, N'E'),
(62, N'PDV-RS-25-2-12', N'Zakon o Porezu na dodatu vrednost', '25', '2', '12', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet usluga smeštaja i ishrane učenika i studenata u školskim i studentskim domovima ili sličnim ustanovama, kao i sa njima neposredno povezan promet dobara i usluga', NULL, '2022-02-28', NULL, N'E'),
(63, N'PDV-RS-25-2-13', N'Zakon o Porezu na dodatu vrednost', '25', '2', '13', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet usluga obrazovanja (predškolsko, osnovno, srednje, više i visoko) i profesionalne prekvalifikacije, kao i sa njima neposredno povezanog prometa dobara i usluga od strane lica registrovanih za obavljanje tih delatnosti, ako se ove delatnosti obavljaju u skladu sa propisima koji uređuju tu oblast', NULL, '2022-02-28', NULL, N'E'),
(64, N'PDV-RS-25-2-14', N'Zakon o Porezu na dodatu vrednost', '25', '2', '14', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet usluga iz oblasti kulture i sa njima neposredno povezanog prometa dobara i usluga, od strane lica čija delatnost nije usmerena ka ostvarivanju dobiti, a koja su registrovana za tu delatnost', NULL, '2022-02-28', NULL, N'E'),
(65, N'PDV-RS-25-2-15', N'Zakon o Porezu na dodatu vrednost', '25', '2', '15', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet usluga iz oblasti nauke i sa njima neposredno povezanog prometa dobara i usluga, od strane lica čija delatnost nije usmerena ka ostvarivanju dobiti, a koja su registrovana za tu delatnost', NULL, '2022-02-28', NULL, N'E'),
(66, N'PDV-RS-25-2-16', N'Zakon o Porezu na dodatu vrednost', '25', '2', '16', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet usluga verskog karaktera od strane registrovanih crkava i verskih zajednica i sa njima neposredno povezanog prometa dobara i usluga', NULL, '2022-02-28', NULL, N'E'),
(67, N'PDV-RS-25-2-17', N'Zakon o Porezu na dodatu vrednost', '25', '2', '17', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet usluga javnog radiodifuznog servisa, osim usluga komercijalnog karaktera', NULL, '2022-02-28', NULL, N'E'),
(68, N'PDV-RS-25-2-18', N'Zakon o Porezu na dodatu vrednost', '25', '2', '18', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet usluga priređivanja igara na sreću', NULL, '2022-02-28', NULL, N'E'),
(69, N'PDV-RS-25-2-19', N'Zakon o Porezu na dodatu vrednost', '25', '2', '19', NULL, N'Poresko oslobođenje bez prava na odbitak prethodnog poreza za promet usluga iz oblasti sporta i fizičkog vaspitanja licima koja se bave sportom i fizičkim vaspitanjem, od strane lica čija delatnost nije usmerena ka ostvarivanju dobiti, a koja su registrovana za tu delatnost', NULL, '2022-02-28', NULL, N'E'),
(70, N'PDV-RS-36b-6', N'Zakon o Porezu na dodatu vrednost', '36b', '6', NULL, NULL, N'Poreski dužnik za promet investicionog zlata iz stava 5. ovog člana je obveznik PDV kojem je taj promet izvršen', NULL, '2022-02-28', NULL, N'AE'),
(71, N'PDV-RS-6-1-1', N'Zakon o Porezu na dodatu vrednost', '6', '1', '1', NULL, N'Smatra se da promet dobara i usluga nije izvršen kod prenosa celokupne ili dela imovine, sa ili bez naknade, ili kao ulog, ako je sticalac poreski obveznik ili tim prenosom postane poreski obveznik i ako produži da obavlja istu delatnost', NULL, '2022-04-07', NULL, N'R'),
(72, N'PDV-RS-6a', N'Zakon o Porezu na dodatu vrednost', '6', NULL, NULL, NULL, N'Smatra se da, u smislu ovog zakona, promet dobara i usluga koji vrši davalac koncesije koncesionaru, odnosno koncesionar davaocu koncesije u okviru realizacije ugovora o javno-privatnom partnerstvu sa elementima koncesije, zaključenog u skladu sa zakonom kojim se uređuju javno-privatno partnerstvo i koncesije, nije izvršen, ako su davalac koncesije i koncesionar obveznici PDV koji bi, u slučaju kada bi se taj promet smatrao izvršenim, imali u potpunosti pravo na odbitak prethodnog poreza u skladu sa ovim zakonom', NULL, '2022-04-07', NULL, N'R'),
(73, N'PDV-RS-24-1-1', N'Zakon o Porezu na dodatu vrednost', '24', '1', '1', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnok poreza za prevozne i ostale usluge, koje su povezane sa uvozom dobara, ako je vrednost tih usluga sadržana u osnovici iz člana 19. stav 2. ovog zakona', NULL, '2022-04-07', NULL, N'Z'),
(74, N'PDV-RS-24-1-2', N'Zakon o Porezu na dodatu vrednost', '24', '1', '2', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za promet dobara koja obveznik ili treće lice, po njegovom nalogu, šalje ili otprema u inostranstvo', NULL, '2022-04-07', NULL, N'Z'),
(75, N'PDV-RS-24-1-3', N'Zakon o Porezu na dodatu vrednost', '24', '1', '3', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za promet dobara koja inostrani primalac ili treće lice, po njegovom nalogu, šalje ili otprema u inostranstvo', NULL, '2022-04-07', NULL, N'Z'),
(76, N'PDV-RS-24-1-5', N'Zakon o Porezu na dodatu vrednost', '24', '1', '5', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za unos dobara u slobodnu zonu, prevozne i druge usluge korisnicima slobodnih zona koje su neposredno povezane sa tim unosom i promet dobara i usluga u slobodnoj zoni, za koje bi obveznik - korisnik slobodne zone imao pravo na odbitak prethodnog poreza kada bi ta dobra ili usluge nabavljao za potrebe obavljanja delatnosti van slobodne zone', NULL, '2022-04-07', NULL, N'Z'),
(77, N'PDV-RS-24-1-5a', N'Zakon o Porezu na dodatu vrednost', '24', '1', '5a', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za promet dobara koja se unose u slobodnu zonu, prevozne i druge usluge koje su neposredno povezane sa tim unosom i promet dobara u slobodnoj zoni, koji se vrši stranom licu koje ima zaključen ugovor sa obveznikom PDV - korisnikom slobodne zone da ta dobra ugradi u dobra namenjena otpremanju u inostranstvo', NULL, '2022-04-07', NULL, N'Z'),
(78, N'PDV-RS-24-1-6', N'Zakon o Porezu na dodatu vrednost', '24', '1', '6', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za promet dobara koja su u postupku carinskog skladištenja', NULL, '2022-04-07', NULL, N'Z'),
(79, N'PDV-RS-24-1-6a', N'Zakon o Porezu na dodatu vrednost', '24', '1', '6a', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za otpremanje dobara u slobodne carinske prodavnice otvorene na vazduhoplovnim pristaništima otvorenim za međunarodni saobraćaj na kojima je organizovana pasoška i carinska kontrola radi prodaje putnicima u skladu sa carinskim propisima, kao i na isporuku dobara iz slobodnih carinskih prodavnica', NULL, '2022-04-07', NULL, N'Z'),
(80, N'PDV-RS-24-1-7', N'Zakon o Porezu na dodatu vrednost', '24', '1', '7', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za usluge radova na pokretnim dobrima nabavljenim od strane inostranog primaoca usluge u Republici, ili koja su uvezena radi oplemenjivanja, opravke ili ugradnje, a koja posle oplemenjivanja, opravke ili ugradnje, isporučilac usluge, inostrani primalac ili treće lice, po njihovom nalogu, prevozi ili otprema u inostranstvo', NULL, '2022-04-07', NULL, N'Z'),
(81, N'PDV-RS-24-1-7a', N'Zakon o Porezu na dodatu vrednost', '24', '1', '7a', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za promet dobara koja su u postupku aktivnog oplemenjivanja za koja bi obveznik - sticalac imao pravo na odbitak prethodnog poreza kada bi ta dobra nabavljao sa obračunatim PDV', NULL, '2022-04-07', NULL, N'Z'),
(82, N'PDV-RS-24-1-8', N'Zakon o Porezu na dodatu vrednost', '24', '1', '8', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za prevozne i ostale usluge koje su u vezi sa izvozom, tranzitom ili privremenim uvozom dobara, osim usluga koje su oslobođene od PDV bez prava na poreski odbitak u skladu sa ovim zakonom', NULL, '2022-04-07', NULL, N'Z'),
(83, N'PDV-RS-24-1-9', N'Zakon o Porezu na dodatu vrednost', '24', '1', '9', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za usluge međunarodnog prevoza lica u vazdušnom saobraćaju, s tim što za nerezidentno vazduhoplovno preduzeće poresko oslobođenje važi samo u slučaju uzajamnosti', NULL, '2022-04-07', NULL, N'Z'),
(84, N'PDV-RS-24-1-10', N'Zakon o Porezu na dodatu vrednost', '24', '1', '10', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za isporuke letilica, servisiranje, popravke, održavanje, čarterisanje i iznajmljivanje letilica, koje se pretežno koriste uz naknadu u međunarodnom vazdušnom saobraćaju, kao i isporuke, iznajmljivanje, popravke i održavanje dobara namenjenih opremanju tih letilica', NULL, '2022-04-07', NULL, N'Z'),
(85, N'PDV-RS-24-1-11', N'Zakon o Porezu na dodatu vrednost', '24', '1', '11', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za promet dobara i usluga namenjenih neposrednim potrebama letilica iz tačke 10) ovog stava', NULL, '2022-04-07', NULL, N'Z'),
(86, N'PDV-RS-24-1-12', N'Zakon o Porezu na dodatu vrednost', '24', '1', '12', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za usluge međunarodnog prevoza lica brodovima u rečnom saobraćaju, s tim što za nerezidentno preduzeće koje vrši međunarodni prevoz lica brodovima u rečnom saobraćaju, poresko oslobođenje važi samo u slučaju uzajamnosti', NULL, '2022-04-07', NULL, N'Z'),
(87, N'PDV-RS-24-1-13', N'Zakon o Porezu na dodatu vrednost', '24', '1', '13', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za isporuke brodova, servisiranje, popravke, održavanje i iznajmljivanje brodova, koji se pretežno koriste uz naknadu u međunarodnom rečnom saobraćaju, kao i isporuke, iznajmljivanje, popravke i održavanje dobara namenjenih opremanju tih brodova', NULL, '2022-04-07', NULL, N'Z'),
(88, N'PDV-RS-24-1-14', N'Zakon o Porezu na dodatu vrednost', '24', '1', '14', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za promet dobara i usluga namenjenih neposrednim potrebama brodova iz tačke 13) ovog stava', NULL, '2022-04-07', NULL, N'Z'),
(89, N'PDV-RS-24-1-15', N'Zakon o Porezu na dodatu vrednost', '24', '1', '15', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za isporuke zlata Narodnoj banci Srbije', NULL, '2022-04-07', NULL, N'Z'),
(90, N'PDV-RS-24-1-16-1', N'Zakon o Porezu na dodatu vrednost', '24', '1', '16', '1', N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za dobra i usluge namenjene za službene potrebe diplomatskih i konzularnih predstavništava', NULL, '2022-04-07', NULL, N'Z'),
(91, N'PDV-RS-24-1-16-2', N'Zakon o Porezu na dodatu vrednost', '24', '1', '16', '2', N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za dobra i usluge namenjene za službene potrebe međunarodnih organizacija, ako je to predviđeno međunarodnim ugovorom', NULL, '2022-04-07', NULL, N'Z'),
(92, N'PDV-RS-24-1-16-3', N'Zakon o Porezu na dodatu vrednost', '24', '1', '16', '3', N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za dobra i usluge namenjene za lične potrebe stranog osoblja diplomatskih i konzularnih predstavništava, uključujući i članove njihovih porodica', NULL, '2022-04-07', NULL, N'Z'),
(93, N'PDV-RS-24-1-16-4', N'Zakon o Porezu na dodatu vrednost', '24', '1', '16', '4', N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za dobra i usluge namenjene za lične potrebe stranog osoblja međunarodnih organizacija, uključujući članove njihovih porodica, ako je to predviđeno međunarodnim ugovorom', NULL, '2022-04-07', NULL, N'Z'),
(94, N'PDV-RS-24-1-16a', N'Zakon o Porezu na dodatu vrednost', '24', '1', '16a', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za promet dobara i usluga koji se vrši u skladu sa ugovorima o donaciji zaključenim sa državnom zajednicom Srbija i Crna Gora, odnosno Republikom, ako je tim ugovorom predviđeno da se iz dobijenih novčanih sredstava neće plaćati troškovi poreza, u delu koji se finansira dobijenim novčanim sredstvima osim ako ratifikovanim međunarodnim ugovorom nije drukčije predviđeno', NULL, '2022-04-07', NULL, N'Z'),
(95, N'PDV-RS-24-1-16b', N'Zakon o Porezu na dodatu vrednost', '24', '1', '16b', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za promet dobara i usluga koji se vrši u skladu sa ugovorima o kreditu, odnosno zajmu, zaključenim između državne zajednice Srbija i Crna Gora, odnosno Republike i međunarodne finansijske organizacije, odnosno druge države, kao i između treće strane i međunarodne finansijske organizacije, odnosno druge države u kojem se Republika Srbija pojavljuje kao garant, odnosno kontragarant, u delu koji se finansira dobijenim novčanim sredstvima, ako je tim ugovorima predviđeno da se iz dobijenih novčanih sredstava neće plaćati troškovi poreza', NULL, '2022-04-07', NULL, N'Z'),
(96, N'PDV-RS-24-1-16v', N'Zakon o Porezu na dodatu vrednost', '24', '1', '16v', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za promet dobara i usluga koji se vrši na osnovu međunarodnih ugovora, ako je tim ugovorima predviđeno poresko oslobođenje, osim međunarodnih ugovora iz tač. 16a) i 16b) ovog stava', NULL, '2022-04-07', NULL, N'Z'),
(97, N'PDV-RS-24-1-16g', N'Zakon o Porezu na dodatu vrednost', '24', '1', '16g', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za promet dobara i usluga koji se vrši u okviru realizacije infrastrukturnih projekata izgradnje autoputeva za koje je posebnim zakonom utvrđen javni interes', NULL, '2022-04-07', NULL, N'Z'),
(98, N'PDV-RS-24-1-17', N'Zakon o Porezu na dodatu vrednost', '24', '1', '17', NULL, N'Poresko oslobođenje sa pravom na odbitak prethodnog poreza za usluge posredovanja koje se odnose na promet dobara i usluga iz tač. 1) - 16) ovog stava', NULL, '2022-04-07', NULL, N'Z'),
(99, N'PDV-RS-61', N'Zakon o Porezu na dodatu vrednost', '61', NULL, NULL, NULL, N'Promet dobara sa teritorije Republike van APKM na teritoriju APKM', NULL, '2022-04-07', NULL, N'Z'),
(100, N'PDV-RS-33', N'Zakon o Porezu na dodatu vrednost', '33', NULL, NULL, NULL, N'Promet dobara i usluga koji vrši mali obveznik', NULL, '2022-04-07', NULL, N'SS'),
(101, N'PDV-RS-35-7', N'Zakon o Porezu na dodatu vrednost', '35', '7', NULL, NULL, N'Turistička agencija za turističke usluge iz stava 1. ovog člana ne može da iskazuje PDV u računima ili drugim dokumentima i nema pravo na odbitak prethodnog poreza na osnovu prethodnih turističkih usluga koje su joj iskazane u računu', NULL, '2022-04-07', NULL, N'SS'),
(102, N'PDV-RS-36-5', N'Zakon o Porezu na dodatu vrednost', '36', '5', NULL, NULL, N'Kod prometa dobara iz stava 1. ovog člana na koji se primenjuje oporezivanje razlike, obveznik ne može iskazivati PDV u računima ili drugim dokumentima', NULL, '2022-04-07', NULL, N'SS'),
(103, N'PDV-RS-36b-4', N'Zakon o Porezu na dodatu vrednost', '36b', '4', NULL, NULL, N'PDV se ne plaća na:\r\n1) promet i uvoz investicionog zlata, uključujući i investiciono zlato čija je vrednost navedena u potvrdama o alociranom ili nealociranom zlatu, zlato kojim se trguje preko računa za trgovanje zlatom, uključujući i zajmove i zamene zlata(svop poslovi) koji podrazumevaju pravo vlasništva ili potraživanja u vezi sa zlatom, kao i aktivnosti u vezi sa investicionim zlatom na osnovu fjučers i forvard ugovora čiji je rezultat prenos prava raspolaganja ili prava potraživanja u vezi sa investicionim zlatom;\r\n2) promet usluga posrednika koji u ime i za račun nalogodavca vrši promet investicionog zlata', NULL, '2022-04-07', NULL, N'SS'),
(104, N'PDV-RS-17-4-2', N'Zakon o Porezu na dodatu vrednost', '17', '4', '2', NULL, N'Osnovica ne sadrži iznose koje obveznik naplaćuje u ime i za račun drugog, ako te iznose prenosi licu u čije ime i za čiji račun je izvršio naplatu i ako su ti iznosi posebno evidentirani', NULL, '2022-04-27', NULL, N'OE'),
(105, N'PDV-RS-17-4-3', N'Zakon o Porezu na dodatu vrednost', '17', '4', '3', NULL, N'Osnovica ne sadrži iznose koje obveznik potražuje za izdatke koje je platio u ime i za račun primaoca dobara ili usluga, ako su ti iznosi posebno evidentirani', NULL, '2022-04-27', NULL, N'OE'),
(106, N'PDV-RS-N', N'Zakon o Porezu na dodatu vrednost', '0', '0', '0', NULL, N'Član zakona za N poresku kategoriju nije definisan', NULL, '2022-04-27', NULL, N'N')

IF OBJECT_ID('dbo.Document') IS NOT NULL
BEGIN
    DROP TABLE dbo.InvoiceLine
	DROP TABLE dbo.InvoiceAdditionalDocumentReference
	DROP TABLE dbo.InvoiceLegalMonetaryTotal
	DROP TABLE dbo.InvoiceTaxSubtotal
	DROP TABLE dbo.Invoice
	DROP TABLE dbo.Party
	DROP TABLE dbo.DocumentChange
	DROP TABLE dbo.DocumentDetail
	DROP TABLE dbo.Document
	DROP TABLE dbo.[File]
END

IF OBJECT_ID('dbo.DocumentChange') IS NOT NULL
    DROP TABLE dbo.DocumentChange

CREATE TABLE dbo.DocumentChange
(
    Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	EventId INT NOT NULL,
    EventDate DATETIME NOT NULL,
	PurchaseInvoiceId INT NOT NULL,
	CirInvoiceId NVARCHAR(32) NULL,
    PurchaseInvoiceStatus NVARCHAR(32) NOT NULL,
    SubscriptionKey NVARCHAR(128) NULL,
	Comment NVARCHAR(1024) NULL,
	SyncDate DATETIME NOT NULL DEFAULT GETDATE()
)

IF OBJECT_ID('dbo.[File]') IS NOT NULL
    DROP TABLE dbo.[File]

CREATE TABLE dbo.[File]
(
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name] NVARCHAR(1024) NOT NULL,
	[Path] NVARCHAR(1024) NULL,
	MimeCode VARCHAR(32) NOT NULL,
    BinaryDoc VARBINARY(MAX) NULL
)

CREATE TABLE dbo.Document
(
    Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	SalesInvoiceId INT NOT NULL,
    PurchaseInvoiceId INT NOT NULL,
    DocumentId UNIQUEIDENTIFIER NOT NULL,
    CreationDate DATETIME NOT NULL,
	SendingDate DATETIME NOT NULL,
	SyncDate DATETIME NOT NULL DEFAULT GETDATE(),
	FileId INT NULL CONSTRAINT FK_DocumentPdf_FileId FOREIGN KEY REFERENCES dbo.[File](Id),
	IsActive BIT NOT NULL DEFAULT 1
)

IF OBJECT_ID('dbo.DocumentDetail') IS NOT NULL
    DROP TABLE dbo.DocumentDetail

CREATE TABLE dbo.DocumentDetail
(
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	DocumentId INT NOT NULL CONSTRAINT FK_DocumentDetail_DocumentId FOREIGN KEY REFERENCES dbo.Document(Id),
	PurchaseInvoiceStatus NVARCHAR(32) NOT NULL,
	CirInvoiceId NVARCHAR(32) NULL,
	CirInvoiceStatus NVARCHAR(32) NOT NULL,
	CirSettledAmount DECIMAL(19,2) NOT NULL,
	VatNumberFactoringCompany NVARCHAR(32) NULL,
	FactoringContractNumber NVARCHAR(64) NULL,
	[Comment] NVARCHAR(1024) NULL,
	CancelComment NVARCHAR(1024) NULL,
	StornoComment NVARCHAR(1024) NULL,
	[Version] INT NOT NULL,
	LastModifiedUtc DATETIME NOT NULL,
	SyncDate DATETIME NOT NULL DEFAULT GETDATE()
)

IF OBJECT_ID('dbo.Party') IS NOT NULL
    DROP TABLE dbo.Party

CREATE TABLE dbo.Party
(
    Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	EndpointId VARCHAR(32) NOT NULL,
    EndpointSchemeId INT NOT NULL,
	IdentificationId NVARCHAR(128) NULL,
	[Name] NVARCHAR(256) NULL,
	AddressStreetName NVARCHAR(256) NULL,
	AddressCityName NVARCHAR(128) NULL,
	AddressPostalZone NVARCHAR(128) NULL,
    AddressCountryIdentificationCode NVARCHAR(32) NULL,
	TaxSchemeId NVARCHAR(32) NULL,
	TaxSchemeCompanyId NVARCHAR(128) NULL,
	TaxSchemeRegistrationName NVARCHAR(128) NULL,
    LegalEntityCompanyId NVARCHAR(32) NULL,
	LegalEntityRegistrationName NVARCHAR(256) NULL,
	ContactName NVARCHAR(128) NULL,
	ContactEmail NVARCHAR(128) NULL,
)

IF OBJECT_ID('dbo.Invoice') IS NOT NULL
    DROP TABLE dbo.Invoice

CREATE TABLE dbo.Invoice
(
    Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	DocumentId INT NOT NULL CONSTRAINT FK_Invoice_DocumentId FOREIGN KEY REFERENCES dbo.Document(Id),
	CustomizationId VARCHAR(128) NULL,
    InvoiceId NVARCHAR(128) NOT NULL,
    IssueDate DATETIME NOT NULL,
    DueDate DATETIME NULL,
	TaxPointDate DATETIME NULL,
	InvoiceTypeCode INT NOT NULL,
	DocumentCurrencyCode CHAR(3) NOT NULL DEFAULT 'RSD',
	InvoicePeriodCode INT NOT NULL,
	AccountingSupplierPartyId INT NOT NULL CONSTRAINT FK_Invoice_SupplierPartyId FOREIGN KEY REFERENCES dbo.Party(Id),
	AccountingCustomerPartyId INT NOT NULL CONSTRAINT FK_Invoice_CustomerPartyId FOREIGN KEY REFERENCES dbo.Party(Id),
	ActualDeliveryDate DATETIME NULL,
	PaymentMeansId NVARCHAR(64) NULL,
	PaymentMeansCode INT NOT NULL,
	PaymentId NVARCHAR(64) NULL,
	PayerFinancialAccountId NVARCHAR(256) NULL,
	PayeeFinancialAccountId NVARCHAR(256) NOT NULL,
	TotalAmount DECIMAL(19,2) NOT NULL,
	OrderReferenceId NVARCHAR(512) NULL,
	DocumentReferenceId NVARCHAR(128) NULL,
	ContractDocumentReferenceId NVARCHAR(1024) NULL,
	OriginatorDocumentReferenceId NVARCHAR(128) NULL,
	Note NVARCHAR(MAX) NULL
)

IF OBJECT_ID('dbo.InvoiceAdditionalDocumentReference') IS NOT NULL
    DROP TABLE dbo.InvoiceAdditionalDocumentReference

CREATE TABLE dbo.InvoiceAdditionalDocumentReference
(
    Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	InvoiceId INT NOT NULL CONSTRAINT FK_InvoiceAdditionalDocumentReference_InvoiceId FOREIGN KEY REFERENCES dbo.Invoice(Id),
	FileId INT NOT NULL CONSTRAINT FK_InvoiceAdditionalDocumentReference_FileId FOREIGN KEY REFERENCES dbo.[File](Id)
)

IF OBJECT_ID('dbo.InvoiceTaxSubtotal') IS NOT NULL
    DROP TABLE dbo.InvoiceTaxSubtotal

CREATE TABLE dbo.InvoiceTaxSubtotal
(
    Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	InvoiceId INT NOT NULL CONSTRAINT FK_InvoiceTaxSubtotal_InvoiceId FOREIGN KEY REFERENCES dbo.Invoice(Id),
	SubtotalAmount DECIMAL(19,2) NOT NULL,
	SubtotalTaxableAmount DECIMAL(19,2) NOT NULL,
	SubtotalTaxCategory NVARCHAR(2) NOT NULL,
	SubtotalTaxCategoryTaxExemptionReasonCode NVARCHAR(32) NULL,
	SubtotalTaxCategoryTaxExemptionReason NVARCHAR(1024) NULL,
	SubtotalTaxCategoryPercent DECIMAL(5,2) NOT NULL,
	SubtotalTaxCategoryTaxScheme NVARCHAR(3) NOT NULL
)

IF OBJECT_ID('dbo.InvoiceLegalMonetaryTotal') IS NOT NULL
    DROP TABLE dbo.InvoiceLegalMonetaryTotal

CREATE TABLE dbo.InvoiceLegalMonetaryTotal
(
    Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	InvoiceId INT NOT NULL CONSTRAINT FK_InvoiceLegalMonetaryTotal_InvoiceId FOREIGN KEY REFERENCES dbo.Invoice(Id),
	LineExtensionAmount DECIMAL(19,2) NOT NULL,
	TaxExclusiveAmount DECIMAL(19,2) NOT NULL,
	TaxInclusiveAmount DECIMAL(19,2) NOT NULL,
	AllowanceTotalAmount DECIMAL(19,2) NOT NULL,
	PrepaidAmount DECIMAL(19,2) NOT NULL,
	PayableAmount DECIMAL(19,2) NOT NULL
)

IF OBJECT_ID('dbo.InvoiceLine') IS NOT NULL
    DROP TABLE dbo.InvoiceLine

CREATE TABLE dbo.InvoiceLine
(
    Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	InvoiceId INT NOT NULL CONSTRAINT FK_InvoiceLine_InvoiceId FOREIGN KEY REFERENCES dbo.Invoice(Id),
	LineId NVARCHAR(32) NULL,
	InvoicedQuantity DECIMAL(19,2) NOT NULL,
	InvoicedQuantityUnitCode NVARCHAR(32) NULL,
	LineExtensionAmount DECIMAL(19,2) NOT NULL,
	AllowanceChargeIndicator BIT NOT NULL,
	AllowanceChargeMultiplierFactorNumeric DECIMAL(19,2) NOT NULL,
	AllowanceChargeAmount DECIMAL(19,2) NOT NULL,
    [Name] NVARCHAR(2048) NULL,
    SellersItemIdentification NVARCHAR(512) NULL,
	ClassifiedTaxCategory NVARCHAR(6) NULL,
	ClassifiedTaxCategoryPercent DECIMAL(5,2) NOT NULL,
	ClassifiedTaxCategoryTaxScheme NVARCHAR(6) NULL,
	PriceAmount DECIMAL(19,2) NOT NULL
)
