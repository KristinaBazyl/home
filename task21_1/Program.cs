double Distance(double[] one, double[] two)
{
    double s = 0.0;
    for (int i= 0; i< one.Length; i++)
    {
        s = s + Math.Pow((one[i] - two[i]),2);
    }
    return Math.Sqrt(s);
}

Console.WriteLine("Введите размерность пространства");
int x = Convert.ToInt32(Console.ReadLine());
double [] mas1 = new double [x];
Console.WriteLine("Введите последовательно, через enter координаты первой точки");
for(int i=0; i<mas1.Length; i++){
    mas1[i]=Convert.ToDouble(Console.ReadLine());
}
double [] mas2 = new double [x];
Console.WriteLine("Введите последовательно, через enter координаты второй точки");
for(int i=0; i<mas2.Length; i++){
    mas2[i]=Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("Расстояние между точками:" + Distance(mas1,mas2));
