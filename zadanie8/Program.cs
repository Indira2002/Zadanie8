using System;
using System.Collections;
using System.Collections.Generic;
using studentlib;
namespace zadanie8
{
    class Program
    {

        static void Main(string[] args)
        {
            Student st = new Student();
            int s;
            s = Convert.ToInt32(Console.ReadLine());
            switch (s)
            {
                case 1:
                    st.Add();
                    break;
                    case 2:
                    st.del();
                    break;
                    case 3:
                    st.find();
                    break;
                    case 4:
                    st.findid();
                    break;
                case 5:
                    st.familia_s();
                    break;
                case 6:
                    st.familia_a();
                    break;
                case 7:
                    st.Phoisk();
                    break;
                case 8:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}

