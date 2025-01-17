using System;

namespace GitVersion
{
    public class CommitFilter
    {

        public bool FirstParentOnly { get; set; }
        public object? IncludeReachableFrom { get; set; }
        public object? ExcludeReachableFrom { get; set; }
        public CommitSortStrategies SortBy { get; set; }
    }

    [Flags]
    public enum CommitSortStrategies
    {
        /// <summary>
        /// Sort the commits in no particular ordering;
        /// this sorting is arbitrary, implementation-specific
        /// and subject to change at any time.
        /// </summary>
        None = 0,

        /// <summary>
        /// Sort the commits in topological order
        /// (parents before children); this sorting mode
        /// can be combined with time sorting.
        /// </summary>
        Topological = (1 << 0),

        /// <summary>
        /// Sort the commits by commit time;
        /// this sorting mode can be combined with
        /// topological sorting.
        /// </summary>
        Time = (1 << 1),

        /// <summary>
        /// Iterate through the commits in reverse
        /// order; this sorting mode can be combined with
        /// any of the above.
        /// </summary>
        Reverse = (1 << 2)
    }
}
