namespace Mission08_3_12.Models
{
    public interface iTaskRepository
    {
        List<Task> Tasks { get; }

        public void AddTask(Task task);

    }
}
