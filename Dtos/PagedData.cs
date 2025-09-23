namespace PMApplication.Dtos
{
    public interface PagedData<T>
    {
        public Page Page { get; set; }
        public List<T> data { get; set; }

    }
}
