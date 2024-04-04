
using Aerotec.Data.Model;
using AerotecInterfaces.Services;
using Jet3Up.Services;
using Jet3Up.Services.Mockup;
using Jet3UpInterfaces.Factories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace IoC
{
    public class IoCContainer
    {
        private IHost host { get; }
        private IoCContainer()
        {
            host = StartIoCContainer();
        }
        private IHost StartIoCContainer()
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder();
#if !DEBUG
            builder.Services.AddSingleton<IClientService, TCPClientService>();
            builder.Services.AddSingleton<IUserFactory, UserFactory>();
            builder.Services.AddSingleton<IUserContainer, UserContianer>();
#else
            builder.Services.AddSingleton<IClientService, TCPMockUpClient>();
            builder.Services.AddSingleton<IUserFactory, UserFactoryMockup>();
            builder.Services.AddSingleton<IUserContainer, UserContianerMock>();
            
#endif
            IHost host = builder.Build();

            host.Run();
            return host;

        }

        private static IoCContainer instance;

        public static IHost Instance { 
            get { 
                if(instance == null)
                    instance = new IoCContainer();
                return instance.host; 
            }
        }
    }
}
