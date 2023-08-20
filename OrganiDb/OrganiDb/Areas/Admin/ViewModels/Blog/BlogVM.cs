namespace OrganiDb.Areas.Admin.ViewModels.Blog
{
    public class BlogVM
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public int ReviewCount { get; set; }
        public bool HasPrevious { get; set; }
        public bool HasNext { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }
    }
}
