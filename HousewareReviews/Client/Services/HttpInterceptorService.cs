using Microsoft.AspNetCore.Components;
using System.Net;
using System.Reflection.Metadata;
using Toolbelt.Blazor;

namespace HousewareReviews.Client.Services
{
	public class HttpInterceptorService
	{
        // Define the HttpClientInterceptor and NavigationManager instances
        private readonly HttpClientInterceptor interceptor;
		private readonly NavigationManager navManager;

        // Constructor that takes the HttpClientInterceptor and NavigationManager instances
        public HttpInterceptorService(HttpClientInterceptor interceptor, NavigationManager navManager)
		{
			this.interceptor = interceptor;
			this.navManager = navManager;
		}

        // Method to subscribe to the AfterSend event of the HttpClientInterceptor
        public void MonitorEvent() => interceptor.AfterSend += InterceptResponse;

		// Method that handles the InterceptResponse when the AfterSend event is triggered
        private void InterceptResponse(object sender, HttpClientInterceptorEventArgs e)
		{
			string message = string.Empty;
            // If the HTTP response is not successful
            if (!e.Response.IsSuccessStatusCode)
			{
                // Get the HTTP status code from the response
                var responseCode = e.Response.StatusCode;
                // Handling the different HTTP status codes
                switch (responseCode)
				{
                    // Navigate to the "/404" page for a Not Found error
                    case HttpStatusCode.NotFound:
						navManager.NavigateTo("/404");
						break;
                    // Navigate to the "/unauthorized" route for Unauthorized or Forbidden errors
                    case HttpStatusCode.Unauthorized:
					case HttpStatusCode.Forbidden:
						navManager.NavigateTo("/unauthorized");
						break;
                    // Navigate to the "/500" route for other errors
                    default:
						navManager.NavigateTo("/500");
						break;
				}
			}
		}

        // Method to unsubscribe from the AfterSend event of the HttpClientInterceptor
        public void DisposeEvent() => interceptor.AfterSend -= InterceptResponse;
	}
}
