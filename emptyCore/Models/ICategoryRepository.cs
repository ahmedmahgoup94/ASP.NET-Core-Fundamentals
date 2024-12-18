namespace emptyCore.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategory {  get; }
    }
}
