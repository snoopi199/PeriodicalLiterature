using Ninject.Modules;
using PeriodicalLiterature.Contracts;
using PeriodicalLiterature.Contracts.Repository;
using PeriodicalLiterature.DAL.Repository;
using PeriodicalLiterature.Servises.Providers;
using PeriodicalLiterature.Servises.Providers.IProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.CR
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IPublisherRepository>().To<PublisherRepository>();
            Bind<IAdminRepository>().To<AdminRepository>();
            Bind<IBossRepository>().To<BossRepository>();

            Bind<IEditionRepository>().To<EditionRepository>();
            Bind<ICommentRepository>().To<CommentRepository>();
            Bind<IContractRepository>().To<ContractRepository>();


            Bind<IProviderPublisherRepository>().To<ProviderPublisherRepository>();
            Bind<IProviderBossRepository>().To<ProviderBossRepository>();
            Bind<IProviderAdminRepository>().To<ProviderAdminRepository>();


            Bind<IProviderEditionRepository>().To<ProviderEditionRepository>();
            Bind<IProviderContractRepository>().To<ProviderContractRepository>();
           




        }
    }
}