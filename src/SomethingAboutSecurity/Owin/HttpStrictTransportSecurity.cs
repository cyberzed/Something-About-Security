using System.Threading.Tasks;
using Microsoft.Owin;

namespace SomethingAboutSecurity.Owin
{
    public class HttpStrictTransportSecurity : OwinMiddleware
    {
        public HttpStrictTransportSecurity(OwinMiddleware next) : base(next)
        {
        }

        public override async Task Invoke(IOwinContext context)
        {
            await Next.Invoke(context);

            if (context.Request.Scheme.Equals("https"))
                context.Response.Headers.Set("Strict-Transport-Security", "max-age=31536000; includeSubDomains");
        }
    }
}