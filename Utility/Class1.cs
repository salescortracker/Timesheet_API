namespace Utility
{
    public class Class1
    {
        public const string RouteWeather = "GetWeatherForecast";

        // Checks if a string is a palindrome
        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            var normalized = input.ToLowerInvariant();
            int left = 0, right = normalized.Length - 1;
            while (left < right)
            {
                if (normalized[left] != normalized[right]) return false;
                left++;
                right--;
            }
            return true;
        }
    }
}
