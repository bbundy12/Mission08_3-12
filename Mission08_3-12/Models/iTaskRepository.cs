namespace Mission08_3_12.Models
{
    public interface ITaskRepository
    {
        IQueryable<TaskFix> Tasks { get; }
        IQueryable<Category> Categories { get; }

        public void AddSingleTask(TaskFix task);
        public void RemoveSingleTask(TaskFix task);
    }
}
