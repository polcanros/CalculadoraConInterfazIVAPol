using System;

public class Calculadora
{
    public double Sumar(double a, double b) { return a + b; }
    public double Restar(double a, double b) { return a - b; }
    public double Multiplicar(double a, double b) { return a * b; }
    public double Dividir(double a, double b) { return a / b; }
    public double Potencia(double baseNum, double exponente) { return Math.Pow(baseNum, exponente); }
    public double RaizCuadrada(double a) { return Math.Sqrt(a); }
}