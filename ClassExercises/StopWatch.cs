using System;

/* 
Design a class called Stopwatch.
The job of this class is to simulate a stopwatch.
It should provide two methods:
1. Start - DONE
2. Stop. - DONE
We call the start method first, and the stop method next.
Then we ask the stopwatch about the duration between start and stop.
Duration should be a value in TimeSpan. - DONE
Display the duration on the console.
We should also be able to use a stopwatch multiple times. - CASE LOOP? IF LOOP? WHILE LOOP?
So we may start and stop it and then start and stop it again.
Make sure the duration value each time is calculated properly. 
We should not be able to start a stopwatch twice in a row (because that may overwrite the initial start time).
So the class should throw an InvalidOperationException if its started twice. 
 */

namespace ClassExercises
{
    public class Stopwatch
    {
        /*
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _running;

        //Start Timer
        public void Start()
        {
            if (_running)
                throw new InvalidOperationException("Stopwatch is ALREADY running");

            _startTime = DateTime.Now;
            _running = true;

        }

        //Stop Timer
        public void Stop()
        {
            if (!_running)
                throw new InvalidOperationException("Stopwatch is NOT running");
            _stopTime = DateTime.Now;
            _running = false;
        }

        public TimeSpan Duration()
        {
            
            return _stopTime - _startTime;
        }
        */

        private DateTime _startTime = new DateTime();
        private Double _totalSpan;
        private bool _isRunning;

        public void StartTimer()
        {
            if (!_isRunning)
            {
                _startTime = new DateTime();
                _startTime = DateTime.Now;
                _isRunning = true;
                Console.WriteLine("Timer is started. Current DateTime: " + _startTime);
            }
            else
            {
                throw new InvalidOperationException("Cannot start, as timer is still running. You may chose Stop option.");
            }

        }

        public void StopTimer()
        {
            if (_isRunning)
            {
                var timeSpan = DateTime.Now - _startTime;
                _totalSpan = timeSpan.TotalSeconds;
                Console.WriteLine("Timer is stopped. Total span = " + String.Format("{0:0.0}", _totalSpan) + " Seconds");
                _isRunning = false;
            }
            else
            {
                throw new InvalidOperationException("Timer is not running. Please choose on Start option First.");
            }
        }
    }
}