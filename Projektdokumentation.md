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
| 17 | Muss ¢ Funktional | Als User möchte ich das Gewicht für die Geräte angeben können, damit ich weiss mit wieviel Gewicht ich trainieren muss. |






## Planen
| AP-№ | Frist | Zuständig | Beschreibung                                                               | geplante Zeit |
|------|-------|-----------|----------------------------------------------------------------------------|---------------|
| 1.A | 03.11.2023  | Meister | GUI entwerfen | 180 Min|
| 2.A | 03.11.2023  | Sacher  | Funktion von allen Buttons richitg implementieren | 50 Min |
| 3.A | 03.11.2023  | Sacher | Auswahl zwischen Restday und Workout  | 10 Min |
| 4.A | 03.11.2023  | Sacher | Auswahl eines Gerätes an Workout tag | 15 Min|
| 5.A | 03.11.2023  | Sacher | Eingabe des Gewichts | 30 Min |
| 6.A | 03.11.2023  | Sacher | Eingabe der Wiederholungen | 30 Min |
| 7.A | 03.11.2023  | Hitz   | Speichern aller Workoutinformationen| 100 Min |
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
