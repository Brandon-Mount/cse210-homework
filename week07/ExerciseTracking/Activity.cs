using System;
using System.Collections.Generic;

// Base class
abstract class Activity
{
    private int minutes;  // Private field for encapsulation

    public Activity(int minutes)
    {
        this.minutes = minutes;
    }

    public int GetMinutes()
    {
        return minutes;
    }

    // Abstract methods for derived classes to implement
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // GetSummary method available to all activities
    public virtual string GetSummary()
    {
        return $"{GetType().Name}: Time: {minutes} min, Distance: {GetDistance():0.00} miles, Speed: {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min/mile";
    }
}