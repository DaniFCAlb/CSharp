using System;
using System.Collections.Generic;
using System.Linq;

public static class SaddlePoints {
    public static IEnumerable<(int, int)> Calculate(int[,] matrix) {

       // iterar por toda a matriz, linha a linha
       // descobrir o max da linha atual 
       // verificar se este max também é o min da coluna 
       // verificar se há 0 ou + pontos sela 
        int row = matrix.GetLength(0); // obter nº elementos da linha 
        int col = matrix.GetLength(1); // obter nº elementos da coluna
    
        for (int i = 0; i < row; i++) {
            int row_max = matrix [i, 0]; // obter o primeiro elemento da linha 

            for (int j = 0; j < col; j++) {
                
                if (row_max < matrix[i, j]) {
                    row_max = matrix[i, j];
                                
                }
            }
        }        
    }
}
