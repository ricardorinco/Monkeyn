using Monkeyn.Domain.Models;
using System;
using System.Collections.Generic;

namespace Monkeyn.Domain.Interfaces.Repositories
{
    public interface IHanoiRepository
    {
        Hanoi Add(Hanoi hanoi);
        Hanoi Update(Hanoi hanoi);

        Hanoi GetById(Guid id);
        IList<Hanoi> GetAll();
    }
}
