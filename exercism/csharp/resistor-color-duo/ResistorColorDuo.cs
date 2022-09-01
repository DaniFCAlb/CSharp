using System;

public static class ResistorColorDuo {
    public static int Value(string[] colors) {
        string[] bandColors = {"black", "brown", "red", "orange", "yellow", "green",
                                        "blue", "violet", "grey", "white"};
        string resist = "";

        for (int i = 0; i < colors.Length; i++) { // index fora do limite do array i < color.Length
            //resist += Array.IndexOf(colors, color[i]); mal....
            resist += Array.IndexOf(bandColors, colors[i]);
            Console.WriteLine(resist);
        }     
        return Int32.Parse(resist); // converter string para int
    }
}
