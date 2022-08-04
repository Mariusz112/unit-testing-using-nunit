namespace unit_testing_using_nunit1
{
    public class Test
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < candidate; i++)
                {
                    if (candidate % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}