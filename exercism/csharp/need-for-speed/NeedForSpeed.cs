using System;

class RemoteControlCar {
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int speed, batteryDrain; // task 1
   // private int batteryDrain;
   private int batteryCharge = 100; // task 0
   private int distance = 0;         // task 0

    public  RemoteControlCar(int speed, int batteryDrain) {  // task 1
        this.speed = speed;                         // task 1.1
        this.batteryDrain = batteryDrain;           // task 1.1
    }

    public bool BatteryDrained() {
        if (batteryCharge < batteryDrain) { // task 4.1
            return true;
        }
        else {
            return false;
        }
    }
    public int DistanceDriven() {
        return distance; // task 3.1
    }

    public void Drive() {
       if (batteryCharge > batteryDrain) {           // task 4 
            distance += speed; // task 3
            batteryDrain -= batteryCharge; // task 4
       }
    
    }

    public static RemoteControlCar Nitro() {
        return new RemoteControlCar(50, 4); // task 5 
    }
}

class RaceTrack {
    // TODO: define the constructor for the 'RaceTrack' class
    private int _distance; // task 2
    
    public RaceTrack(int _distance) { // task 2.1
        this._distance = _distance;
    }

    public bool TryFinishTrack(RemoteControlCar car) {
        if () {
            
        }
    }
}
