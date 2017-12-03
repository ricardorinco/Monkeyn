using Monkeyn.Domain.Interfaces.Repositories;
using Monkeyn.Domain.Models;
using System;
using System.Collections.Generic;

namespace Monkeyn.Infrastructure.Data.Repositories
{
    public class HanoiRepository : IHanoiRepository
    {
        private List<Hanoi> hanois = new List<Hanoi>();

        public Hanoi Add(Hanoi hanoi)
        {
            if (hanoi == null)
                throw new ArgumentNullException("Torre de Hanói nulo.");

            hanois.Add(hanoi);

            return hanoi;
        }
        public Hanoi Update(Hanoi hanoi)
        {
            if (hanoi == null)
                throw new ArgumentNullException("Torre de Hanói nulo.");

            int hanoiIndex = hanois.FindIndex(p => p.Id == hanoi.Id);

            if (hanoiIndex == -1)
                throw new ArgumentNullException("Torre de Hanói não localizado.");

            hanois.RemoveAt(hanoiIndex);
            hanois.Add(hanoi);

            return hanoi;
        }

        public Hanoi GetById(Guid id)
        {
            return hanois.Find(p => p.Id == id);
        }
        public IList<Hanoi> GetAll()
        {
            return hanois;
        }
    }
}
