using System;

class BirdCount {
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay) {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() {
        int[] lastWeekCopy = {0, 2, 5, 3, 7, 8, 4};
        return lastWeekCopy;
    }

    public int Today() {
        int today = 0;
        for (int i = 0; i < birdsPerDay.Length; i++) {
            today = birdsPerDay[birdsPerDay.Length - 1];
        }
        return today;
    }

    public void IncrementTodaysCount() {
        for (int i = 0; i < birdsPerDay.Length; i++) {
            birdsPerDay[i]++;
        }
    }

    public bool HasDayWithoutBirds() {
        int zero = 0;
        int index = Array.IndexOf(birdsPerDay, zero);
        
        if (index > -1) // retorna -1 se não encontrar o numero 0 no Array(birdsPerDay)
            return true;
        else
            return false;
    }

    public int CountForFirstDays(int numberOfDays) {
        int firstDays = 0;
        for (int i = 0; i < numberOfDays; i++) {
             firstDays += birdsPerDay[i];
        }
        return firstDays;
    }

    public int BusyDays() {
        int busyDays = 0;

        foreach (var day in birdsPerDay) {
            if (day >= 5) {
               busyDays++; 
            }
        }
        return busyDays;
    }
}
