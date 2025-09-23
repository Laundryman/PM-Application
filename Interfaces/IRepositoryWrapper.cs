namespace PMApplication.Interfaces
{
        public interface IRepositoryWrapper
        {
            IPartRepository Part { get; }
            Task SaveAsync();
        }
}
