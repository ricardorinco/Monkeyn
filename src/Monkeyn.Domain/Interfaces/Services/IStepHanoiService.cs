using Monkeyn.Domain.Models;

namespace Monkeyn.Domain.Interfaces.Services
{
    public interface IStepHanoiService
    {
        void Queue(Hanoi hanoi);
        void ProcessQueue();
    }
}
