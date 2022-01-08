using System;

public class Program
{  
  public static string Likes(string[] name)
  {
    string result = string.Empty;
    switch (name.Length)
    {
      case 0: {result = "no one likes this"; }break;
      case 1: {result = $"{name[0]} likes this";}break;
      case 2: {result = $"{name[0]} and {name[1]} like this";}break;
      case 3: {result = $"{name[0]}, {name[1]} and {name[2]} like this";}break;
      default : {result = $"{name[0]}, {name[1]} and {name.Length - 2} others like this";}break;
    }
    return result;
  }
}