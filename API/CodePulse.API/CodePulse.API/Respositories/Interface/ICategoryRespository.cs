using CodePulse.API.Models.Domain;

namespace CodePulse.API.Respositories.Interface
{
    public interface ICategoryRespository
    {
        Task<Category> CreateAsync(Category category);
    }
}
