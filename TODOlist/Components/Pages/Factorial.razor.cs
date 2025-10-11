namespace TODOlist.Components.Pages
{
    public partial class Factorial
    {
        private int number = 0;
        private long? result;

        private void Calculate()
        {
            if (number < 0) return;
            result = ComputeFactorial(number);
        }

        private long ComputeFactorial(int n)
        {
            if (n <= 1) return 1;
            return n * ComputeFactorial(n - 1);
        }
    }
}
