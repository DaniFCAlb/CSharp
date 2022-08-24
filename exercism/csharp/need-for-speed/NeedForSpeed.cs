using System;

class RemoteControlCar {
    // TODO: define the constructor for the 'RemoteControlCar' class
    public int speed; // task 1
    public int batteryDrain; // task 1
    public int batteryCharge = 100; // task 0
    public int distance = 0;         // task 0

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
              // task 4 
            distance += speed; // task 3
            batteryCharge -= batteryDrain; // task 4
    
    }

    public static RemoteControlCar Nitro() {
        return new RemoteControlCar(speed: 50, batteryDrain: 4); // task 5 
    }
}

class RaceTrack {
    // TODO: define the constructor for the 'RaceTrack' class
    public int trackDistance = 0; // task 2
    
    public RaceTrack(int distance) { // task 2.1
        this.trackDistance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car) {
        if (!car.BatteryDrained()) {
            car.Drive();
            return car.DistanceDriven() >= trackDistance;
        }
        else
            return car.DistanceDriven() < trackDistance;
    }    
}

