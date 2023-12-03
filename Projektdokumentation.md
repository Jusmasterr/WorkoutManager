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
|  1   | Muss                | Funktional     | Als ein User möchte ich, dass die Geräte Benchpress, Shoulderpress, Legpress, Legextension, Lat-pulldown und Bicep curls vorhanden sind, damit ich eine gute Auswahl an Geräten habe. |
|  2  | Muss                | Funktional     | Als ein User möchte ich, dass ich die Session ansehen kann, damit ich meine Trainings planen kann. |
|  3   | Kann                | Funktional     | Als ein User möchte ich, dass ich Sessions abändern kann, damit ich nicht jedes mal wenn ich Daten ändern möchte eine neue Session erstellen muss. |
|  4  | Muss                | Funktional     | Als ein User möchte ich, dass ich Sessions löschen kann, damit ich den Überblick nicht verliere. |
|  5  | Muss                | Funktional     | Als ein User möchte ich, dass Fehleingaben abgefangen werden, damit ich das Programm nicht neu starten muss, wenn es abstürzt. |
|  6  | Muss             | Randbedingung  | Als ein User möchte ich, dass die Applikation in Windows Forms entwickelt ist, damit das GUI übersichtlich ist.  |
| 7   |   Muss         |    Funktional            | Als User möchte ich die Sessions speichern können, damit ich sie ansehen kann. |
| 8 |   Kann    |    Funktional   | Als ein User möchte ich, dass ich Übungen zu meinen Sessions hinzufügen oder entfernen kann, damit ich meine Workouts flexibel gestalten kann.|
| 9 | Muss    |  Funktional         |  Als user möchte ich die Sessions auf verschiedenen Geräten erstellen, damit ich flexibler bin. |
| 10 | Kann | Funktional         | Als ein User möchte ich, dass ich die Dauer jeder Trainingseinheit festlegen kann, damit ich meine Zeit effizient planen kann.|
| 11 | Muss   | Randbedingung | Als ein User möchte ich, dass die Anwendung benutzerfreundlich gestaltet ist, damit es einfach zu bedienen ist.|
| 12 | Muss | Qualität | Als user möchte ich, dass das Fehler abgefangen werden, damit die Applikation nicht immer abstürzt. |
| 13 | Muss | Funktional | Als user möchte ich einen Workoutplan erstellen, damit ich einen Plan habe was ich trainieren muss. |
| 14 | Muss | Funktional | Als user möchte ich für jeden Tag einen einzelnen Trainingsplan erstellen, damit ich was was ich an welchem Tag trainieren soll. |
| 15 | Muss | Funktional | Als user möchte ich, dass ich ein Gerät auswählen kann, damit ich eine spezifische Trainingseinheit machen kann. |
| 16 | Muss | Funktional | Als user möchte ich die Wiederholungen für jede Übung festlegen können, damit ich meine Ziele erreichen kann. |
| 17 | Muss | Funktional | Als User möchte ich das Gewicht für die Geräte angeben können, damit ich weiss mit wieviel Gewicht ich trainieren muss. |






## Planen
| AP-№ | Frist       | Zuständig  | Beschreibung                                          | Geplante Zeit |
| ---- | ----------- | ---------- | ----------------------------------------------------- | ------------- |
| 1.A  | 2023-12-10  | Entwickler1 | Recherche und Auswahl von Geräten für das Training   | 8 Stunden      |
| 1.B  | 2023-12-15  | Entwickler1 | Implementierung der ausgewählten Geräte in die Applikation | 16 Stunden    |
| 2.A  | 2023-12-18  | Entwickler2 | Implementierung der Funktion zum Anzeigen von Sessions | 12 Stunden    |
| 3.A  | 2023-12-20  | Entwickler2 | Implementierung der Funktion zum Bearbeiten von Sessions | 20 Stunden   |
| 4.A  | 2023-12-22  | Entwickler2 | Implementierung der Funktion zum Löschen von Sessions  | 10 Stunden    |
| 5.A  | 2023-12-25  | Entwickler3 | Implementierung der Fehlerbehandlung für Fehleingaben  | 14 Stunden    |
| 6.A  | 2023-12-28  | Entwickler3 | Entwicklung der GUI in Windows Forms                  | 18 Stunden    |
| 7.A  | 2023-12-30  | Entwickler4 | Implementierung der Funktion zum Speichern von Sessions | 14 Stunden   |
| 8.A  | 2024-01-05  | Entwickler4 | Implementierung der Funktion zum Hinzufügen oder Entfernen von Übungen | 16 Stunden |
| 9.A  | 2024-01-10  | Entwickler5 | Implementierung der Funktion zum Erstellen von Sessions auf verschiedenen Geräten | 22 Stunden |
| 10.A | 2024-01-15  | Entwickler5 | Implementierung der Funktion zum Festlegen der Dauer jeder Trainingseinheit | 12 Stunden |
| 11.A | 2024-01-18  | UX-Designer | Gestaltung der Benutzeroberfläche für Benutzerfreundlichkeit | 24 Stunden |
| 12.A | 2024-01-20  | Entwickler6 | Implementierung der Fehlerbehandlung für die Stabilität der Anwendung | 16 Stunden |
| 13.A | 2024-01-25  | Entwickler6 | Implementierung der Funktion zum Erstellen eines Workoutplans | 18 Stunden |
| 14.A | 2024-01-30  | Entwickler7 | Implementierung der Funktion zum Erstellen von täglichen Trainingsplänen | 20 Stunden |
| 15.A | 2024-02-03  | Entwickler7 | Implementierung der Funktion zum Auswählen eines Geräts für das Training | 10 Stunden |
| 16.A | 2024-02-08  | Entwickler8 | Implementierung der Funktion zum Festlegen von Wiederholungen für jede Übung | 14 Stunden |
| 17.A | 2024-02-12  | Entwickler8 | Implementierung der Funktion zum Angeben des Gewichts für die Geräte | 12 Stunden |

