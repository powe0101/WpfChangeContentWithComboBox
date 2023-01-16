using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfChangeContentWithComboBox.ViewModel;

namespace WpfChangeContentWithComboBox.Locator
{
    public class ViewModelLocator
    {
        public IServiceProvider ServiceProvider { get; set; }

        public ViewModelLocator() 
        {
            ServiceProvider = ConfigureServices();
        }

        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddTransient(typeof(MainViewModel));

            return services.BuildServiceProvider();
        }

        public MainViewModel MainViewModel
        {
            get
            {
                return ServiceProvider.GetService<MainViewModel>();
            }
        }
    }
}
