namespace Sellora.Client.Static
{
    public static class Endpoints
    {
        // Api Prefix for endpoint calling
        private static readonly string Prefix = "api";

        // This initialises the endpoints for each class=
        public static readonly string UsersEndpoint = $"{Prefix}/users";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
        public static readonly string ReportsEndpoint = $"{Prefix}/reports";
        public static readonly string ReviewsEndpoint = $"{Prefix}/reviews";
        public static readonly string SwapTransactionsEndpoint = $"{Prefix}/swaptransactions";
        public static readonly string SaleTransactionsEndpoint = $"{Prefix}/saletransactions";


    }
}
