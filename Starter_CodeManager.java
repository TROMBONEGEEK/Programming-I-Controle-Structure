import java.util.ArrayList;

public class Starter_CodeManager {
    private ArrayList<Starter_Code> taskList;

    public Starter_CodeManager() {
        taskList = new ArrayList<>();
    }

    // Add a new task
    public void addTask(String description) {
        taskList.add(new Starter_Code(description));
        System.out.println("Task added successfully!");
    }

    // Display all tasks with 1-based indexing
    public void printTasks() {
        if (taskList.isEmpty()) {
            System.out.println("No tasks found. Take a break!");
            return;
        }

        System.out.println("\n--- YOUR TASKS ---");
        for (int i = 0; i < taskList.size(); i++) {
            System.out.println((i + 1) + ". " + taskList.get(i));
        
        }
    }

    // Mark task as complete using its desplayed index
    public void completeTask(int index) {
        int actualIndex = index - 1; // Convert 1-based user input to 0-based array index
        if (actualIndex >= 0 && actualIndex < taskList.size()) {
            taskList.get(actualIndex).markComplete();
            System.out.println("Task marked as complete!");
        } else {
            System.out.println("Invalid task number.");
        }
    }
}