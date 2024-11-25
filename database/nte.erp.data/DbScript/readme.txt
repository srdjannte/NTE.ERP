Moguci pozivi:

* configName = "Primer01"
* apiKeyName = configName + "ApiKey" -> "Primer01ApiKey"	  (podrazumevano ApiKey)
* dbContextName = configName + "Context" -> "Primer01Context" (podrazumevano EfaktureContext)
* documentPathName = configName + "Context" -> "Primer01Path" (podrazumevano DocumentsPath)

1. Preuzimanje svih ulaznih faktura koji su dostupni na servisu (podrazumevano u poslednjih 60 dana)
   Napomena: ukoliko je potrebno da se uradi potpuna sinhronizacja 
 	     neophodno je da se u konfiguraciji navede parametar FullInitialSync = true
eFaktureSynchronizer [-c[configName]]
->   eFaktureSynchronizer
->   eFaktureSynchronizer -c[Primer01]
*napomena: parametar [-c[configName]] nije obavezan ni u slučaju ako je u .config fajlu navedeno više konfiguracija
					 ukoliko se ne navede [-c[configName]] onda se radi sinhronizacija za sve konfiguracije iz .config fajla
					 ukoliko se navede [-c[configName]] onda se radi sinhronizacija samo za navenednu konfiguraciju ako postoji u .config fajlu

2. Preuzimanje ulaznih faktura čija se promena statusa dogodila na određeni dan
eFaktureSynchronizer [-c[configName]] [dateFrom] [dateTo]   			
->   eFaktureSynchronizer 25.04.2022							- vrši se preuzimanje faktura čije su se promene desile tačno na navedeni dan
->   eFaktureSynchronizer -c[Primer01] 25.04.2022				- vrši se preuzimanje faktura za navedenu konfiguraciju čije su se promene desile tačno na navedeni dan
->   eFaktureSynchronizer 25.04.2022 30.04.2022					- vrši se preuzimanje faktura čije su se promene desile u periodu između dva navedena datuma (uključujući i te dane)
->   eFaktureSynchronizer -c[Primer01] 25.04.2022 30.04.2022	- vrši se preuzimanje faktura za navedenu konfiguraciju čije su se promene desile u periodu između dva navedena datuma (uključujući i te dane)
*napomena: parametar [-c[configName]] nije obavezan ni u slučaju ako je u .config fajlu navedeno više konfiguracija
					 ukoliko se ne navede [-c[configName]] onda se radi sinhronizacija za sve konfiguracije iz .config fajla
					 ukoliko se navede [-c[configName]] onda se radi sinhronizacija samo za navenednu konfiguraciju ako postoji u .config fajlu

3. Preuzimanje ulaznih faktura čija se promena statusa dogodila u određenom periodu (maksimalno u prethodih 60 dana)
eFaktureSynchronizer [-c[configName]] [dateRange]
->   eFaktureSynchronizer -60
->   eFaktureSynchronizer -c[Primer01] -60
*napomena: parametar [-c[configName]] nije obavezan ni u slučaju ako je u .config fajlu navedeno više konfiguracija
					 ukoliko se ne navede [-c[configName]] onda se radi sinhronizacija za sve konfiguracije iz .config fajla
					 ukoliko se navede [-c[configName]] onda se radi sinhronizacija samo za navenednu konfiguraciju ako postoji u .config fajlu

4. Preuzimanje ulazne fakture po njenom jedinstvenom identifikatoru
eFaktureSynchronizer [-c[configName]] [purchaseInvoiceId]
->   eFaktureSynchronizer 123456					- validan poziv samo ako je u .config fajlu definisana jedna konfiguracija
->   eFaktureSynchronizer -c[Primer01] 123456		- validan poziv ako je u .config fajlu definisana jedna ili više konfiguracija
*napomena: parametar [-c[configName]] je obavezan u slučaju ako je u .config fajlu navedeno više konfiguracija
					 ukoliko se ne navede [-c[configName]] onda se radi sinhronizacija za jedinu navedenu konfiguraciju iz .config fajla
					 ukoliko se navede [-c[configName]] onda se radi sinhronizacija samo za navenednu konfiguraciju ako postoji u .config fajlu

5. Prihvatanje ili odbijanje fakture po njenom jedinstvenom identifikatoru
eFaktureSynchronizer [-c[configName]] [purchaseInvoiceId] [true/false] [comment]
->   eFaktureSynchronizer 123456 true "Prihvaćena faktura" 							- prihvata se primljena faktura, a navođenje komentara nije obavezano (jedna definisana konfiguracija)
->   eFaktureSynchronizer 123456 false "Neispravan iznos na fakturi" 				- odbija se primljena faktura, a navođenje komentara je obavezan (jedna definisana konfiguracija)
->   eFaktureSynchronizer -c[Primer01] 123456 true "Prihvaćena faktura" 			- prihvata se primljena faktura za navedenu konfiguraciju, a navođenje komentara nije obavezano (jedna ili više definisanih konfiguracija)
->   eFaktureSynchronizer -c[Primer01] 123456 false "Neispravan iznos na fakturi" 	- odbija se primljena faktura za navedenu konfiguraciju, a navođenje komentara je obavezan (jedna ili više definisanih konfiguracija)
*napomena: parametar [-c[configName]] je obavezan u slučaju ako je u .config fajlu navedeno više konfiguracija
					 ukoliko se ne navede [-c[configName]] onda se radi sinhronizacija za jedinu navedenu konfiguraciju iz .config fajla
					 ukoliko se navede [-c[configName]] onda se radi sinhronizacija samo za navenednu konfiguraciju ako postoji u .config fajlu

6. Učitavanje jednog XML-a (UBL format) u bazu sa fajl sistema
eFaktureSynchronizer [-c[configName]] xml [fajl.xml]
->   eFaktureSynchronizer xml C:\XML_fajlovi\08-22-001-00091989.xml 				- putanja do fajla mora biti apsolutna i u UBL formatu (jedna definisana konfiguracija)
->   eFaktureSynchronizer -c[Primer01] xml C:\XML_fajlovi\08-22-001-00091989.xml 	- putanja do fajla mora biti apsolutna i u UBL formatu (jedna ili više definisanih konfiguracija)
*napomena: parametar [-c[configName]] je obavezan u slučaju ako je u .config fajlu navedeno više konfiguracija
					 ukoliko se ne navede [-c[configName]] onda se radi sinhronizacija za jedinu navedenu konfiguraciju iz .config fajla
					 ukoliko se navede [-c[configName]] onda se radi sinhronizacija samo za navenednu konfiguraciju ako postoji u .config fajlu

7. Sinhronizacija trenutnog statusa fakture
eFaktureSynchronizer [-c[configName]] status [purchaseInvoiceId]
->   eFaktureSynchronizer status 123456					- validan poziv samo ako je u .config fajlu definisana jedna konfiguracija
->   eFaktureSynchronizer -c[Primer01] status 123456	- validan poziv ako je u .config fajlu definisana jedna ili više konfiguracija
*napomena: parametar [-c[configName]] je obavezan u slučaju ako je u .config fajlu navedeno više konfiguracija
					 ukoliko se ne navede [-c[configName]] onda se radi sinhronizacija za jedinu navedenu konfiguraciju iz .config fajla
					 ukoliko se navede [-c[configName]] onda se radi sinhronizacija samo za navenednu konfiguraciju ako postoji u .config fajlu