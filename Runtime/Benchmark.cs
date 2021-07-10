﻿using System;
using System.Diagnostics;

namespace Zigurous.Debug
{
    /// <summary>
    /// Measures the execution time of functions.
    /// </summary>
    public static class Benchmark
    {
        #if UNITY_EDITOR || DEVELOPMENT_BUILD
        /// <summary>
        /// A stopwatch that measures execution time.
        /// </summary>
        private static Stopwatch stopwatch = new Stopwatch();
        #endif

        /// <summary>Measures the execution time of <paramref name="function"/> with a given amount of <paramref name="iterations"/>.</summary>
        /// <returns>The execution time of the function in milliseconds.</returns>
        /// <param name="foo">The function to be executed.</param>
        /// <param name="iterations">The amount of times the function is executed.</param>
        /// <param name="log">Logs the result to the console.</param>
        public static double Measure(Action foo, int iterations, bool log = true)
        {
            #if UNITY_EDITOR || DEVELOPMENT_BUILD
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < iterations; i++) {
                foo();
            }

            stopwatch.Stop();
            double time = stopwatch.Elapsed.TotalMilliseconds;

            if (log) {
                UnityEngine.Debug.Log($"[Benchmark]: {time.ToString()}ms | {foo.ToString()}");
            }

            return time;
            #else
            return double.NaN;
            #endif
        }

        /// <summary>Compares the execution time between <paramref name="foo"/> and <paramref name="bar"/> with a given amount of <paramref name="iterations"/>.</summary>
        /// <returns>The difference in execution time of the two functions in milliseconds.</returns>
        /// <param name="foo">The first function to be executed.</param>
        /// <param name="bar">The second function to be executed.</param>
        /// <param name="iterations">The amount of times each function is executed.</param>
        /// <param name="log">Logs the result to the console.</param>
        public static double Compare(Action foo, Action bar, int iterations, bool log = true)
        {
            #if UNITY_EDITOR || DEVELOPMENT_BUILD
            double timeFoo = Measure(foo, iterations, false);
            double timeBar = Measure(bar, iterations, false);
            double difference = timeFoo - timeBar;

            if (log) {
                UnityEngine.Debug.Log($"[Benchmark]: {timeFoo.ToString()}ms vs {timeBar.ToString()}ms | {difference.ToString()}ms");
            }

            return difference;
            #else
            return double.NaN;
            #endif
        }

        /// <summary>Performs a benchmark that runs each function a given amount of <paramref name="iterations"/>.</summary>
        /// <param name="iterations">The amount of times each function is executed.</param>
        /// <param name="foobar">The functions to be executed.</param>
        public static void Run(int iterations, params Action[] foobar)
        {
            for (int i = 0; i < foobar.Length; i++) {
                Measure(foobar[i], iterations);
            }
        }

    }

}
