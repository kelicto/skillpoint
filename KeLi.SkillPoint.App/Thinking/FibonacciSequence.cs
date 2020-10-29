using System;
using System.Numerics;

namespace KeLi.SkillPoint.App.Thinking
{
    /// <summary>
    ///     Fibonacci sequence.
    /// </summary>
    internal class FibonacciSequence : IResult
    {
        private static readonly ulong[] _cache = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };

        /// <summary>
        ///     Shows the result.
        /// </summary>
        public void ShowResult()
        {
            ShowBase1();
            ShowBase2();
            ShowBase3();
            ShowFeature1();
            ShowFeature2();
            ShowFeature3();
            ShowFeature4();
            ShowFeature5();
            ShowFeature6();
            ShowFeature7();
            ShowFeature8();
            ShowFeature9();
            ShowFeature10();
        }

        /// <summary>
        ///     f(n-1)+f(n-2)=f(n)(n>=3)
        /// </summary>
        private static void ShowBase1()
        {
            Console.WriteLine(GetBase1(10));
            Console.WriteLine();
        }

        /// <summary>
        ///     f(n-1)+f(n-2)=f(n)(n>=2)
        /// </summary>
        private static void ShowBase2()
        {
            Console.WriteLine(GetBase2(10));
            Console.WriteLine();
        }

        /// <summary>
        ///     1/√5[((1+√5)/2)^2-((1-√5)/2)^2]=f(n)(n>=0)
        /// </summary>
        private static void ShowBase3()
        {
            Console.WriteLine(GetBase3(10));
            Console.WriteLine();
        }

        /// <summary>
        ///     f(0)+f(1)+f(2)+...+f(n)=f(n+2)-1(n>=0)
        /// </summary>
        private static void ShowFeature1()
        {
            Console.WriteLine(GetFeature1(10));
            Console.WriteLine();
        }

        /// <summary>
        ///     f(1)+f(3)+f(5)+...+f(2n-1)=f(2n)(n>=1)
        /// </summary>
        private static void ShowFeature2()
        {
            Console.WriteLine(GetFeature2(10));
            Console.WriteLine();
        }

        /// <summary>
        ///     f(2)+f(4)+f(6)+...+f(2n)=f(2n+1)-1(n>=1)
        /// </summary>
        private static void ShowFeature3()
        {
            Console.WriteLine(GetFeature3(10));
            Console.WriteLine();
        }

        /// <summary>
        ///     [f(0)]^2+[f(1)]^2+...+[f(n)]^2=f(n)·f(n+1)(n>=0)
        /// </summary>
        private static void ShowFeature4()
        {
            Console.WriteLine(GetFeature4(10));
            Console.WriteLine();
        }

        /// <summary>
        ///     f(0)-f(1)+f(2)-...+(-1)^n·f(n)=(-1)^n·[f(n+1)-f(n)]+1(n>=0)
        /// </summary>
        private static void ShowFeature5()
        {
            Console.WriteLine(GetFeature5(10));
            Console.WriteLine();
        }

        /// <summary>
        ///     f(m-1)·f(n-1)+f(m)·f(n)=f(m+n)(m>=1,n>=1)
        /// </summary>
        private static void ShowFeature6()
        {
            Console.WriteLine(GetFeature6(10, 10));
            Console.WriteLine();
        }

        /// <summary>
        ///     (-1)^(n-1)+f(n-1)·f(n+1)=[f(n)]^2(n>=1)
        /// </summary>
        private static void ShowFeature7()
        {
            Console.WriteLine(GetFeature7(10));
            Console.WriteLine();
        }

        /// <summary>
        ///     [f(n)]^2-[f(n-2)]^2=f(2n-1)(n>=2)
        /// </summary>
        private static void ShowFeature8()
        {
            Console.WriteLine(GetFeature8(10));
            Console.WriteLine();
        }

        /// <summary>
        ///     f(n+2)+f(n-2)=3f(n)(n>=2)
        /// </summary>
        private static void ShowFeature9()
        {
            Console.WriteLine(GetFeature9(10));
            Console.WriteLine();
        }

        /// <summary>
        ///     f(2n-2m-2)[f(2n)+f(2n+2)]=f(2m+2)+f(4n-2m)(n>m>=-1,n>=1)
        /// </summary>
        private static void ShowFeature10()
        {
            Console.WriteLine(GetFeature10(10, 12));
            Console.WriteLine();
        }

