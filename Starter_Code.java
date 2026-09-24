public class Starter_Code {
    private String description;
    private boolean isCompleted;

    // Constructor
    public Starter_Code(String description) {
        this.description = description;
        this.isCompleted = false; // New tasks start incomplete
    }

    // Getters and Setters
    public boolean isCompleted() {
        return isCompleted;
    }

    public void markComplete() {
        this.isCompleted = true;
    }

    // Formatted output for display
    @Override
    public String toString() {
        String status = isCompleted ? "[X]" : "[]";
        return status + " " + description;
    }
}
