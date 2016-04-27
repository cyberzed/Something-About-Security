using System.Threading.Tasks;
using Microsoft.Owin;

namespace SomethingAboutSecurity.Owin
{
    public class PublicKeyPinning : OwinMiddleware
    {
        public PublicKeyPinning(OwinMiddleware next) : base(next)
        {
        }

        public override async Task Invoke(IOwinContext context)
        {
            await Next.Invoke(context);

            //if (context.Request.Scheme.Equals("https"))
            //    context.Response.Headers.Set("Public-Key-Pins",
            //        "pin-sha256='X3pGTSOuJeEVw989IJ/cEtXUEmy52zs1TZQrU06KUKg='; " +
            //        "pin-sha256='MHJYVThihUrJcxW6wcqyOISTXIsInsdj3xK8QrZbHec='; " +
            //        "includeSubdomains; " +
            //        "max-age=2592000");
        }
    }
}