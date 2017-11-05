﻿using Autofac;
using Module = Autofac.Module;
using PX.Owin;

namespace PX.SmartSheetIntegration
{
    internal class ServiceRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
               .RegisterType<SSAuthenticationHandler>()
               .As<IOwinConfigurationPart>();
        }
    }
}