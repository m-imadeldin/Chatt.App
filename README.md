Praktisk Examination – Chatklient med Socket.IO
(Konsolapp)

## Se pdf för instruktioner.

Praktisk Examination – Chatklient med Socket.IO
(Konsolapp)
## Syfte

Ett konsolprojekt som använder Socket.IO för realtidskommunikation mellan användare.
Användaren kan ansluta, skicka och ta emot meddelanden, se när andra användare ansluter eller lämnar, samt hantera meddelandehistorik.

## Språk och verktyg

- C#
- .NET 
- SocketIOClient

## Funktioner

- Ange användarnamn vid start.

- Ansluta till chatten och se status (ansluten/urkopplad).

- Skicka och ta emot meddelanden i realtid med tidsstämpel och avsändare.

- Se händelser när användare joinar eller lämnar.

- Avsluta programmet snyggt.

- Kommandon: /help, /quit, /history [n], /dm <user> <text>.

- Persistens av meddelandehistorik mellan start.

## Estimat

- [] Skapa repo och projektstruktur             2
- []Installera SocketIOClient och konfigurera   1
- []Skapa User.cs                               0,5
- []Skapa Message.cs                            0,5        
- []Program.cs                                  1
- []MessageHistory (spara/ladda historik)       2
- []ChatClient (anslutning + events)            3
- []CommandHandler (kommandon)                  2
- []Testning och felsökning                     1
- []Förbättring                                 1

## Tidsåtgång

Arbetet tog ungefär 1 vecka för oss.
Skapa repo och mappar tog lite tid eftersom vi gjorde några misstag.
Kortare kod tog mindre tid att skriva, längre kod tog längre tid.

## Resultat

All funktionalitet är implementerad. Vi har kommandon, persistens, direktmeddelanden, rum och skrivindikatorer. Programmet går att köra från konsolen och meddelanden syns i realtid.




