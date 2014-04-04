Wenn Sie diese Vorlage mit Windows Azure-Authentifizierung verwenden möchten, lesen Sie http://go.microsoft.com/fwlink/?LinkID=267940:

Wenn Sie diese Vorlage hingegen mit Windows-Authentifizierung verwenden möchten, lesen Sie die nachstehenden Anweisungen:

Hosting unter IIS Express:
1. Klicken Sie im Projektmappen-Explorer auf das Projekt, um es auszuwählen.
2. Wenn der Bereich "Eigenschaften" nicht geöffnet ist, öffnen Sie ihn (F4).
3. Nehmen Sie im Bereich "Eigenschaften" des Projekts die folgenden Einstellungen vor:
   a) Legen Sie für "Anonyme Authentifizierung" die Option "Deaktiviert" fest.
   b) Legen Sie für "Windows-Authentifizierung" die Option "Aktiviert" fest.

Hosting unter IIS 7 oder höher:
1. Öffnen Sie den IIS-Manager, und navigieren Sie zu Ihrer Website.
2. Doppelklicken Sie in der Ansicht "Features" auf "Authentifizierung".
3. Wählen Sie auf der Seite "Authentifizierung" die Option "Windows-Authentifizierung" aus. Wenn Windows-
   Authentifizierung nicht als Option angeboten wird, müssen Sie sicherstellen, dass die Windows-Authentifizierung
   auf dem Server installiert ist.

      So aktivieren Sie die Windows-Authentifizierung für Windows:
      a) Rufen Sie in der Systemsteuerung die Option "Programme und Funktionen" auf.
      b) Wählen Sie "Windows-Funktionen ein- oder ausschalten" aus.
      c) Navigieren Sie zu "Internetinformationsdienste > World Wide Web-Dienste > Sicherheit",
         und stellen Sie sicher, dass der Knoten "Windows-Authentifizierung" aktiviert ist.

      So aktivieren Sie die Windows-Authentifizierung für Windows Server:
      a) Wählen Sie im Server-Manager die Option "Webserver (IIS)" aus, und klicken Sie dann auf "Rollendienste hinzufügen".
      b) Navigieren Sie zu "Webserver > Sicherheit",
         und stellen Sie sicher, dass der Knoten "Windows-Authentifizierung" aktiviert ist.

4. Klicken Sie im Bereich "Aktionen" auf "Aktivieren", um die Windows-Authentifizierung zu aktivieren.
5. Wählen Sie auf der Seite "Authentifizierung" die Option "Anonyme Authentifizierung" aus.
6. Klicken Sie im Bereich "Aktionen" auf "Deaktivieren", um die anonyme Authentifizierung zu deaktivieren.