using System;

public class Player {
    public int RollDie() {
       Random rnd = new Random();
       int die = rnd.Next(1, 19);

       return die;

    }

    public double GenerateSpellStrength() {
        Random rnd = new Random();
        double strength = rnd.Next(0, 100);
        
        return strength;
    }
}
