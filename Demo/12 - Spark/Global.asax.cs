using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using MvcBestPractices.Models;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using Spark.Web.Mvc;

namespace MvcBestPractices
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : NinjectHttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
            );

        }

        protected override void OnApplicationStarted()
        {
            RegisterRoutes(RouteTable.Routes);
            RegisterAllControllersIn("MvcBestPractices");

            Mapper.CreateMap<Post, ShowPostModel>();
            Mapper.CreateMap<Post, EditPostModel>();
            Mapper.CreateMap<EditPostModel, Post>();
            Mapper.AssertConfigurationIsValid();

            ViewEngines.Engines.Add(new SparkViewFactory());
        }

        protected override IKernel CreateKernel()
        {
            return new StandardKernel(new ServiceModule());
        }
    }

    internal class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPostModel>().To<InMemoryPostModel>();
        }
    }
}