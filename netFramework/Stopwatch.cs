using System;

namespace netFramework
{
    public class Stopwatch
    {
        private bool _isRunning;

        public DateTime Start { get; private set; }

        public DateTime StartStopwatch()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("Stopwatch already running.");
            }

            Start = DateTime.Now;
            _isRunning = true;
            return Start;
        }

        public TimeSpan Stop()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException("Stopwatch isn't running.");
            }

            var timeDifference = DateTime.Now - Start;
            _isRunning = false;
            return timeDifference;
        }
    }
}
