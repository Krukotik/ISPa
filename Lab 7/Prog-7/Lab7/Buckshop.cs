using System;
using System.Collections.Generic;
using System.Text;

class Buckshop : IComparable<Buckshop>
{
    public int up;
    public int down;
    public int Up
    {
        get
        {
            return up;
        }
        set
        {
            up = value;
        }
    }
    public int Down
    {
        get
        {
            return down;
        }
        set
        {
            if (value != 0)
            {
                down = value;
            }
            else
                Console.WriteLine("Error data");
        }
    }
    public string str;
    private static Buckshop nullptr;

    public Buckshop(int up, int down)
    {
        this.up = up;
        this.down = down;
    }

    public int CompareTo(Buckshop o)
    {
        int nok = (this.down * o.down) / GCD(this.down, o.down);
        int ratation1 = (nok / this.down) * this.up;
        int ratation2 = (nok / o.down) * o.up;
        if (ratation1 == ratation2)
            return 0;
        if (ratation1 > ratation2)
            return 1;
        if (ratation1 < ratation2)
            return -1;
        return 0;
    }

    public static int GCD(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }
        if (a >= b)
            return a;
        if (b >= a)
            return b;
        return 0;
    }

    public static Buckshop operator +(Buckshop n1, Buckshop n2)
    {
        int nok = (n1.down * n2.down) / GCD(n1.down, n2.down);
        if (nok != 0)
        {
            int ratationU = (nok / n1.down) * n1.up + (nok / n2.down) * n2.up;
            int ratationD = nok;
            while (GCD(Math.Abs(ratationU), Math.Abs(ratationD)) != 1 && ratationU != ratationD)
            {
                int i = GCD(Math.Abs(ratationU), Math.Abs(ratationD));
                ratationU /= i;
                ratationD /= i;
            }
            if (ratationD == ratationU)
                ratationD = ratationU = 1;
            return new Buckshop(ratationU, ratationD);
        }
        return nullptr;
    }

    public static Buckshop operator -(Buckshop n1, Buckshop n2)
    {
        int nok = (n1.down * n2.down) / GCD(n1.down, n2.down);
        if (nok != 0)
        {
            int ratationU = (nok / n1.down) * n1.up - (nok / n2.down) * n2.up;
            int ratationD = nok;
            while (GCD(Math.Abs(ratationU), Math.Abs(ratationD)) != 1 && ratationU != ratationD)
            {
                int i = GCD(Math.Abs(ratationU), Math.Abs(ratationD));
                ratationU /= i;
                ratationD /= i;
            }
            if (ratationD == ratationU)
                ratationD = ratationU = 1;
            return new Buckshop(ratationU, ratationD);
        }
        return nullptr;
    }

    public static Buckshop operator *(Buckshop n1, Buckshop n2)
    {
        int ratationU = n1.up * n2.up;
        int ratationD = n1.down * n2.down;
        while (GCD(Math.Abs(ratationU), Math.Abs(ratationD)) != 1 && ratationU != ratationD)
        {
            int i = GCD(Math.Abs(ratationU), Math.Abs(ratationD));
            ratationU /= i;
            ratationD /= i;
        }
        if (ratationD == ratationU)
            ratationD = ratationU = 1;
        return new Buckshop(ratationU, ratationD);
    }

    public static Buckshop operator /(Buckshop n1, Buckshop n2)
    {
        int ratationU = n1.up * n2.down;
        int ratationD = n1.down * n2.up;
        while (GCD(Math.Abs(ratationU), Math.Abs(ratationD)) != 1 && ratationU != ratationD)
        {
            int i = GCD(Math.Abs(ratationU), Math.Abs(ratationD));
            ratationU /= i;
            ratationD /= i;
        }
        if (ratationD == ratationU)
            ratationD = ratationU = 1;
        return new Buckshop(ratationU, ratationD);
    }

    public static bool operator >(Buckshop n1, Buckshop n2)
    {
        int nok = (n1.down * n2.down) / GCD(n1.down, n2.down);
        int ratation1 = (nok / n1.down) * n1.up;
        int ratation2 = (nok / n2.down) * n2.up;
        if (ratation1 > ratation2)
            return true;
        else
            return false;
    }
    public static bool operator <(Buckshop n1, Buckshop n2)
    {
        int nok = (n1.down * n2.down) / GCD(n1.down, n2.down);
        int ratation1 = (nok / n1.down) * n1.up;
        int ratation2 = (nok / n2.down) * n2.up;
        if (ratation1 < ratation2)
            return true;
        else
            return false;
    }
    public static bool operator !=(Buckshop n1, Buckshop n2)
    {

        int nok = (n1.down * n2.down) / GCD(n1.down, n2.down);
        int ratation1 = (nok / n1.down) * n1.up;
        int ratation2 = (nok / n2.down) * n2.up;
        if (ratation1 == ratation2)
            return false;
        else
            return true;
    }
    public static bool operator ==(Buckshop n1, Buckshop n2)
    {

        int nok = (n1.down * n2.down) / GCD(n1.down, n2.down);
        int ratation1 = (nok / n1.down) * n1.up;
        int ratation2 = (nok / n2.down) * n2.up;
        if (ratation1 == ratation2)
            return true;
        else
            return false;

    }
    public string ConverStr()
    {
        string str = up.ToString() + " / " + down.ToString();
        return str;
    }

    public void ToStr(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '/')
            {
                string s1 = "", s2 = "";
                for (int g = 0; g < i; g++)
                {
                    if (str[g] != ' ')
                        s1 += str[g];
                }
                for (int g = i + 1; g < str.Length; g++)
                {
                    if (str[g] != ' ')
                        s2 += str[g];
                }
                Int32.TryParse(s1, out up);
                Int32.TryParse(s2, out down);

                break;
            }
        }
    }

    public static implicit operator Buckshop(int x)
    {
        Buckshop b = new Buckshop(x, 1);
        return b;
    }
    public static explicit operator short(Buckshop n)
    {
        return (short)((short)n.up / (short)n.down);
    }
    public static explicit operator int(Buckshop n)
    {
        return (int)n.up / n.down;
    }
    public static explicit operator float(Buckshop n)
    {
        return (float)n.up / (float)n.down;
    }
    public static explicit operator double(Buckshop n)
    {
        return (double)n.up / (double)n.down;
    }
}
