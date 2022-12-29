using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.assignment1
{
    internal class Fraction
    {
        private float ts;
        private float ms;
        public float Ts
        {
            get => ts; set => ts = value;
        }
        public float Ms
        {
            get => ms;
            set
            {
                if (value != 0)
                    ms = value;
            }
        }
        public Fraction()
        {

        }
        public Fraction(float ts, float ms)
        {
            this.ts = ts;
            this.ms = ms;
        }
        public void nhap()
        {
            Console.WriteLine("Nhap tu so: ");
            ts = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Nhap mau so: ");
                ms = Convert.ToInt32(Console.ReadLine());
            } while (ms == 0);
        }
        public void xuat()
        {
            Console.Write($"{Ts}/{Ms}");
        }
        public float UCLN(float x, float y)
        {
            x = Math.Abs(ts);
            y = Math.Abs(ms);
            while (x != y && x != 0 && y != 0)
            {
                if (x > y) x = x - y;
                else y = y - x;
            }
            return x;
        }
        public Fraction RutGon()
        {
            Fraction rutgon = new Fraction();
            float uoc = UCLN(ts, ms);
            if (uoc != 0)
            {
                rutgon.ts = ts / uoc;
                rutgon.ms = ms / uoc;
            }
            else
            {
                rutgon.ms = ms;
                rutgon.ts = ts;
            }
            return rutgon;
        }
    }
}