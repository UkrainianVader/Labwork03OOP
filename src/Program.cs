using System;
using System.Collections.Generic;
using System.ComponentModel;

public class testClass
{
     private byte[] bigArray = new byte[500 * 1024 * 1024];
    public testClass()
    {
        Console.WriteLine("Я конструктор!");
    }

    ~testClass()
    {
        Console.WriteLine("Я деструктор!");
    }
}
public class Vector3D : IDisposable
{
    public double X;
    public double Y;
    public double Z;
    //конструктор
    public Vector3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public void Dispose()
    {
        Console.WriteLine("Викликано деструктор");
    }

    public double Magnitude()
    {
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }
    public static Vector3D GetLargestVector(Vector3D[] vectors)
    {
        if (vectors == null || vectors.Length == 0)
            throw new ArgumentException("Масив векторів не може бути порожнім");

        Vector3D largest = vectors[0];
        double maxMagnitude = largest.Magnitude();

        foreach (var vector in vectors)
        {
            double magnitude = vector.Magnitude();
            if (magnitude > maxMagnitude)
            {
                maxMagnitude = magnitude;
                largest = vector;
            }
        }

        return largest;
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<Vector3D> vectors = new List<Vector3D>
        {
            new Vector3D(1, 2, 3),
            new Vector3D(4, 5, 6),
            new Vector3D(-1, -2, -3)
        };


        foreach (var vector in vectors)
        {
            Console.WriteLine($"Вектор: {vector}, Величина: {vector.Magnitude()}");
        }


        Vector3D largestVector = Vector3D.GetLargestVector(vectors.ToArray());
        Console.WriteLine($"Найбільший вектор: {largestVector}, його величина: {largestVector.Magnitude()}");


        foreach (var vector in vectors)
        {
            vector.Dispose();
        }

        Console.WriteLine("Демонстрація роботи деструкторів без IDIsposable:");
        for (int i = 0; i < 10; i++)
        {
            testClass obj = new testClass();
        }

    }
    
}