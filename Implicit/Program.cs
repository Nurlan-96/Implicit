// See https://aka.ms/new-console-template for more information
using Implicit.Domain.Entities;

Celcius tempCelsius = new Celcius(25);

Kelvin tempKelvin = tempCelsius;

Console.WriteLine(tempKelvin.Degree);