        /// <summary>
        ///     It's very fast that provided by Shao Taihua.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        internal static BigInteger GetBase0(int index)
        {
            if (index < _cache.Length - 1)
                return _cache[index];

            if (index % 2 == 0)
            {
                var middle = GetBase0(index / 2);
                var preMiddle = GetBase0(index / 2 - 1);

                return middle * (middle + 2 * preMiddle);
            }

            else
            {
                var middle = GetBase0(index / 2);
                var nextMiddle = GetBase0(index / 2 + 1);

                return nextMiddle * nextMiddle + middle * middle;
            }
        }

        /// <summary>
        ///     f(n-1)+f(n-2)=f(n)(n>=2)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        internal static BigInteger GetBase1(int index)
        {
            BigInteger result = 0;
            BigInteger first = 1;
            BigInteger second = 1;

            for (var i = 2; i < index; ++i)
            {
                result = first + second;
                first = second;
                second = result;
            }

            return result;
        }

        /// <summary>
        ///     f(n-1)+f(n-2)=f(n)(n>=2)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        internal static double GetBase2(int index)
        {
            if (index == 0 || index == 1)
                return 1;

            return GetBase2(index - 1) + GetBase2(index - 2);
        }

        /// <summary>
        ///     1/√5[((1+√5)/2)^n-((1-√5)/2)^n]=f(n)(n>=0)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        internal static double GetBase3(int index)
        {
            return 1 / Math.Sqrt(5) * (Math.Pow((1 + Math.Sqrt(5)) / 2, index) - Math.Pow((1 - Math.Sqrt(5)) / 2, index));
        }

        /// <summary>
        ///     f(0)+f(1)+f(2)+...+f(n)=f(n+2)-1(n>=0)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        internal static double GetFeature1(int index)
        {
            double result = 0;

            for (var i = 0; i <= index; i++)
                result += GetBase2(i);

            return result;
        }

        /// <summary>
        ///     f(1)+f(3)+f(5)+...+f(2n-1)=f(2n)(n>=1)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        internal static double GetFeature2(int index)
        {
            double result = 0;

            for (var i = 1; i <= index; i++)
                result += GetBase2(2 * i - 1);

            return result;
        }

        /// <summary>
        ///     f(2)+f(4)+f(6)+...+f(2n)=f(2n+1)-1(n>=1)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        internal static double GetFeature3(int index)
        {
            double result = 0;

            for (var i = 1; i <= index; i++)
                result += GetBase2(2 * i);

            return result;
        }

        /// <summary>
        ///     [f(0)]^2+[f(1)]^2+...+[f(n)]^2=f(n)·f(n+1)(n>=0)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        internal static double GetFeature4(int index)
        {
            double result = 0;

            for (var i = 0; i <= index; i++)
                result += Math.Pow(GetBase2(2 * i), 2);

            return result;
        }

        /// <summary>
        ///     f(0)-f(1)+f(2)-...+(-1)^n·f(n)=(-1)^n·[f(n+1)-f(n)]+1(n>=0)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        internal static double GetFeature5(int index)
        {
            double result = 0;

            for (var i = 1; i <= index; i++)
                result += Math.Pow(GetBase2(2 * i), 2);

            return result;
        }

        /// <summary>
        ///     f(m-1)·f(n-1)+f(m)·f(n)=f(m+n)(m>=1,n>=1)
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        internal static double GetFeature6(int num1, int num2)
        {
            return GetBase2(num1 - 1) * GetBase2(num2 - 1);
        }

        /// <summary>
        ///     (-1)^(n-1)+f(n-1)·f(n+1)=[f(n)]^2(n>=1)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        internal static double GetFeature7(int num)
        {
            return Math.Pow(-1, num - 1) + GetBase2(num - 1) * GetBase2(num + 1);
        }

        /// <summary>
        ///     [f(n)]^2-[f(n-2)]^2=f(2n-1)(n>=2)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        internal static double GetFeature8(int num)
        {
            return Math.Pow(GetBase2(num), 2) + Math.Pow(GetBase2(num - 2), 2);
        }

        /// <summary>
        ///     f(n+2)+f(n-2)=3f(n)(n>=2)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        internal static double GetFeature9(int num)
        {
            return GetBase2(num - 2) + GetBase2(num + 2);
        }

        /// <summary>
        ///     f(2n-2m-2)[f(2n)+f(2n+2)]=f(2m+2)+f(4n-2m)(n>m>=-1,n>=1)
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        internal static double GetFeature10(int num1, int num2)
        {
            return GetBase2(2 * num2 - 2 * num1 - 2) * (GetBase2(2 * num1 + 2) + GetBase2(4 * num2 - 2 * num1));
        }
    }
}