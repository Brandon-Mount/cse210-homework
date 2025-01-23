using System;

public class Fraction
{
    // Private attributes for numerator (top) and denominator (bottom)
    private int _numerator;
    private int _denominator;

    // Default constructor (1/1)
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor with one parameter (top), default bottom to 1
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor with two parameters (top and bottom)
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getter and Setter for numerator
    public int Numerator
    {
        get { return _numerator; }
        set { _numerator = value; }
    }

    // Getter and Setter for denominator
    public int Denominator
    {
        get { return _denominator; }
        set 
        { 
            if (value == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            _denominator = value; 
        }
    }

    // Method to get the fraction as a string
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to get the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
