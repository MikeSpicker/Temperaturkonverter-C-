
using System;

class TemperaturKonverter
{
    static double CelsiusZuFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitZuCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double CelsiusZuKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    static double KelvinZuCelsius(double kelvin)
    {
        return kelvin - 273.15;
    }

    static void Main()
    {
        Console.WriteLine("Temperaturkonverter");
        Console.WriteLine("1: Celsius zu Fahrenheit");
        Console.WriteLine("2: Fahrenheit zu Celsius");
        Console.WriteLine("3: Celsius zu Kelvin");
        Console.WriteLine("4: Kelvin zu Celsius");
        Console.Write("Wähle eine Option: ");

        string auswahl = Console.ReadLine();
        Console.Write("Gib die Temperatur ein: ");
        if (double.TryParse(Console.ReadLine(), out double temperatur))
        {
            double ergebnis = 0;
            switch (auswahl)
            {
                case "1":
                    ergebnis = CelsiusZuFahrenheit(temperatur);
                    Console.WriteLine($"Ergebnis: {ergebnis} °F");
                    break;
                case "2":
                    ergebnis = FahrenheitZuCelsius(temperatur);
                    Console.WriteLine($"Ergebnis: {ergebnis} °C");
                    break;
                case "3":
                    ergebnis = CelsiusZuKelvin(temperatur);
                    Console.WriteLine($"Ergebnis: {ergebnis} K");
                    break;
                case "4":
                    ergebnis = KelvinZuCelsius(temperatur);
                    Console.WriteLine($"Ergebnis: {ergebnis} °C");
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe!");
        }
    }
}
