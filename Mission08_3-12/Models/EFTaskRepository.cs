
namespace Mission08_3_12.Models
{
    public class EFTaskRepository : iTaskRepository
    {
        private _413firstThingsContext _context;

        public EFTaskRepository(_413firstThingsContext temp)
        {
            _context = temp;
        }
        public List<Task> Tasks => _context.Tasks.ToList();
        public void AddTask(Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }
    }
}
