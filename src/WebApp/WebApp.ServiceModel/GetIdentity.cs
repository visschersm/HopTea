using ServiceStack;
using System.Collections.Generic;

namespace WebApp.ServiceModel
{
    [Route("/servicestack-identity")]
    public class GetIdentity : IReturn<GetIdentityResponse>
    {
    }

    public class GetIdentityResponse
    {
        public List<Property> Claims { get; set; }
        public AuthUserSession Session { get; set; }
    }
}
