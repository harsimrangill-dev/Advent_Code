using System;
using System.Globalization;
using System.Numerics;

public class Class1
{
    string[] inputFIle = File.ReadAllLines("input.txt");
    int  max = 0;
    int elfNo = 1;
    
    public int getLength()
    {
        int count = 0;
        foreach( string str in inputFIle)
        {
            if (str == "")
            {
                count++;
            }
        }
        return count + 1;
    }
    public void maxVal()
    {
        int i = 0;
        int sum = 0;
        foreach (string str in inputFIle)
        {
            if (str != "")
            {
                int num = Convert.ToInt32(str);
                sum += num;
            }
            else if (str == "" || i ==  getLength () - 1) 
            {
                elfNo++;
                if (max < sum)
                {
                    max = sum;
                }
                sum = 0;
            }
            i++;

        }
        
        Console.WriteLine(elfNo + "th elf has food with maximum calories:  " + max);
        
    }

    public int[] intarray()
    {
        int len = this.getLength();
        int[] cals = new int[len];
        int count = 0;
        int i = 0;
        int sum = 0;

        foreach (string str in inputFIle)
        {
            if (str != "")
            {
                int num = Convert.ToInt32(str);
                sum+= num;
            }
            if (str == "" || i == inputFIle.Length - 1 )
            {
                cals[count] = sum;
                count++;
                sum = 0;
                
            }
            i++;

        }
        return cals;
    }
    
}
