import java.util.Scanner;

public class HelloWorld {
    public static void main(String[] args) {
        
        //creates a reader instance that takes
        //input from standard keyboard
        Scanner reader = new Scanner(System.in);
        System.out.print("Enter a number: ");
        
        //nextInt() reads the next Integer from the keyboard
        int number = reader.nextInt();
        
        //println() print the following line to the output
        System.out.println("you entered: " + number); 
    }
}