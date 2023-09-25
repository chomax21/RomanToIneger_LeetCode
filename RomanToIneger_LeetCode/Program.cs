var value = Console.ReadLine();
Console.WriteLine(Solution.RomanToInt(value!));


public class Solution
{
    public static int RomanToInt(string s)
    {
        int sumResult = 0;
        if (s != null)
        {            
            for (int i = 0; i < s.Length; i++) 
            {
                    switch (s[i])
                    {

                        //
                        case 'I':
                            if(i < s.Length - 1)
                            {
                                var resSearchPositiveI = s[i + 1].ToString();
                                if (resSearchPositiveI == "V")
                                {
                                    sumResult += 4;
                                    i++;
                                    continue;
                                }
                                else if (resSearchPositiveI == "X")
                                {
                                    sumResult += 9;
                                    i++;
                                    continue;
                                }
                            }                            
                                sumResult += 1;
                            break;
                        //
                        case 'V':
                            sumResult += 5;
                            break;
                        //
                        case 'X':
                            if(i < s.Length - 1)
                            {
                                var resSearchPositiveX = s[i + 1].ToString();
                                if (resSearchPositiveX == "L")
                                {
                                    sumResult += 40;
                                    i++;
                                    continue;
                                }
                                else if (resSearchPositiveX == "C")
                                {
                                    sumResult += 90;
                                    i++;
                                    continue;
                                }
                            }                            
                                sumResult += 10;
                            break;
                        //
                        case 'L':
                            sumResult += 50;
                            break;
                        //
                        case 'C':
                            if (i < s.Length - 1)
                            {
                                var resSearchPositiveC = s[i + 1].ToString();
                                if (resSearchPositiveC == "D")
                                {
                                    sumResult += 400;
                                    i++;
                                    continue;
                                }
                                else if (resSearchPositiveC == "M")
                                {
                                    sumResult += 900;
                                    i++;
                                    continue;
                                }
                            }                            
                                sumResult += 100;
                            break;
                        //
                        case 'D':
                            sumResult += 500;
                            break;
                        //
                        case 'M':
                            sumResult += 1000;
                            break;
                    }
                
            }
        }
        return sumResult;
    }
}