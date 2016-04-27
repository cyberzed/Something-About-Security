using System.Threading.Tasks;
using Microsoft.Owin;

namespace SomethingAboutSecurity.Owin
{
    public class XXssProtextion : OwinMiddleware
    {
        public XXssProtextion(OwinMiddleware next) : base(next)
        {
        }

        public override async Task Invoke(IOwinContext context)
        {
            await Next.Invoke(context);

            context.Response.Headers.Set("X-Xss-Protection", "1; mode=block");
        }
    }
}