using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ElGamal
{
    internal class Algorithms
    {
        public static int BigPow(int value, int pow, int mod)
        {
            char[] arrBinaryNum = Convert.ToString(pow, 2).ToCharArray();
            int[] resultArr = new int[arrBinaryNum.Length];
            resultArr[0] = value;
            for (int i = 1; i < arrBinaryNum.Length; i++)
            {
                if ((int)char.GetNumericValue(arrBinaryNum[i]) == 0)
                    resultArr[i] = (int)(Math.Pow(resultArr[i - 1], 2) % mod);
                else
                    resultArr[i] = (int)((Math.Pow(resultArr[i - 1], 2) * value) % mod);
            }
            return resultArr.LastOrDefault();
        }

        public static bool ProverkaNaProstoe(int value)
        {
            for (int i = 2;i<value;i++)
            {
                if (value%i==0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool StandartAlgoritmEvklida(int value, int value1)
        {
            int n, m, r;
            if (value > value1)
            {
                n = value;
                m = value1;
            }
            else
            {
                n = value1;
                m = value;
            }

            while (n > 0)
            {
                r = n % m;
                if (r != 0)
                {
                    n = m;
                    m = r;
                }
                else
                {
                    break;
                }
            }
            if (m != 1) return false;
            else return true;

        }

        public static bool PervoobrazniyKoren(int value,int pow)
        {
            for (int i =0;i<pow-1;i++)
            {
                if (BigPow(value, i, pow) == 1)
                {
                    return false;
                }
            }
            return true;
        }

        internal static int BigPow(BigInteger value, int pow, int mod)
        {
            char[] arrBinaryNum = Convert.ToString(pow, 2).ToCharArray();
            BigInteger[] resultArr = new BigInteger[arrBinaryNum.Length];
            resultArr[0] = value;
            for (int i = 1; i < arrBinaryNum.Length; i++)
            {
                if ((int)char.GetNumericValue(arrBinaryNum[i]) == 0)
                    resultArr[i] = (BigInteger.Pow(resultArr[i - 1], 2) % mod);
                else
                    resultArr[i] = ((BigInteger.Pow(resultArr[i - 1], 2) * value) % mod);
            }
            return (int)resultArr.LastOrDefault();
        }
    }
}
