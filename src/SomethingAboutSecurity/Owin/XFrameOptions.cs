using System.Threading.Tasks;
using Microsoft.Owin;

namespace SomethingAboutSecurity.Owin
{
    public class XFrameOptions : OwinMiddleware
    {
        public XFrameOptions(OwinMiddleware next) : base(next)
        {
        }

        public override async Task Invoke(IOwinContext context)
        {
            await Next.Invoke(context);

            context.Response.Headers.Set("X-Frame-Options", "SAMEORIGIN");
        }
    }
}