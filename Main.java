import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Starter_CodeManager manager = new Starter_CodeManager();
        boolean running = true;

        System.out.println("===================================");
        System.out.println(" Welcome to Mini Task Tracker! ");
        System.out.println("===================================");
        
        while (running) {
            System.out.println("/nOptions:");
            System.out.println("1. Add Task");
            System.out.println("2. View Tasks");
            System.out.println("4. Exit");
            System.out.print("Choose an option: ");
            
            int choice = scanner.nextInt();
            scanner.nextLine(); // Clear newline buffer

            switch (choice) {
            case 1:
                System.out.print("Enter task description: ");
                String desc = scanner.nextLine();
                manager.addTask(desc);
                break;
            case 2:
                manager.printTasks();
                break;
            case 3:
                manager.printTasks();
                System.out.print("Enter task number to complete: ");
                int taskNum = scanner.nextInt();
                manager.completeTask(taskNum);
                break;
            case 4:
                running = false;
                System.out.println("Goodbye!");
                break;
            default:
                System.out.println("Invalid choice. Try again.");
                scanner.nextLine(); // Clear invalid input
            }
        }

        scanner.close();
    }
}