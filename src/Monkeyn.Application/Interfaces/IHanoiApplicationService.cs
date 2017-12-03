using Monkeyn.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Monkeyn.Application.Interfaces
{
    public interface IHanoiApplicationService : IDisposable
    {
        HanoiViewModel GetById(Guid id);
        IList<HanoiViewModel> GetAll();

        HanoiViewModel QueueHanoi(int numberDiscs);
    }
}
