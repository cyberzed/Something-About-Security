using System.Threading.Tasks;
using Microsoft.Owin;

namespace SomethingAboutSecurity.Owin
{
    public class XContentTypeOptions : OwinMiddleware
    {
        public XContentTypeOptions(OwinMiddleware next) : base(next)
        {
        }

        public override async Task Invoke(IOwinContext context)
        {
            await Next.Invoke(context);

            context.Response.Headers.Set("X-Content-Type-Options", "\"nosniff\"");
        }
    }
}