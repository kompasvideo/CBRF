using CBRF.Interfaces;
using CBRF.Interfaces.BIK;
using CBRF.Interfaces.UFEBS_2023_4_1;
using CBRF.Services;
using CBRF.Services.BIK;
using CBRF.Services.UFEBS_2023_4_1;
using CBRF.ViewModels;
using CBRF.ViewModels.BIK;
using CBRF.ViewModels.Main;
using CBRF.ViewModels.UFEBS_2023_4_1;
using CBRF_DB.Interfaces;
using CBRF_DB.Interfaces.UFEBS_2023_4_1;
using CBRF_DB.Services;
using CBRF_DB.Services.UFEBS_2023_4_1;
using Microsoft.Extensions.DependencyInjection;

namespace CBRF
{
    sealed public class ViewModelLocator
    {
        private static ServiceProvider _provider;

        public static void Init()
        {
            var services = new ServiceCollection();

            services.AddTransient<MainWindowViewModel>();
            services.AddTransient<HeaderViewModel>();
            services.AddSingleton<PageMainViewModel>();
            services.AddSingleton<PageDirectoryBIKViewViewModel>();
            services.AddSingleton<PageCbrDsigEnvV110ViewModel>();
            services.AddSingleton<PageService>();
            services.AddSingleton<MessageBus>();
            services.AddSingleton<IDirectoryBIK, DirectoryBIK>();
            services.AddSingleton<IDBDirectoryBIK, DBDirectoryBIK>();
            services.AddSingleton<ICbrDsigEnvV110, CbrDsigEnvV110>();
            services.AddSingleton<ICbrDsigV110, CbrDsigV110>();
            services.AddSingleton<IXmlFile, XmlFile>();
            services.AddSingleton<IDBCbrDsigEnvV110, DBCbrDsigEnvV110> ();

            _provider = services.BuildServiceProvider();

            foreach (var item in services)
            {
                _provider.GetRequiredService(item.ServiceType);
            }
        }
        public MainWindowViewModel MainWindowViewModel => _provider.GetRequiredService<MainWindowViewModel>();
        public HeaderViewModel HeaderViewModel => _provider.GetRequiredService<HeaderViewModel>();
        public PageMainViewModel PageMainViewModel => _provider.GetRequiredService<PageMainViewModel>();
        public PageDirectoryBIKViewViewModel PageDirectoryBIKViewViewModel => _provider.GetRequiredService<PageDirectoryBIKViewViewModel>();
        public PageCbrDsigEnvV110ViewModel PageCbrDsigEnvV110ViewModel => _provider.GetRequiredService<PageCbrDsigEnvV110ViewModel>();
    }
}
