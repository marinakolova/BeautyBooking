namespace BeautyBooking.Services.Data.Comments
{
    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Models;

    public class CommentsService : ICommentsService
    {
        private readonly IDeletableEntityRepository<Comment> commentsRepository;

        public CommentsService(IDeletableEntityRepository<Comment> commentsRepository)
        {
            this.commentsRepository = commentsRepository;
        }
    }
}
