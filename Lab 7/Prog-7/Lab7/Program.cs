using System;

namespace Lab7
{

    class Program
    {
        static void Main(string[] args)
        {
            Buckshop div1 = new Buckshop(-5, 6);
            Buckshop div2 = new Buckshop(4, 8);
            Buckshop sum = div1 + div2;
            Buckshop dif = div1 - div2;
            Buckshop div = div1 / div2;
            Buckshop mult = div1 * div2;
            string str = sum.ConverStr();
            Console.WriteLine("Sum a + b = " + str);
            str = dif.ConverStr();
            Console.WriteLine("Dif a - b = " + str);
            str = div.ConverStr();
            Console.WriteLine("Div a / b = " + str);
            str = mult.ConverStr();
            Console.WriteLine("Mulp a*b = " + str);
            str = "";
            if (div1 > div2)
                Console.WriteLine("first > second\n");
            if(div1 < div2)
                Console.WriteLine("first < second\n");
            if (div1 == div2)
                Console.WriteLine("first = second\n");
            if (div1 != div2)
                Console.WriteLine("first != second\n");
            switch (div1.CompareTo(div2))
            {
                case 0:
                    Console.WriteLine("a = b");
                    break;
                case 1:
                    Console.WriteLine("a > b");
                    break;
                case -1:
                    Console.WriteLine("a < b");
                    break;
                default:
                    break;
            }
            div1.ToStr("-7/8");
            Console.WriteLine(div1.up + "/" + div1.down);
            double number1 = (double)(div1);
            div1.ToStr("4/8");
            double number2 = (double)(div1);
            Console.WriteLine("-7/8 - 4/8 = " + (number1 - number2));
            Buckshop b = 10;
            Console.WriteLine(b.up);

        }
    }
}
