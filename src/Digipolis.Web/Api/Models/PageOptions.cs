﻿using System.ComponentModel;

namespace Digipolis.Web.Api
{
    /// <summary>
    /// Options for paging Api results
    /// </summary>
    public class PageOptions
    {
        /// <summary>
        /// Retrieve page
        /// </summary>
        [DefaultValue(1)]
        public int Page { get; set; } = 1;

        /// <summary>
        /// Size of the page
        /// </summary>
        [DefaultValue(10)]
        public int PageSize { get; set; } = 10;
    }
}
