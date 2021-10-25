using System;

namespace lab_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите U1(Напряжение 1 участка электронной цепи):");
                double U1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите U2(Напряжение 2 участка электронной цепи):");
                double U2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите R1(Сопротивление 1 участка электронной цепи):");
                double R1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите R2(Сопротивление 2 участка электронной цепи):");
                double R2 = double.Parse(Console.ReadLine());
                double I1 = U1 / R1;
                double I2 = U2 / R2;
                if (I1 < I2) Console.WriteLine("По первому участку электронной цепи протекает меньший ток, чем по второму");
                else if (I1 == I2) Console.WriteLine("по обоим участкам электронной цепи ток протекает одинаково");
                else Console.WriteLine("По второму участку электронной цепи протекает меньший ток, чем по первому");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
