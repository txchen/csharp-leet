public class Solution {
    public string NumberToWords(int num)
    {
        if (num == 0)
        {
            return "Zero";
        }
        string result = "";
        int k = 0;
        while (num > 0)
        {
            if (num % 1000 > 0)
            {
                result = NumberToWordsLessThanThousand(num % 1000) + Kkk(k) + result;
            }
            num /= 1000;
            k++;
        }
        return result.Trim();
    }

    private string Kkk(int k)
    {
        switch (k)
        {
            case 1:
                return " Thousand";
            case 2:
                return " Million";
            case 3:
                return " Billion";
            case 0:
            default:
                return "";
        }
    }

    private string NumberToWordsLessThanThousand(int num)
    {
        string result = "";
        if (num >= 100)
        {
            result += LessThanTwenty(num / 100) + " Hundred";
            num = num % 100;
        }
        if (num < 20)
        {
            result += LessThanTwenty(num);
        }
        else
        {
            result += TwentyToNinty(num / 10);
            result += LessThanTwenty(num % 10);
        }
        return result;
    }

    private string TwentyToNinty(int num)
    {
        switch (num)
        {
            case 9:
                return " Ninety";
            case 8:
                return " Eighty";
            case 7:
                return " Seventy";
            case 6:
                return " Sixty";
            case 5:
                return " Fifty";
            case 4:
                return " Forty";
            case 3:
                return " Thirty";
            case 2:
            default:
                return " Twenty";
        }
    }

    private string LessThanTwenty(int num)
    {
        switch (num)
        {
            case 19:
                return " Nineteen";
            case 18:
                return " Eighteen";
            case 17:
                return " Seventeen";
            case 16:
                return " Sixteen";
            case 15:
                return " Fifteen";
            case 14:
                return " Fourteen";
            case 13:
                return " Thirteen";
            case 12:
                return " Twelve";
            case 11:
                return " Eleven";
            case 10:
                return " Ten";
            case 9:
                return " Nine";
            case 8:
                return " Eight";
            case 7:
                return " Seven";
            case 6:
                return " Six";
            case 5:
                return " Five";
            case 4:
                return " Four";
            case 3:
                return " Three";
            case 2:
                return " Two";
            case 1:
                return " One";
            case 0:
            default:
                return "";
        }
    }
}