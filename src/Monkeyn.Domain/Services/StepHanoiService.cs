using Monkeyn.Domain.Interfaces.Repositories;
using Monkeyn.Domain.Interfaces.Services;
using Monkeyn.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Monkeyn.Domain.Services
{
    public class StepHanoiService : IStepHanoiService
    {
        private Thread threadQueue;

        private Queue<Hanoi> queueHanois = new Queue<Hanoi>();
        private List<Move> moves;

        private readonly IHanoiRepository hanoiRepository;

        public StepHanoiService(IHanoiRepository hanoiRepository)
        {
            this.hanoiRepository = hanoiRepository;
            moves = new List<Move>();

            threadQueue = new Thread(VerifyTime);
            threadQueue.Start();
        }

        public void Queue(Hanoi hanoi)
        {
            queueHanois.Enqueue(hanoi);
        }

        public void ProcessQueue()
        {
            while (queueHanois.Count != 0)
            {
                var hanoiProcess = queueHanois.Dequeue();
                hanoiProcess.Status = "In Process";
                hanoiRepository.Update(hanoiProcess);

                MoveHanoi(hanoiProcess);
            }
        }

        private void MoveHanoi(Hanoi hanoi)
        {
            MovePins(hanoi.Data.NumberDiscs, 'A', 'C', 'B');

            hanoi.Moves.AddRange(moves);
            hanoi.Data.FinalDateTime = DateTime.Now;
            hanoi.Status = "Finished";

            hanoiRepository.Update(hanoi);
        }

        private void MovePins(int numberDiscs, char startPin, char endPin, char tempPin)
        {
            if (numberDiscs > 0)
            {
                MovePins(numberDiscs - 1, startPin, tempPin, endPin);
                moves.Add(new Move { FromPin = startPin, ToPin = endPin });
                MovePins(numberDiscs - 1, tempPin, endPin, startPin);
            }
        }

        private void VerifyTime()
        {
            while (true)
            {
                ProcessQueue();
                Thread.Sleep(new TimeSpan(0, 1, 0));
            }
        }
    }
}
