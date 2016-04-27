using System.Threading.Tasks;
using Microsoft.Owin;

namespace SomethingAboutSecurity.Owin
{
    public class ContentSecurityPolicy : OwinMiddleware
    {
        public ContentSecurityPolicy(OwinMiddleware next) : base(next)
        {
        }

        public override async Task Invoke(IOwinContext context)
        {
            await Next.Invoke(context);

            //context.Response.Headers.Set("Content-Security-Policy", "default-src https:");
            context.Response.Headers.Set("Content-Security-Policy", "default-src 'self'");
        }
    }
}