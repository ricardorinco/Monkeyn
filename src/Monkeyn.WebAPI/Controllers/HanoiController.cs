using Monkeyn.Application.Interfaces;
using Monkeyn.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Monkeyn.WebAPI.Controllers
{
    [RoutePrefix("api/hanoi")]
    public class HanoiController : ApiController
    {
        private readonly IHanoiApplicationService hanoiApplicationService;

        public HanoiController(IHanoiApplicationService hanoiApplicationService)
        {
            this.hanoiApplicationService = hanoiApplicationService;
        }

        [HttpGet]
        [Route("{id}")]
        public HanoiViewModel GetById(Guid id)
        {
            return hanoiApplicationService.GetById(id);
        }

        [HttpGet]
        [Route]
        public IList<HanoiViewModel> GetAll()
        {
            return hanoiApplicationService.GetAll();
        }

        [HttpPost]
        [Route("queue/{numberDiscs}")]
        public HanoiViewModel QueueHanoi(int numberDiscs)
        {
            return hanoiApplicationService.QueueHanoi(numberDiscs);
        }
    }
}