using System;

public static class Bob
{
    public static string Response(string statement)
    {


    if (YellQuestion(statement))
        return "Calm down, I know what I'm doing!";
    if (Yell(statement))
        return "Whoa, chill out!";
    if (Question(statement))
        return "Sure.";
    if (SayNothing(statement))
        return "Fine. Be that way!";

    return "Whatever.";
         
    }
    
    public static bool Question(string statement)
    {
        return statement.Trim().Contains("?");
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
        return string.IsNullOrWhiteSpace(statement);
    }
    
    
}