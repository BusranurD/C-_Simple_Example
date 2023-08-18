using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool case_bool = true;
            while (case_bool != false)
            {
                int _case, _base;
                int number, number1, number2, radius, number3;
                float num;
                string text;
                Console.WriteLine("selection?");
                Console.WriteLine("twofold 1");
                Console.WriteLine("sum 2");
                Console.WriteLine("area and perimeter of rectangle 3");
                Console.WriteLine("area and circumference of circle 4");
                Console.WriteLine("celsius to fahrenheit 5");
                Console.WriteLine("driving license 6");
                Console.WriteLine("area of triangle 7");
                Console.WriteLine("binary to decimal 8");
                Console.WriteLine("numbers divisible by 5 and 7. 9");
                Console.WriteLine("reverse text 10");
                Console.WriteLine("stairs numbers 11");
                Console.WriteLine("guess 12");
                Console.WriteLine("longest word 13");
                Console.WriteLine("odd or even numbers(arraylist) 14");
                Console.WriteLine("logout 15");

                _case = Convert.ToInt32(Console.ReadLine());
                switch (_case)
                {
                    case 1:
                        Console.WriteLine("number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("result: " + 2 * number);
                        break;
                    case 2:
                        Console.WriteLine("fırst number?");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("second number?");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("result: " + (number1 + number2));
                        break;
                    case 3:
                        Console.WriteLine("short edge?");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("long edge?");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("perimeter :" + (2 * (number1 + number2)));
                        Console.WriteLine("area : " + (number1 * number2));
                        break;
                    case 4:
                        Console.WriteLine("radius?");
                        radius = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("circumference : {0:0.#}", 2 * Math.PI * radius);
                        Console.WriteLine("area : {0:0.#}", Math.PI * radius * radius);
                        break;
                    case 5:
                        Console.WriteLine("celsius degree?");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("fahrenheit : {0:0.#} ", ((9 * num) / 5) + 32);
                        break;
                    case 6:
                        Console.WriteLine("age?");
                        number = Convert.ToInt32(Console.ReadLine());
                        if (number >= 18)
                            Console.WriteLine("u can");
                        else
                        {
                            Console.WriteLine("u can't");
                        }
                        break;
                    case 7:
                        Console.WriteLine("1- tree edge\n2-one degree and two edge");
                        int choo = Convert.ToInt32(Console.ReadLine());
                        switch (choo)
                        {
                            case 1:
                                Console.WriteLine("fırst edge?");
                                number1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("second edge?");
                                number2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("third edge?");
                                number3 = Convert.ToInt32(Console.ReadLine());
                                float s = (number1 + number2 + number3) / 2;
                                Console.WriteLine("area : {0:0.#}", Math.Sqrt(s * (s - number1) * (s - number2) * (s - number3)));
                                break;
                            case 2:
                                Console.WriteLine("fırst edge?");
                                number1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("second edge?");
                                number2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("degree?");
                                number3 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("area: {0:0.#}", Convert.ToDouble(((number1 * number2) * Math.Sin(number3)) / 2));
                                break;
                        }
                        break;
                    case 8:
                        Console.WriteLine("binary number?");
                        text = Console.ReadLine();
                        Console.WriteLine(text.Length);
                        number = 0;
                        for (int i = 0; i < text.Length; i++)
                        {
                            number1 = (Convert.ToInt32(text[i]) - 48) * (int)Math.Pow(2, i);
                            number += number1;
                        }
                        Console.WriteLine("result: " + number);
                        break;
                    case 9:
                        {
                            int[] l = new int[100];
                            int j = 0;
                            for (int i = 1; i <= 100; i++)
                            {
                                if (i % 5 == 0)
                                {
                                    l[j] = i;
                                    j++;
                                }
                                else if (i % 7 == 0)
                                {
                                    l[j] = i;
                                    j++;
                                }
                            }
                            for (int i = 0; i < j; i++)
                                Console.WriteLine(l[i]);
                            break;
                        }
                    case 10:
                        Console.WriteLine("text?");
                        text = Console.ReadLine();
                        string new_text = "";
                        for (int i = text.Length - 1; i >= 0; i--)
                            new_text += text[i].ToString();
                        Console.WriteLine(new_text);
                        break;
                    case 11:
                        Console.WriteLine("number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= number; i++)
                        {
                            for(int j=1 ; j<i;j++)
                                Console.Write(" ");
                            Console.WriteLine(i);
                        }
                        break;
                    case 12:
                        Console.WriteLine("guess?");
                        number = Convert.ToInt32(Console.ReadLine());
                        Random numRandom = new Random();
                        int numberr = Convert.ToInt32(numRandom.Next(10)) ;
                        Console.WriteLine("random number :" +numberr);
                        if(numberr == number)
                            Console.WriteLine("true");
                        else
                            Console.WriteLine("false");
                        break;
                    case 13:
                        string[] array = new string[5];
                        Console.WriteLine("words?");
                        for (int i = 0; i < 5; i++)
                            array[i] = Console.ReadLine();
                        string longt= array[0];
                        number = array[0].Length;
                        for (int i = 1; i < 5; i++)
                        {
                            if (array[i].Length > number)
                            {
                                longt = array[i];
                                number = array[i].Length;
                            }
                            else if (array[i].Length == number)
                                longt += " and " + array[i];
                        } 
                        Console.WriteLine("longest word : " +longt);
                            break;
                    case 14:
                        ArrayList arrayList = new ArrayList();
                        ArrayList arrayList1 = new ArrayList();
                        ArrayList arrayList2 = new ArrayList();
                        Console.WriteLine("numbers?");
                        for (int i = 0; i <5; i++)
                        {
                            arrayList.Add(Console.ReadLine());
                        }
                        int w = 1;
                        foreach (var obj in arrayList)
                        {
                            if (Convert.ToInt32(obj) % 2 == 0)
                                arrayList1.Add(obj);
                            else
                                arrayList2.Add(obj);
                        }

                        Console.WriteLine("even : ");
                        foreach (var arr in arrayList1)
                            Console.WriteLine(arr);
                        Console.WriteLine("odd : ");
                        foreach (var arr in arrayList2)
                            Console.WriteLine(arr);
                        break;
                    case 20:
                        case_bool = false;
                        break;
                }
            }
        }
    }
}