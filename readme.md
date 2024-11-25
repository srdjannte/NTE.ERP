
select * from [dbo].[Dokumenta_fajlovi] a where a.IDDokumenta=18463



begin tran 

update Dokumenta_fajlovi set
Putanja = replace(putanja, '\\192.168.12.13\nte\Komecijala\PDF\', 'c:\Work\NTEERacun\xml\')
where IDDokumenta=18463

rollback commit

nteracun s or nteracun service 
nteracun e or nteracun editor
nteracun p or nteracun process

nteracun p 11000 
nteracun p 11000 test











 if (sender == this.ExportShemaTemplatesMainLoad)
        {
          this.ExportShemaTemplateTab.SelectedIndex = 0;
          if (this.openTemplateDialog.ShowDialog() == DialogResult.OK)
          {
            this.ExportShemaMainTemplate.Text = File.ReadAllText(this.openTemplateDialog.FileName);
          }
        }
        if (sender == this.ExportShemaTemplatesItemsLoad)
        {
          this.ExportShemaTemplateTab.SelectedIndex = 1;
          if (this.openTemplateDialog.ShowDialog() == DialogResult.OK)
          {
            this.ExportShemaItemsTemplate.Text = File.ReadAllText(this.openTemplateDialog.FileName);
          }
        }
        if (sender == this.ExportShemaTemplatesTaxesLoad)
        {
          this.ExportShemaTemplateTab.SelectedIndex = 2;
          if (this.openTemplateDialog.ShowDialog() == DialogResult.OK)
          {
            this.ExportShemaTaxesTemplate.Text = File.ReadAllText(this.openTemplateDialog.FileName);
          }
        }

        if (sender == this.ExportShemaTemplatesMainDefault)
        {
          this.ExportShemaMainTemplate.Text = Resources.TemplateMain;
          this.ExportShemaTemplateTab.SelectedIndex = 0;
        }
        if (sender == this.ExportShemaTemplatesItemsDefault)
        {
          this.ExportShemaItemsTemplate.Text = Resources.TemplateItems;
          this.ExportShemaTemplateTab.SelectedIndex = 1;
        }
        if (sender == this.ExportShemaTemplatesTaxesDefault)
        {
          this.ExportShemaTaxesTemplate.Text = Resources.TemplateTaxes;
          this.ExportShemaTemplateTab.SelectedIndex = 2;
        }


<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<connectionStrings>
		<add name="DefaultConnection" connectionString="Server=10.1.11.3;Database=ntefakture;User Id=nKte1sa2f;Password=I9yyX67.8YnhS;" />
		<add name="LocalConnection" connectionString="Server=10.1.11.3;Database=ntefakture;User Id=nKte1sa2f;Password=I9yyX67.8YnhS" />
	</connectionStrings>
	<appSettings>
		<add key="Connection" value="Default" />
		<add key="Enviroment" value="Production" />

		<add key="ProductionURI" value="https://efaktura.mfin.gov.rs/api/publicApi"/>
		<add key="ProductionAPIKey" value="cc89999a-ac6e-4551-b3ae-f5418bd61018" /> 

		<add key="DemoURI" value="https://demoefaktura.mfin.gov.rs/api/publicApi"/>
		<add key="DemoAPIKey" value="efb1db3e-95f2-4f93-b498-7547ee6676a3" />

		<add key="SaveXML" value="true" />
		<add key="XMLSavingLocation" value="d:\vb6\Malafirma\xml\" />
    		<add key="SavePdf" value="true" />
    		<add key="PDFSavingLocation" value="\\10.1.11.2\d\EFakturaPDF\GenerickaIzlaz\" />
	</appSettings>
</configuration>


<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <connectionStrings>
    <add name="EfaktureContext" connectionString="Data Source=10.1.11.3;Initial Catalog=NTEFakture;User ID=nKte1sa2f;password=I9yyX67.8YnhS;Trust Server Certificate=True;Connection Timeout=30" providerName="System.Data.SqlClient" />
  </connectionStrings>
  <appSettings>
    <add key="ApiUrl" value="https://efaktura.mfin.gov.rs/" />
    <!--NTE-->
    <add key="ApiKey" value="cc89999a-ac6e-4551-b3ae-f5418bd61018" />
    <add key="documentsPath" value="\\10.1.11.2\d\EFakturaPDF\Nabavka\" />
    <add key="batchSize" value="100" />
    <add key="saveFilesInDb" value="false" />
    <add key="FullInitialSync" value="false" />
  </appSettings>
</configuration>

