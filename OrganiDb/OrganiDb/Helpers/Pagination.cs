namespace OrganiDb.Helpers
{
    public class Pagination<T>
    {
        public IEnumerable<T> Datas { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }

        public Pagination(IEnumerable<T> datas, int currentPage, int totalPage)
        {
            Datas = datas;
            CurrentPage = currentPage;
            TotalPage = totalPage;
        }

        public bool HasNext {
            get
            {
                return CurrentPage < TotalPage;
            }
        }

        public bool HasPrevious
        {
            get
            {
                return CurrentPage > 1;
            }
        }
    }
}
