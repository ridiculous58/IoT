using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using DataAccess.Concrete;
using DataAccess.Interfaces;
using Infrastructure.Utilities.Interceptors;
using Infrastructure.Utilities.Security.JWT;
using Services.AuthServices;
using Services.DataServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.IoCService.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
