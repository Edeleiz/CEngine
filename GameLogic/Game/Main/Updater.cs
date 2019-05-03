using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;
using CGame.Core.Objects;

namespace CGame.Game.Main
{
    public class Updater
    {
        public const int UpdateInterval = 100;
        
        private Timer _loopTimer;
        private List<IUpdatable> _objects;

        private long _previousTicks;
        
        public Updater()
        {
            Initialize();
        }

        public void Start()
        {
            _previousTicks = Stopwatch.GetTimestamp();
            _loopTimer.Start();
        }

        public void Stop()
        {
            _loopTimer.Stop();
        }

        public void AddObject(IUpdatable updatable)
        {
            if (!_objects.Contains(updatable))
            {
                _objects.Add(updatable);
            }
        }

        public void RemoveObject(IUpdatable updatable)
        {
            if (_objects.Contains(updatable))
            {
                _objects.Remove(updatable);
            }
        }

        private void Initialize()
        {
            _objects = new List<IUpdatable>();

            _loopTimer = new Timer {Interval = UpdateInterval};
            _loopTimer.Elapsed += OnTick;
        }

        private void OnTick(object sender, ElapsedEventArgs e)
        {
            var currentTicks = Stopwatch.GetTimestamp();
            float diff = currentTicks - _previousTicks;
            var timePassed = (diff / Stopwatch.Frequency) * 1000f;
            foreach (var item in _objects)
            {
                item.Update(timePassed);
            }

            _previousTicks = currentTicks;
        }
    }
}