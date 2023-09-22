using System;
using System.Collections.Generic;

public class session
{
    private string _machine;
    private int _sessionsPerWeek;
    private int _weight;
    private int _repetitions;

    // Eine Liste, um Trainingspläne zu speichern
    private static List<session> _sessions = new List<session>();

    public session(string machine, int sessionsPerWeek, int weight, int repetitions)
    {
        _machine = machine;
        _sessionsPerWeek = sessionsPerWeek;
        _weight = weight;
        _repetitions = repetitions;

        // Füge den aktuellen Trainingsplan zur Liste hinzu
        _sessions.Add(this);
    }

    // Statische Methode zum Abrufen aller gespeicherten Trainingspläne
    public static List<session> GetSessions()
    {
        return _sessions;
    }
}

