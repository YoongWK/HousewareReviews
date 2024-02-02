namespace HousewareReviews.Client.Static
{
    // Class to store all endpoints string
    public static class Endpoints
    {
        // Common prefix for all API endpoints
        private static readonly string Prefix = "api";

        // String for Category endpoint
        public static readonly string CategoriesEndpoint = $"{Prefix}/categories";
        // String for Comment endpoint
        public static readonly string CommentsEndpoint = $"{Prefix}/comments";
        // String for Company endpoint
        public static readonly string CompaniesEndpoint = $"{Prefix}/companies";
        // String for Consumer endpoint
        public static readonly string ConsumersEndpoint = $"{Prefix}/consumers";
        // String for Product endpoint
        public static readonly string ProductsEndpoint = $"{Prefix}/products";
        // String for Reviewreport endpoint
        public static readonly string ReviewreportsEndpoint = $"{Prefix}/reviewreports";
        // String for Commentreport endpoint
        public static readonly string CommentreportsEndpoint = $"{Prefix}/commentreports";
        // String for Review endpoint
        public static readonly string ReviewsEndpoint = $"{Prefix}/reviews";
        // String for Staff endpoint
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
    }
}
