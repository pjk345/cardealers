namespace cardealers.Models
{
    public class OpinionRepository : IOpinionRepository
    {
        private readonly AppDbContext _appDbContext;

        public OpinionRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;   
        }
        public void AddOpiniion(Opinion opinion)
        {
            _appDbContext.Opinions.Add(opinion);
            _appDbContext.SaveChanges();
        }
    }
}
