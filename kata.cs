using System;
namespace EqualSidesOfArray {
  public class Kata
  {
    //Code for students to write
    public static int FindEvenIndex(int[] arr)
    {
      //Set standard return value
      int indexNum = -1;
      
      //Quick check
      if(arr.Length == 1 || arr.Length == 0)
      {
        indexNum = 0;
        return indexNum;
      }
      
      //Go Through whole array moving to the right one digit each time
      for(int i = 0; i < arr.Length; i++)
      {
        //Set beginning values for this arr[i]
        int left = 0, right = 0;
        
        //For index 0 - the current arr[i]
        for(int j = 0; j < i + 1; j++)
        {
          //There is nothing left of the starting position
          if(j == 0)
            continue;
          else
            //Add the value of the number to the left of j to j's total
            left = left + arr[(j - 1)];
        }
        
        //For the index to the right of arr[i] - the length of the array
        for(int j = (i + 1); j < arr.Length; j++)
        {
          //There is nothing right of the last index
          if(j == arr.Length)
            continue;
          else
            //Add the value of j to right's total
            right = right + arr[j]; 
        }
        
        //Found it
        if(left == right)
        {
          indexNum = i;
          return indexNum;
        }
        
      }
      //Return -1. Desired result not found.
      return indexNum;
    }
  
