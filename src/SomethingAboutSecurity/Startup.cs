using Owin;
using SomethingAboutSecurity.Owin;

namespace SomethingAboutSecurity
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.Use<ContentSecurityPolicy>();
            //appBuilder.Use<HttpStrictTransportSecurity>();
            //appBuilder.Use<PublicKeyPinning>();
            //appBuilder.Use<XFrameOptions>();
            //appBuilder.Use<XXssProtextion>();
            //appBuilder.Use<XContentTypeOptions>();
        }
    }
}