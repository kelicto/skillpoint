namespace KeLi.SkillPoint.App.Problems
{
    internal class DataExchangeProblem : IResult
    {
        public void ShowResult()
        {
            var a = 10;
            var b = 20;

            SwapDataByCoordinate(ref a, ref b);

            var c = 30;
            var d = 40;

            SwapDataByPosition(ref c, ref d);
        }

        internal static void SwapDataByCoordinate(ref int num1, ref int num2)
        {
            num1 = num2 - num1;
            num2 -= num1;
            num1 = num2 + num1;
        }

        internal static void SwapDataByPosition(ref int num1, ref int num2)
        {
            num1 ^= num2;
            num2 = num1 ^ num2;
            num1 ^= num2;
        }
    }
}