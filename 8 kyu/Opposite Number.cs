//My solution
using System;

public class Kata
    {
        public  static int Opposite(int number)
        {
          if(number > 0)
          {
            return number = number - (2*number);
          }
          else
          {
           return number = number + (-2*number); 
          }
        }
    }

//Optimal solutions
using System;

public class Kata
    {
        public static int Opposite(int number)
        {
            return -number;
        }
    }

using System;

public class Kata
    {
        public static int Opposite(int number)
        {
           return number * -1;
        }
    }
