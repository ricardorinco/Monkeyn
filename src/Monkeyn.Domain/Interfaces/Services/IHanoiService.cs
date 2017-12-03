using Monkeyn.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Monkeyn.Domain.Interfaces.Services
{
    public interface IHanoiService
    {
        Hanoi GetById(Guid id);
        IList<Hanoi> GetAll();

        Hanoi QueueHanoi(int numberDiscs);
    }
}
