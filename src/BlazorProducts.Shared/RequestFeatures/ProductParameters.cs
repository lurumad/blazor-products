namespace BlazorProducts.Shared.RequestFeatures
{
    public class ProductParameters
    {
        const int MaxPageSize = 50;
        private int pageSize = 4;
        public int PageNumber { get; set; } = 1;
        public int PageSize 
        {
            get => pageSize;
            set => pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }
        public string SearchTerm { get; set; }
        public string OrderBy { get; set; } = "name";
    }
}
