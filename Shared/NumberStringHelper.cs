

public static class NumberStringHelper {

    public static bool IsNumberPalindrome<T>(T number) {
        var str = number.ToString();
        var reverseStr = StringHelper.ReverseString(str);
        return str.Equals(reverseStr);
    }
}