using Monkeyn.Domain.Interfaces.Repositories;
using Monkeyn.Domain.Interfaces.Services;
using Monkeyn.Domain.Models;
using System;
using System.Collections.Generic;

namespace Monkeyn.Domain.Services
{
    public class HanoiService : IHanoiService
    {
        private List<Move> moves = new List<Move>();

        private readonly IHanoiRepository hanoiRepository;
        private readonly IStepHanoiService stepHanoiService;

        public HanoiService(IHanoiRepository hanoiRepository, IStepHanoiService stepHanoiService)
        {
            this.hanoiRepository = hanoiRepository;
            this.stepHanoiService = stepHanoiService;
        }

        public Hanoi GetById(Guid id)
        {
            return hanoiRepository.GetById(id);
        }
        public IList<Hanoi> GetAll()
        {
            return hanoiRepository.GetAll();
        }

        public Hanoi QueueHanoi(int numberDiscs)
        {
            var hanoi = new Hanoi
            {
                Id = Guid.NewGuid(),
                Status = "Queue",

                Data = new Data
                {
                    NumberDiscs = numberDiscs,
                    InitialDateTime = DateTime.Now,
                    FinalDateTime = null
                }
            };

            stepHanoiService.Queue(hanoi);
            hanoiRepository.Add(hanoi);

            return hanoi;
        }
    }
}
