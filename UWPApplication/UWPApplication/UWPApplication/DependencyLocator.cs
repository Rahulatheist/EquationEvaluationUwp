using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace UWPApplication
{
    public static class DependencyLocator
    {
        public static readonly IContainer container;

        static DependencyLocator()
        {
            var bilder = new ContainerBuilder();
            bilder.RegisterType<MainPageViewModel>();
            container = bilder.Build();
        }

        public static ServiceType Resolve<ServiceType>(object initialData = null) where ServiceType : class
        {
            return container.Resolve<ServiceType>(new NamedParameter("initialData", initialData));
        }
    }
}
