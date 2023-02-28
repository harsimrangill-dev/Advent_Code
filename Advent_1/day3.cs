namespace Advent_code;

public class day3
{
    public int sum = 0;

    string[] textFile = File.ReadAllLines("input3.txt");

    private static char[] priority =
    {
        'a', 'b', 'c', 'd', 'e', 'f', 'g','h','i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w',
        'x', 'y', 'z',
        'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
        'W', 'X', 'Y', 'Z'
    };

    public void sortM()
    {
        char[] chararray = new char[textFile.Length];
        int k = 0;
        foreach (string str in textFile)
        {
            for (int i = 0; i < str.Length / 2 - 1; i++)
            {
                int count = k;
                for (int j = str.Length / 2; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        chararray[k] = str[i];
                        k++;
                        break;
                    }
                }

                if (count != k)
                {
                    break;
                }
            }
        }

        int sum = 0;

        for (int i = 0; i < chararray.Length; i++)
        {
            for (int j = 0; j < priority.Length; j++)
            {
                if (chararray[i] == priority[j])
                {
                    sum += j + 1;
                }
            }
        }
        
        Console.WriteLine(sum);
    }

 


}