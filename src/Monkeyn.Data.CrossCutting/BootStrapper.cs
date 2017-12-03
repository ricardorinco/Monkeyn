using Monkeyn.Application.Interfaces;
using Monkeyn.Application.Services;
using Monkeyn.Domain.Interfaces.Repositories;
using Monkeyn.Domain.Interfaces.Services;
using Monkeyn.Domain.Services;
using Monkeyn.Infrastructure.Data.Repositories;
using SimpleInjector;

namespace Monkeyn.Data.CrossCutting
{
    public class BootStrapper
    {
        public static void Register(Container container)
        {
            // Application
            container.Register<IHanoiApplicationService, HanoiApplicationService>(Lifestyle.Scoped);

            // Domain
            container.Register<IHanoiService, HanoiService>(Lifestyle.Singleton);
            container.Register<IStepHanoiService, StepHanoiService>(Lifestyle.Singleton);

            // Repository
            container.Register<IHanoiRepository, HanoiRepository>(Lifestyle.Singleton);
        }
    }
}
