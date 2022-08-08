using System;
using System.Collections.Generic;
using System.Linq;

public static class SaddlePoints {
    
    public static IEnumerable<(int, int)> Calculate(int[,] matrix) {

       // iterar por toda a matriz, linha a linha
       // descobrir o max da linha atual 
       // verificar se este max também é o min da coluna 
       // verificar se há 0 ou + pontos sela 
        int row_max = matrix.GetLength(0); // nº elementos linha
        int col_min = matrix.GetLength(1); // nº elemtos coluna
        
        for (int i = 1; i < row_max; i++) { 
        
            for (int j = 1; j < col_min; j++) {
                
               if (i == row_max && j == col_min){
                    yield return(i,j);
               } 
            }
        }
    }
}
