using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenScr.Algorithms;

public static class General
{
    private static int ToNumber(char c)
    {
        switch (c)
        {
            case '0': return 0;
            case '1': return 1;
            case '2': return 2;
            case '3': return 3;
            case '4': return 4;
            case '5': return 5;
            case '6': return 6;
            case '7': return 7;
            case '8': return 8;
            case '9': return 9;

            default: return -1;
        }
    }

    public static int ToInt(string s)
    {
        int result = 0;
        int iter = 0;

        foreach (char c in s)
        {
            int number = ToNumber(c);

            if (number == -1) continue;

            result += number;
        }
    }
}

