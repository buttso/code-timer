

using System.Collections.Generic;

namespace CodeTimer.Abstractions 
{

    public interface ICodeTimer 
    {
        string Name {get;set;}

        /// <summary>
        /// Defines the expected performance boundary for the timer.
        /// </summary>
        long ExpectedMilliseconds {get; set;}

        /// <summary>
        /// Toggles between Verbose and Non-Verbose output formatting
        /// </summary>
        bool Verbose { get; set; }

        /// <summary>
        /// Stops the underlying timer and finishes the timing operation
        /// </summary>
        void Complete();

        /// <summary>
        /// Marks a segment and records the elapsed time 
        /// </summary>
        void Mark();

        /// <summary>
        /// Marks a segment and records the elapsed time with a descriptive name
        /// </summary>
        /// <param name="markerName">A descriptive name for the <see cref="Marker" />></param>
        void Mark(string markerName);

        /// <summary>
        /// Gets the elapsed milliseconds for the current timer
        /// </summary>
        /// <returns>The elapsed milliseconds</returns>
        long GetElapsedMilliseconds();

        /// <summary>
        /// Gets a formatted string which represents the result of all segments for the current timer 
        /// </summary>
        /// <returns>A string which displays a summary of all segments</returns>
        string GetFormattedResult();

        /// <summary>
        /// Gets all <see cref="Marker" /> items for the current timer
        /// </summary>
        /// <returns>All <see cref="Marker" /> items for timer</returns>
        IList<Marker> GetMarkers();

        /// <summary>
        /// Provides the result of the timer based on the ElapsedMilliseconds and the ExpectedMilliseconds
        /// </summary>
        /// <returns>true is the elapsed milliseconds is less than the <see cref="ExpectedMilliseconds" /> </returns>
        bool Success();
    }
}