    //Code for students to test their FindEvenIndex Method
    public static void TestResults()
    {
      //Tests
      int[][] testArray = new int[][]
      {
        new int[] {1, 2, 3, 4, 3, 2, 1},
        new int[] {1, 2, 3, 4, 5, 6},
        new int[] {20, 10, 30, 10, 10, 15, 35},
        new int[] {8, 8},
        new int[] {8, 0},
        new int[] {0, 8},
        new int[] {7, 3, -3},
        new int[] {8},
        new int[] {-7682, -902, -9954, -8051, 5286, -4104, 3050, 8547, 7110, 295, 1349, -2501, -8184, 4122, 528, 3577, -8469, 2354, -1244, -7467, -9898, -3866, 2727, -2327, 1786, 469, -3124, -2607, 1432, 575, -4866, 5297, -4938, 416, 7681, 1110, -8828, 4810, 9359, 5034, 1455, 2724, 893, -2467, 8037, -5393, -9240, -8238, 704, 4368, 40, 9201, -452, -9548, 9128, 6183, 6370, 2372, 163, -5183, 9019, -4344, -2885, -3465, -4840, 6051, -7564, 1399, 6440, 9417, 2405, -3279, 2994, 3721, 1077, -2623, 5241, -4807, -364, -2822, -292, -4887, 6689, 7064, -9466, -4068, -4251, -5390, 1287, -8503, 4739, -1200, -5353, 4542, 6014, -4202, -4392, -5642, -7627, -8015, -7830, -640, -4679, 1286, -8038, -6681, -3793, 5826, -626, 1751, -9059, 1177, -7265, -7016, 5108, 3906, -1033, 51, -4000, 9227, 302, 7826, -9889, 4943, -5322, -6395, -7926, 8451, 7707, -4721, -8232, 883, -7180, -2350, -4992, -9652, 9791, -4597, 5101, 7215, 9725, -78, 5236, 9536, -9445, -6438, -3936, -8338, 9434, -7893, 6831, 5557, 8358, -6855, 1683, -5657, -751, 378, -3393, 8357, -8756, -2245, 8119, -5905, -18, 58, -1644, 5085, 7976, 4760, 4114, -6436, 4950, -1216, 9502, -9621, -7410, -9426, 4387, -8885, 7541, -9588, 9017, 5599, -1553, -3789, 2525, 9675, 5967, -9336, 1099, -588, 8795, 6743, 5971, 1969, 1803, 1141, -446, 497, 5205, 978, -6314, -5326, -2008, 3266, -9394, -427, -6358, 1303, -8247, -1326, 5991, -4509, -9184, -9168, -1262, -7481, 5647, -6230, 7533, -1319, 9118, 7311, -6340, -5298, -5231, 8206, 2812, -2468, -1424, 1449, 1020, -6110, -4090, -3438, 6725, 4343, -2394, 5180, -4396, -7049, 6032, -5337, 8910, -7576, 3421, 3303, 5926, 5139, -6769, -717, 5493, -4217, 2963, -3476, 1860, -3626, -8987, -6710, -1503, -7600, 6760, 6110, -7273, 304, 7653, 2101, 9581, 4254, -5894, 4395, 4912, -9534, 8166, 4582, 2649, 4455, 8401, -8764, 1280, 1466, -7721, 7673, -5700, 9292, 5955, -4763, 926, 9386, 4701, 351, 3329, -5685, -3317, -6796, -3810, 9921, -8064, -1394, -5229, -8680, 3721, -8328, 1032, -1164, 4371, 5027, -2384, 8381, 3874, 7405, -2027, 9777, 2009, 7031, -9880, 9087, 1809, -6566, 4348, 2416, -8826, -9805, 9552, 3755, -8935, 596, 3782, 4962, -1609, 2727, 2518, -206, 6464, -40, 7744, -9393, -3360, 5463, -5079, -9072, 7620, 2545, -4489, 7295, -7623, 3552, 2306, -348, -6916, -2897, -1888, 8501, 4257, 2354, -9855, 3525, -7881, 7277, -2229, -6226, -8756, 2654, -11, -8853, -5114, 8178, -6688, -7952, 9286, 9512, 2446, 6345, 8512, 3420, 4796, -1371, 4684, -7744, 1377, -2487, 8290, -5870, 1877, -8712, -5385, 4017, 5537, -5891, -185, -5781, 8487, -637, -2308, -8853, 9684, -5035, -7444, -5637, 2409, -5801, 239, 257, 365, -6429, 4657, 1766, 9989, -9163, 7558, 1516, 8841, 9862, -4101, -9742, -4517, 7113, -9224, -1300, 6531, 869, -7359, 9202, 2233, 5067, -8975, -6918, -1347, 7364, 3736, -170, -3927, 320, -153, -2822, 7273, -1967, 3765, -1694, -3369, 2849, 4027, 4699, -3449, 8299, -4623, 8624, -6537, -2566, 5663, -7430, -5812, 3855, -2168, -8461, -8442, 1036, 8023, 5298, -7454, 1574, -6887, -7375, -2899, -2272, -4557, -1480, 15, 8721, -7016, 7450, -6652, 2470, -7931, -6318, 6842, -2059, 2651, 3934, -112691}
      };

      //Answers
      int[] yourAnswer = {FindEvenIndex(testArray[0]), FindEvenIndex(testArray[1]), FindEvenIndex(testArray[2]), FindEvenIndex(testArray[3]), FindEvenIndex(testArray[4]), FindEvenIndex(testArray[5]), FindEvenIndex(testArray[6]),FindEvenIndex(testArray[7]), FindEvenIndex(testArray[8])};
      int[] correctAnswer = {3, -1, 3, -1, 0, 1, 0, 0, 233};
      int count = 1;

      for(int i = 0; i < 9; i++)
      {
        int len = testArray[i].Length;
        Console.WriteLine("----------------------------------------------------------------------------------------------------");
        Console.WriteLine($"Test #{count}:");

        Console.Write("[");
        for(int j = 0; j < len; j++)
        {
          if(j != (len -1))
            Console.Write($"{testArray[i][j]}, ");
          else
            Console.WriteLine($"{testArray[i][j]}]");
        }

        if(yourAnswer[i] == correctAnswer[i])
          Console.ForegroundColor = ConsoleColor.Green;
        else
          Console.ForegroundColor = ConsoleColor.DarkRed;

        Console.WriteLine($"\nYour Answer: {yourAnswer[i]}");
        Console.WriteLine($"Correct Answer: {correctAnswer[i]}");
        Console.WriteLine("--------------------\n");

        Console.ResetColor();
        count++;
      }
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("\n---Scroll up to see all 9 tests and make sure you had the correct answer for each---");
      Console.ResetColor();
    }
  }
}

//Top Answer
// using System.Linq;

// public class Kata
// {
//     public static int FindEvenIndex(int[] arr)
//     {
//         int leftSum = 0, rightSum = arr.Sum();

//         for (int i = 0; i < arr.Length; ++i)
//         {
//             rightSum -= arr[i];

//             if (leftSum == rightSum)
//             {
//                 return i;
//             }

//             leftSum += arr[i];
//         }

//         return -1;
//     }
// }