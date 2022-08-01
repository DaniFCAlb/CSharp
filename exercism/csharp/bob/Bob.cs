using System;

public static class Bob
{
    public static string Response(string statement)
    {
      switch (statement)
      {
        case Question():
            return "Sure";
            break;
        
        default:
            return "Whatever";
      }
    
      
    }
    public static bool Question(string statement)
    {
        return statement.Contains("?");
    }

    static bool Yell(string statement)
    {
        return statement == statement.ToUpper() 
                && statement != statement.ToLower(); 
    }

    static bool YellQuestion(string statement)
    {
        return statement == statement.ToUpper() 
                && statement != statement.ToLower() 
                && statement.Contains("?"); 
    }

    static bool SayNothing(string statement)
    {
        return string.IsNullOrEmpty("");
    }
    
    
}