using AutoMapper;
using Monkeyn.Application.Interfaces;
using Monkeyn.Application.ViewModels;
using Monkeyn.Domain.Interfaces.Services;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Monkeyn.Application.Services
{
    public class HanoiApplicationService : IHanoiApplicationService
    {
        private Queue localQueue = new Queue();
        private readonly IHanoiService hanoiService;

        public HanoiApplicationService(IHanoiService hanoiService)
        {
            this.hanoiService = hanoiService;
        }

        public HanoiViewModel GetById(Guid id)
        {
            return Mapper.Map<HanoiViewModel>(hanoiService.GetById(id));
        }
        public IList<HanoiViewModel> GetAll()
        {
            return Mapper.Map<IList<HanoiViewModel>>(hanoiService.GetAll());
        }

        public HanoiViewModel QueueHanoi(int numberDiscs)
        {
            return Mapper.Map<HanoiViewModel>(hanoiService.QueueHanoi(numberDiscs));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
