using System.Text;

public static class StringHelper
{

    public static string ReverseString(string str)
    {

        var sb = new StringBuilder();
        for (int i = str.Length - 1; i >= 0; i--)
        {
            sb.Append(str[i]);
        }
        return sb.ToString();
    }
}