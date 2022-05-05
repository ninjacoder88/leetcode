namespace LeetCode
{
    public class PalindromeNumberProblem
    {
        public bool IsPalindrome(int x)
        {
            var str = x.ToString();

            int j = str.Length - 1;
            for(int i = 0; i < str.Length / 2; i++)
            {
                if(str[i] != str[j])
                    return false;
                
                j--;
            }
            return true;
        }
    }
}