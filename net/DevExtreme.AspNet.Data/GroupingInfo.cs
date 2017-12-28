﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtreme.AspNet.Data {

    /// <summary>
    /// Represents a grouping level to be applied to data.
    /// </summary>
    public class GroupingInfo : SortingInfo {
        /// <summary>
        /// A value that groups data in ranges of a given length or date/time period.
        /// </summary>
        public string GroupInterval;

        /// <summary>
        /// A flag indicating whether the group's data objects should be returned instead of grouping data.
        /// </summary>
        public bool? IsExpanded;

        /// <summary>
        /// Gets the value of the IsExpanded field.
        /// </summary>
        /// <returns>The value of the IsExpanded field.</returns>
        public bool GetIsExpanded() {
            if(!IsExpanded.HasValue)
                return true;

            return IsExpanded.Value;
        }
    }

}
