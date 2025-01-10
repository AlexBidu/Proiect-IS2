User Stories :

    1. Ca utilizator, vreau să pot crea un ticket, astfel încât să raportez o problemă.

    2. Ca administrator, vreau să vizualizez toate ticketele create, astfel încât să pot monitoriza progresul.
    
    3. Ca tehnician, vreau să primesc notificări când un ticket este atribuit, pentru a începe rezolvarea.
    
    4. Ca utilizator, vreau să editez sau să șterg un ticket, astfel încât să corectez informațiile greșite.
    
    5. Ca manager, vreau să filtrez ticketele după categorie, astfel încât să analizez performanța echipei IT.

1: Creare Ticket (Utilizator)
Descriere: Ca utilizator, vreau să pot crea un ticket, astfel încât să raportez o problemă.

Taskuri:
Frontend - Formular de creare ticket
  Creează un formular în frontend pentru a permite utilizatorului să introducă:
    Titlu
    Descriere
    Categorie (selectare dintr-o listă).
    Adaugă validare pentru câmpurile obligatorii.

Backend - Endpoint API POST /api/tickets
  Creează un endpoint care salvează ticketele în baza de date.
  Validează datele primite de la frontend (titlu, descriere, categorie).
  Baza de date - Salvarea ticketului

Adaugă logica necesară pentru a salva ticketele în tabela Ticket din baza de date.
  Verifică relațiile cu tabelele Category și Users.
  Testează că ticketele sunt create corect și salvate în baza de date.

2: Vizualizare Tickete (Administrator)
Descriere: Ca administrator, vreau să vizualizez toate ticketele create, astfel încât să pot monitoriza progresul.

Taskuri:
Frontend - Pagina de vizualizare tickete
  Creează o pagină care afișează toate ticketele existente.
  Include: titlul, descrierea, categoria, statusul și user-ul asociat.

Backend - Endpoint API GET /api/tickets
  Creează un endpoint care returnează toate ticketele din baza de date.
  Permite filtrarea după status (opțional).

User Story 3: Notificări pentru Tehnicieni
Descriere: Ca tehnician, vreau să primesc notificări când un ticket este atribuit, pentru a începe rezolvarea.

Taskuri:
Backend - Logica de atribuire a unui ticket
  Creează logica care atribuie automat sau manual un ticket unui tehnician.
Backend - Integrare sistem notificări
  Configurează un sistem de notificări prin e-mail folosind un serviciu precum SendGrid sau Nodemailer.
  Trimiterea notificărilor la adresa de e-mail a tehnicianului atribuit.

User Story 4: Editare și Ștergere Ticket (Utilizator)
Descriere: Ca utilizator, vreau să editez sau să șterg un ticket, astfel încât să corectez informațiile greșite.

Taskuri:
Frontend - Butoane de editare și ștergere ticket
  Adaugă butoane vizibile pentru utilizator la fiecare ticket (editare/ștergere).
Frontend - Formular de editare ticket
  Creează un formular similar cu cel de creare ticket, dar prepopulat cu datele existente.

Backend - Endpoint API PUT /api/tickets/{id} pentru editare
  Creează un endpoint care actualizează datele unui ticket existent în baza de date.
  Validează datele primite.
Backend - Endpoint API DELETE /api/tickets/{id} pentru ștergere
  Creează un endpoint care șterge un ticket din baza de date.
  Asigură-te că doar utilizatorul care a creat ticketul îl poate șterge.

5: Filtrare Tickete (Manager)
Descriere: Ca manager, vreau să filtrez ticketele după categorie, astfel încât să analizez performanța echipei IT.

Taskuri:
Frontend - Funcționalitate de filtrare
  Adaugă un dropdown sau câmp de selectare pe pagina de vizualizare tickete pentru a filtra după categorie.

Backend - Modificare Endpoint API GET /api/tickets
  Adaugă opțiunea de filtrare după categorie în endpoint-ul de listare a tickete-lor.


