using System;

class RemoteControlCar {
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int speed; // task 1
    private int batteryDrain; // task 1
    private int batteryCharge = 100; // task 0
    private int distance = 0;         // task 0

    public  RemoteControlCar(int speed, int batteryDrain) {  // task 1
        this.speed = speed;                         // task 1.1
        this.batteryDrain = batteryDrain;           // task 1.1
    }

    public bool BatteryDrained() {
        if (batteryCharge - batteryDrain < 0) // task 4.1
            return true;
        else
            return false;
    }
    public int DistanceDriven() {
        return distance; // task 3.1
    }

    public void Drive() {
        if (!BatteryDrained()) { // task 4.2 only can drive if battery not drained
            distance += speed; // task 3
            batteryCharge -= batteryDrain; // task 4
        }
    }

    public static RemoteControlCar Nitro() {
        return new RemoteControlCar(speed: 50, batteryDrain: 4); // task 5 
    }
}

class RaceTrack {
    // TODO: define the constructor for the 'RaceTrack' class
    private int trackDistance = 0; // task 2
    
    public RaceTrack(int distance) { // task 2.1
        this.trackDistance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car) {
        while (!car.BatteryDrained()) {                //task 6
            car.Drive();
        }
        return car.DistanceDriven() >= trackDistance;
    }    
}

