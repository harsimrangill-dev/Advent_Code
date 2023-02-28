namespace Advent_code;

public class task2
{
     string[] input2 = File.ReadAllLines("input2.txt");

     public void strgVal()
     {
          int points = 0;
          foreach (string str in input2)
          {
               char c1 = str[0];
               char c2 = str[2];

               if (c2 == 'X')
               {
                    points += 0;
                    if (c1 == 'A')
                         points += 3;
                    else if (c2 == 'B')
                         points += 1;
                    else
                         points += 2;
               }
               else if (c2 == 'Y')
               {
                    points += 3;
                    if (c2 == 'A')
                         points += 1;
                    else if (c2 == 'B')
                         points += 2;
                    else
                         points += 3;
               }
               else
               {
                    points += 6;
                    if (c2 == 'A')
                         points += 2;
                    else if (c2 == 'B')
                         points += 3;
                    else
                         points += 1;
               }
               
               

          }
          Console.WriteLine(points);
     }
}