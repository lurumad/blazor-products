namespace BlazorProducts.Shared.RequestFeatures
{
    public class ProductParameters
    {
        private int pageSize = 50;
        public int StartIndex { get; set; }
        public int PageSize 
        { 
            get => pageSize; 
            set => pageSize = value; 
        }
    }
}
