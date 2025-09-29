using CodePulse.API.Data;
using CodePulse.API.Models.Domain;
using CodePulse.API.Respositories.Interface;

namespace CodePulse.API.Respositories.Implementation
{
    public class CategoryRespository : ICategoryRespository
    {
        private readonly ApplicationDbContext dbContext;
        public CategoryRespository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Category> CreateAsync(Category category)
        {
            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();
            return category;
        }
    }
}
