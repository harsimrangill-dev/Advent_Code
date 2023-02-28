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

               switch (c2)
               {
                    case  'X':
                         points += 0;
                         switch (c1)
                         {
                              case 'A' :
                                   points += 3;
                                   break;
                              case 'B':
                                   points += 1;
                                   break;
                              case 'C':
                                   points += 2;
                                   break;
                         }

                         break;
                    case 'Y':
                         points += 3;
                         switch (c1)
                         {
                              case 'A':
                                   points += 1;
                                   break;
                              case 'B':
                                   points += 2;
                                   break;
                              case 'C':
                                   points += 3;
                                   break;     
                         }

                         break;
                    case 'Z':
                         points += 6;
                         switch (c1)
                         {
                              case 'A':
                                   points += 2;
                                   break;
                              case 'B':
                                   points += 3;
                                   break;
                              case 'C':
                                   points += 1;
                                   break;
                         }

                         break;
                         
               }
               
               

          }
          Console.WriteLine(points);
     }
}