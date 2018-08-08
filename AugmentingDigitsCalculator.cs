using System;

namespace NumerosEnAumento
{
    public class AugmentingDigitsCalculator
    {
        private readonly int _startRange;
        private readonly int _endRange;
        public AugmentingDigitsCalculator(int startRange,int endRange)
        {
            _startRange = startRange;
            _endRange = endRange;
        }
 
        public int Calculate()
        {
            int count = 0;
            for (int i = _startRange; i <= _endRange; i++)
            {
                if (IsAugmentingNumber(i))
                    count++;
            }
            return count;
        }
        
        private Boolean IsAugmentingNumber(int number)
        {
 
            string numberString = number.ToString();
            int digits = numberString.Length;
            int max=Int32.Parse(numberString.ToCharArray()[digits-1].ToString());
            
            for (int i = digits-1; i>=0; i--)
            {
                int currentDigit=Int32.Parse(numberString.ToCharArray()[i].ToString());
                 
                if (currentDigit == 0 || currentDigit > max)
                {
                    return false;
                }
                else
                {
                    max = currentDigit;
                }
               
 
            }
            return true;
        }
 
    }
}