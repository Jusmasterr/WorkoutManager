# WorkoutManager
## 1 Informieren
### Gruppe:
-  Damian Müller (Projektleiter)
-  Julian Hitz
-  Justus Meister
-  Robin Sacher

### 1.2 User-Stories
| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
|  1   | Muss                | Funktional     | Als ein User möchte ich, dass ich ein Workoutplan erstellen und dabei das Gerät, die Anzahl Trainingseinheiten pro Woche, das Gewicht und die Wiederholungen eingeben kann, damit ich ich mein Training planen kann. |
|  2   | Muss                | Funktional     | Als ein User möchte ich, dass die Geräte Benchpress, Shoulderpress, Legpress, Legextension, Lat-pulldown und Bicep curls vorhanden sind, damit ich eine gute Auswahl an Geräten habe. |
|  3   | Muss                | Funktional     | Als ein User möchte ich, dass ich die Session ansehen kann, damit ich meine Trainings planen kann. |
|  4   | Kann                | Funktional     | Als ein User möchte ich, dass ich Sessions abändern kann, damit ich nicht jedes mal wenn ich Daten ändern möchte eine neue Session erstellen muss. |
|  5   | Muss                | Funktional     | Als ein User möchte ich, dass ich Sessions löschen kann, damit ich den Überblick nicht verliere. |
|  6   | Muss                | Funktional     | Als ein User möchte ich, dass Fehleingaben abgefangen werden, damit ich das Programm nicht neu starten muss, wenn es abstürzt. |
|  7   | Muss             | Randbedingung  | Als ein User möchte ich, dass die Applikation in Windows Forms entwickelt ist, damit das GUI übersichtlich ist.  |


## Planen
| AP-№ | Frist | Zuständig | Beschreibung                                                               | geplante Zeit |
|------|-------|-----------|----------------------------------------------------------------------------|---------------|
| 1.A | 03.11.2023  | Meister | GUI entwerfen | 180 Min|
| 2.A | 03.11.2023  | Sacher  | Funktion von allen Buttons richitg implementieren | 50 Min |
| 3.A | 03.11.2023  | Sacher | Auswahl zwischen Restday und Workout  | 10 Min |
| 4.A | 03.11.2023  | Sacher | Auswahl eines Gerätes an Workout tag | 15 Min|
| 5.A | 03.11.2023  | Sacher | Eingabe des Gewichts | 30 Min |
| 6.A | 03.11.2023  | Sacher | Eingabe der Wiederholungen | 30 Min |
| 7.A | 03.11.2023  | Hitz   | Speichern aller Wokoutinformationen| 100 Min |
| 8.A | 03.11.2023  | Hitz   | Fehleingaben abfangen | 60 Min |
| 9.A | 03.11.2023  | Müller | Anzeigen von gespeicherten Workouts | 100 Min |
| 10.A| 03.11.2023  | Müller | Löschen von gespeicherten Workouts | 30 Min |


## Entscheiden
Wir haben uns dazu entschieden, die Abänderung von schon bereits erstellten Workouts nicht zu implementieren, da wir wahrscheinlich nicht genung Zeit haben, Wenn wir alle Muss-Anforderungen implementiert haben, werden wir diese Funktion als Erweiterung implementieren
## Realisieren

## Kontrolle
### Testfälle
| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
|---|---|---|---|
| 1.1 | Applikation ist gestartet | Klicken auf "Create Schedule"| neue Vorlage öffnet sich |
| 2.1 | Applikation ist gestartet | Klicken auf "Create Schedule" | Wochentage werden angezeigt |
| 3.1 | Applikation ist gestartet | Klicken auf "Create Schedule" | Auswahl von Restday und Workout |
| 4.1 | Workout wurde ausgewählt | Klicken auf "add Data" | Pop-up öffnet sich |
| 5.1 | Pop-up ist geöffnet | Klicken auf "Maschinen" | Dropdown mnu mit allen verfügbaren Maschinen wird angezeigt. |
| 6.1 | Pop-up ist geöffnet | Klicken auf Textfeld "Weight"  | Eingegebene Daten werden gespeichert |
| 7.1 | Pop-up ist geöffnet | Klicken auf Textfeld "Repetitions"  | Eingegebene Daten werden gespeichert |
| 8.1 | Applikation ist gestartet | Klicken auf "Show Schedule" | Auswahl der gespeicherten Workouts |
| 9.1 | Auswahl der gespeicherten Workouts | Klicken auf ein beliebiges Workout | Ausgabe aller gespeicherten Daten |
| 10.1| Applikation ist gestartet | Fehleingabe | "Falsche Eingabe, bitte erneut versuchen" |

### Testprotokoll
| Test-№ | TC-№ | Resultat | Datum | Tester |
|---|---|---|---|---|
| 1 | 1.1 | OK | 03.11.2023 | Sacher |


## Auswertung

## Porfolioeintrag
