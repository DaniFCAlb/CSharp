using System;

public static class Darts {
    public static int Score(double x, double y) {
        int points = 0;
        double pos = Math.Sqrt(x * x + y * y);
        
        if (pos <= 1.0)
            return points += 10;
        
        if (pos <= 5.0)
            return points += 5;
        
        if (pos<= 10.0)
            return points += 1;
        
        else
            return points;
    }
}