**Total: 308 Stunden**





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
| 5.1 | Pop-up ist geöffnet | Klicken auf "Maschinen" | Dropdown menu mit allen verfügbaren Maschinen wird angezeigt. |
| 6.1 | Pop-up ist geöffnet | Klicken auf Textfeld "Weight"  | Eingegebene Daten werden gespeichert |
| 7.1 | Pop-up ist geöffnet | Klicken auf Textfeld "Repetitions"  | Eingegebene Daten werden gespeichert |
| 8.1 | Applikation ist gestartet | Klicken auf "Show Schedule" | Auswahl der gespeicherten Workouts |
| 9.1 | Auswahl der gespeicherten Workouts | Klicken auf ein beliebiges Workout | Ausgabe aller gespeicherten Daten |
| 10.1| Applikation ist gestartet | Fehleingabe | "Falsche Eingabe, bitte erneut versuchen" |

### Testprotokoll
| Test-№ | TC-№ | Resultat | Datum | Tester |
|---|---|---|---|---|
| 1 | 1.1 | OK ✅ | 03.11.2023 | Sacher |
| 2 | 2.1 | OK ✅ | 03.11.2023 | Sacher |
| 3 | 3.1 | OK ✅ | 03.11.2023 | Sacher |
| 4 | 4.1 | OK ✅ | 03.11.2023 | Sacher |
| 5 | 5.1 | OK ✅ | 03.11.2023 | Sacher |
| 6 | 6.1 | OK ✅ | 03.11.2023 | Sacher |
| 7 | 7.1 | OK ✅ | 03.11.2023 | Sacher |
| 8 | 8.1 | NOK ❌ | 03.11.2023 | Sacher |
| 9 | 9.1 | NOK ❌ | 03.11.2023 | Sacher |
| 10 | 10.1 | NOK ❌ | 03.11.2023 | Sacher |

### Testbericht
Das programm ist noch nicht voll funktionsfähig. Die erstellung eines neuen Workoutplans funktioniert, jedoch muss die Auswahl des Workouts und die Anzeige der genauen Daten noch implementiert werden, damit das Programm richtig funktioniert.

## Auswertung

### Was lief nicht gut?
In diesem Projekt lief nicht alles nach Plan. Zu Beginn hatten wir Schwierigkeiten, das Projekt effektiv zu erstellen und zu teilen, um eine reibungslose Zusammenarbeit zu ermöglichen. Nach der Lösung dieses Problems gerieten wir etwas hinter den Zeitplan. Die Stimmung und Motivation im Team waren zudem nicht besonders hoch, da wir zuvor weniger positive Erfahrungen mit Windows Forms gemacht hatten. Das führte dazu, dass wir an gewissen Tagen nicht sehr produktiv waren. Diese eher kleinen Probleme summierten sich schlussendlich und führten dazu, dass wir das Projekt nicht vollständig abschließen konnten.

### Was lief gut?
Die Teile des Programs, die wir realisieren konnten, sind unserer Meinung nach gut gelungen. Allerdings mussten wir feststellen, dass in diesem Projekt nicht besonders viele positive Entwicklungen stattgefunden haben.

## Portfolioeintrag
- Sacher Robin: https://portfolio.bbbaden.ch/view/view.php?t=1e1ffd3ef7a07d5e1361
- Damian Müller:
- Julian Hitz:
- Justus Meister: 
