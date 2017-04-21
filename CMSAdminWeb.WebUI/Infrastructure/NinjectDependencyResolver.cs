using CMSAdminWeb.Domain.Abstract;
using CMSAdminWeb.Domain.Concrete;
using CMSAdminWeb.WebUI.Infrastructure.Abstract;
using CMSAdminWeb.WebUI.Infrastructure.Concrete;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSAdminWeb.WebUI.Infrastructure
{
    public class NinjectDependencyResolver:IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernerlParam)
        {
            kernel = kernerlParam;
            AddBinding();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        public void AddBinding()
        {
            kernel.Bind<IUserRespository>().To<EFUserRepository>();
            kernel.Bind<IFileRespository>().To<EFFileRepository>();
            kernel.Bind<IManagerRespository>().To<EFManagerRepository>();
            kernel.Bind<ISccrecordRespository>().To<EFSccrecordRepository>();
            kernel.Bind<ISignRecordRespository>().To<EFSignRecordRepository>();
            kernel.Bind<IStudutyRespository>().To<EFStudutyRepository>();
            kernel.Bind<ITermRespository>().To<EFTermRepository>();
            kernel.Bind<IPcmessageRespository>().To<EFPcmessageRepository>();
            kernel.Bind<INoticeRespository>().To<EFNoticeRepository>();
            kernel.Bind<IMessageRespository>().To<EFMessageRepository>();

            kernel.Bind<IAuthProvider>().To<FormsAuthProvider>();
        }
    }
}