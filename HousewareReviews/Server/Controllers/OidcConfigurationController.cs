using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Mvc;

namespace HousewareReviews.Server.Controllers
{
    public class OidcConfigurationController : Controller
    {
        // Define the ILogger<OidcConfigurationController> instance
        private readonly ILogger<OidcConfigurationController> _logger;

        // Constructor that takes the IClientRequestParametersProvider & ILogger<OidcConfigurationController> parameters
        public OidcConfigurationController(IClientRequestParametersProvider clientRequestParametersProvider, ILogger<OidcConfigurationController> logger)
        {
            ClientRequestParametersProvider = clientRequestParametersProvider;
            _logger = logger;
        }

        // Public property to expose the client request parameters provider
        public IClientRequestParametersProvider ClientRequestParametersProvider { get; }

        // Action method to handle GET requests for client-specific OIDC configuration
        [HttpGet("_configuration/{clientId}")]
        public IActionResult GetClientRequestParameters([FromRoute] string clientId)
        {
            // Retrieve client-specific request parameters using the provider
            var parameters = ClientRequestParametersProvider.GetClientParameters(HttpContext, clientId);
            return Ok(parameters);
        }
    }
}
