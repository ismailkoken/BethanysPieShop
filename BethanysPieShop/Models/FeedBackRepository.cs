using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class FeedBackRepository : IFeedbackRepository
    {
        private readonly AppDbContext _appDbContext;

        public FeedBackRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddFeedBack(Feedback feedback)
        {
            _appDbContext.Feedbacks.Add(feedback);
            _appDbContext.SaveChanges();

        }
    }
}
