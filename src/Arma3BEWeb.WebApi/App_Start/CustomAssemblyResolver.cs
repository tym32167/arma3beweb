using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Http.Dispatcher;
using Arma3BEWeb.WebApi.Controllers;

namespace Arma3BEWeb.WebApi
{
    public class CustomAssemblyResolver : DefaultAssembliesResolver
    {
        public override ICollection<Assembly> GetAssemblies()
        {
            ICollection<Assembly> baseAssemblies = base.GetAssemblies();
            List<Assembly> assemblies = new List<Assembly>(baseAssemblies);
            Type myType = typeof (TestController);
            var controllersAssembly = Assembly.GetAssembly(myType);
            baseAssemblies.Add(controllersAssembly);
            return assemblies;
        }
    }
}