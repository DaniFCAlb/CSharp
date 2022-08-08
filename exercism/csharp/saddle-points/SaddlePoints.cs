using System;
using System.Collections.Generic;
using System.Linq;

public static class SaddlePoints {
    
    public static IEnumerable<(int, int)> Calculate(int[,] matrix) {

       // iterar por toda a matriz, linha a linha
       // descobrir o max da linha atual 
       // verificar se este max também é o min da coluna 
       // verificar se há 0 ou + pontos sela 
        
        for (int i = 0; i < matrix.Length; i++) { 
            
            for (int j = 0; j < matrix.Length; j++) {
                
                if (i == j) {
                   yield return (i, j);   
                   
                }
            }
        }
    }
}
