using System;
using System.Collections.Generic;
using System.IO;

// Base class for all goal types
abstract class Goal
{
    public string Name { get; set; }
    protected int Points;

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string SaveData(); // Converts goal to a saveable string
}