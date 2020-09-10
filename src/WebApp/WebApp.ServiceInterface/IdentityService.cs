using ServiceStack;
using WebApp.ServiceModel;

namespace WebApp.ServiceInterface
{
    [Authenticate]
    public class IdentityService : Service
    {
        public object Any(GetIdentity request)
        {
            return new GetIdentityResponse
            {
                Claims = Request.GetClaims().Map(x => new Property { Name = x.Type, Value = x.Value }),
                Session = SessionAs<AuthUserSession>(),
            };
        }
    }
}
