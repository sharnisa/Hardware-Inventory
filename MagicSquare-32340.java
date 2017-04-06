import javax.swing.*;
import java.awt.*;

public class MagicSquare {	
	public static void main(String[] args) {
		int size= Integer.parseInt(JOptionPane.showInputDialog(
		"Enter an odd number as the size of your square"));
		if (size%2==0){
			System.out.println("The size should be odd!");
			System.exit(0);
		}
		int [] [] square= new int [size][size];
		int col = size/2;
		square [0][col]=1;
		square[size-1][col]=size*size;
		square[size-1][(size/2)+1] =2;  
		int row =(size-1)-1;
		col=((size/2)+1)+1;
		for (int i=3; i<((size*size)); i++){		
			if (col>size-1&&row<0){				
				row=row+2;
				col=col-1;				
				square[row][col]=i;
				row=row-1;
				col=col+1;
				}	
		
			else if (row<0){			
			row=size-1;			
		    square[row][col]=i;
		    row=row-1;
			col=col+1;
			}
			
			else if (col>size-1){			
			col=0;			
			square[row][col]=i;
			row=row-1;
			col=col+1;
			}
			
			else if (square[row][col]>0){			
			row=row+2;
			col=col-1;			
			square[row][col]=i;
			row=row-1;
			col=col+1;			
			}	
		else{			
			square[row][col]=i;
			row=row-1;
			col=col+1;
			}		
		}
		
		GUI g = new GUI();
		g.setLayout(new GridLayout(size, size));
		
		for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                if (square[i][j] < 10)  System.out.print(" "); 
                if (square[i][j] < 100) System.out.print(" "); 
                System.out.print(square[i][j] + " ");
                g.p.add(new JButton("" + square[i][j]));
            }
            System.out.println();
        }
		
		g.pack();
		g.setVisible(true);
				
   }
}
