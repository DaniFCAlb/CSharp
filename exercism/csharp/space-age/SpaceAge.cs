using System;

public class SpaceAge {

    public int seconds = 0;
    public double secondsOnEarth = 31557600.0;

    public SpaceAge(int seconds) {
        this.seconds = seconds;
    }

    public double OnEarth() {
        return seconds / secondsOnEarth;  
            // like example 1 000,000,000 s / 31557600 s = 31,69 years
    }

    public double OnMercury() {
        return OnEarth() / 0.2408467;
        // like example 31,69 years / 0.2408467 (orbital period year compared to earth) = 
    }

    public double OnVenus() {
        return OnEarth() / 0.61519726;
    }

    public double OnMars() {
        return OnEarth() / 1.8808158;
    }

    public double OnJupiter() {
        return OnEarth() / 11.862615;
    }

    public double OnSaturn() {
        return OnEarth() / 29.447498;
    }

    public double OnUranus() {
        return OnEarth() / 84.016846;
    }

    public double OnNeptune() {
        return OnEarth() / 164.79132;
    }
}