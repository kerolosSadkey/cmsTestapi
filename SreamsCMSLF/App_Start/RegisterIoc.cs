using Autofac;
using Autofac.Integration.Mvc;
using SreamsCMSLF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SreamsCMSLF.App_Start
{
    public static class RegisterIoc
    {
        public static void RegisterationIoc()
        {
            var builder = new ContainerBuilder();

          
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(GenericRepository<>)).InstancePerRequest();
            builder.RegisterType<UnitOfwork>().As<IUnitOfwork>().InstancePerRequest();

            //builder.RegisterType<PositiveValuesService>().As<IValuesService>().AsSelf();

            //builder.Register(ctx => new NegativeValuesController(ctx.Resolve<NegativeValuesService>()));

            //builder.Register(ctx => new PositiveValuesController(ctx.Resolve<PositiveValuesService>()));


            IContainer AutofacContainer = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(AutofacContainer));

        }

    }
}
