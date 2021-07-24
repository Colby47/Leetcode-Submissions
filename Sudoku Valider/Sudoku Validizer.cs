//ALL ROWS, COLUMNS, OR NONNETS MUST ADD UP TO 45
//MUST BE NO DUPLICATES

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        for(int i = 0; i < 9; i++){
            
            //everytime we hit a new row, check the row
            if(checkRow(board, i) == false){
                return false;
            }
            
            for(int j = 0; j < 9; j++){
                
                //everytime we hit a new column, check the column
                if(checkCol(board, j) == false){
                    return false;
                }
                
                //every 3 rows and 3 columns, check the nonnet
                if(i == 0 || i == 3 || i == 6){
                    
                    if(j == 0 || j == 3 || j == 6){
                        
                        Console.Write($"Checking nonnet at row {i} and col {j}\n");
                        
                        if (checkNonnet(board, i, j) == false){
                            return false;
                        }
                    }
                }
            }
        }
        
        return true;
        
    }
    
    bool checkRow(char[][] board, int row){
        
        //creates dictionary to store the row values as keys
        Dictionary <int, int> noDups = new Dictionary <int, int>();
        
        //loop through board row
        for(int i = 0; i < 9; i++){
            
            //try adding the value
            try
            {
                
                //if space is empty, skip it
                if(board[row][i] == '.'){
                    continue;
                }
                
                noDups.Add(board[row][i], i);
            }
            //if there is a duplicate, return false because row is invalid
            catch(ArgumentException){
                return false;
            }
        }
        
        //return true because the row would be valid
        return true;
    }
    
    bool checkCol(char[][] board, int col){
        
        //creates dictionary to store the row values as keys
        Dictionary <int, int> noDups = new Dictionary <int, int>();
        
        //loop through board col
        for(int i = 0; i < 9; i++){
            
            //try adding the value
            try
            {
                
                //if space is empty, skip it
                if(board[i][col] == '.'){
                    continue;
                }
                
                noDups.Add(board[i][col], i);
            }
            //if there is a duplicate, return false because col is invalid
            catch(ArgumentException){
                return false;
            }
        }
        
        //return true because the col would be valid
        return true;
    }
    
    bool checkNonnet(char[][] board, int row, int col){
        
        //creates dictionary to store the row values as keys
        Dictionary <int, int> noDups = new Dictionary <int, int>();
        
        //loop through rows of nonnet
        for(int i = 0; i < 3; i++){
            
            //loop through columns of nonnet
            for(int j = 0; j < 3; j++){
                
                //try adding the value
                try
                {
                    //if space is empty, skip it
                    if(board[row + i][col + j] == '.'){
                        continue;
                    }
                    
                    Console.Write($"adding {board[row + i][col + j]}\n");
                    noDups.Add(board[row + i][col + j], i);
                }
                
                //if there is a duplicate, return false because row is invalid
                catch(ArgumentException){
                    return false;
                }
            }
        }
        
        //return true because the nonnet would be valid
        return true;
    }
}