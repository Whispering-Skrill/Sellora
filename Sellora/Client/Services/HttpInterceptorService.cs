using Microsoft.AspNetCore.Components;
using System.Net;
using Toolbelt.Blazor;

namespace Sellora.Client.Services
{
    // Service for intercepting HTTP responses
    public class HttpInterceptorService
    {
        // HttpClientInterceptor instance for intercepting HTTP requests and responses
        private readonly HttpClientInterceptor interceptor;

        // NavigationManager for handling navigation within the application
        private readonly NavigationManager navManager;

        // Constructor to initialize the service with required dependencies/parameters
        public HttpInterceptorService(HttpClientInterceptor interceptor, NavigationManager navManager)
        {
            this.interceptor = interceptor;
            this.navManager = navManager;
        }

        // Method to start monitoring HTTP events
        public void MonitorEvent() => interceptor.AfterSend += InterceptResponse;

        // Method to handle intercepted HTTP response
        private void InterceptResponse(object sender, HttpClientInterceptorEventArgs e)
        {
            string message = string.Empty;

            // This checks if the response is not successful
            if (!e.Response.IsSuccessStatusCode)
            {
                // This gets the HTTP Status Code from the response
                var responseCode = e.Response.StatusCode;

                switch (responseCode)
                {
                    // If the status code is 404 (Not Found)
                    case HttpStatusCode.NotFound:
                        navManager.NavigateTo("/404");
                        message = "The requested resource was not found.";
                        break;

                    // If the status code is 401 (Unauthorized)
                    case HttpStatusCode.Unauthorized:
                        navManager.NavigateTo("/unauthorized");
                        message = "You are not authorised to access this resource.";
                        break;

                    // If the status code is 403 (Forbidden)
                    case HttpStatusCode.Forbidden:
                        navManager.NavigateTo("/unauthorized");
                        message = "You are not authorised to access this resource.";
                        break;


                    // For any other status codes, navigate to a error 500 page (General)
                    default:
                        navManager.NavigateTo("/500");
                        message = "Something went wrong, please contact Administrator";
                        break;
                }
            }
        }

        // Method to stop monitoring HTTP events
        public void DisposeEvent() => interceptor.AfterSend -= InterceptResponse;
    }
}
