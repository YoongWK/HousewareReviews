namespace HousewareReviews.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string CategoriesEndpoint = $"{Prefix}/categories";
        public static readonly string CommentsEndpoint = $"{Prefix}/comments";
        public static readonly string CompaniesEndpoint = $"{Prefix}/companies";
        public static readonly string ConsumersEndpoint = $"{Prefix}/consumers";
        public static readonly string ProductsEndpoint = $"{Prefix}/products";
        public static readonly string ReviewreportsEndpoint = $"{Prefix}/reviewreports";
		public static readonly string CommentreportsEndpoint = $"{Prefix}/commentreports";
		public static readonly string ReviewsEndpoint = $"{Prefix}/reviews";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
    }
}
