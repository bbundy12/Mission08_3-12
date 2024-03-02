
namespace Mission08_3_12.Models
{
    public class EFTaskRepository : ITaskRepository
    {
        private _413firstThingsContext _context;

        public EFTaskRepository(_413firstThingsContext temp)
        {
            _context = temp;
        }
        public IQueryable<TaskFix> Tasks => (IQueryable<TaskFix>)_context.Tasks;

        public IQueryable<Category> Categories => _context.Categories;

        public void AddSingleTask(TaskFix task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }
        public void UpdateSingleTask(TaskFix task)
        {
            _context.Tasks.Update(task);
            _context.SaveChanges();
        }
        public void RemoveSingleTask(TaskFix task)
        {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }
    }
}
