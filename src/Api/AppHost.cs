using Api.ServiceInterface;
using Funq;
using ServiceStack;
using ServiceStack.Auth;

namespace Api
{
    public class AppHost : AppHostBase
    {
        public AppHost()
            : base("IdentityService",
                  typeof(IdentityService).Assembly)
        {

        }

        public override void Configure(Container container)
        {
            Plugins.Add(new AuthFeature(() => new AuthUserSession(),
                new IAuthProvider[] {
                    new JwtAuthProvider(AppSettings)
                    {
                        AuthKey = AesUtils.CreateKey()
                    },
                }));
        }
    }
}
