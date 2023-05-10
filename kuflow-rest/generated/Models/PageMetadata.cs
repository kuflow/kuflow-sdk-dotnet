// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Kuflow.Rest.Models
{
    /// <summary> The PageMetadata. </summary>
    public partial class PageMetadata
    {
        /// <summary> Initializes a new instance of PageMetadata. </summary>
        /// <param name="size"></param>
        /// <param name="page"></param>
        /// <param name="totalElements"></param>
        /// <param name="totalPages"></param>
        internal PageMetadata(int size, int page, long totalElements, int totalPages)
        {
            Size = size;
            Page = page;
            TotalElements = totalElements;
            TotalPages = totalPages;
        }

        /// <summary> Gets the size. </summary>
        public int Size { get; }
        /// <summary> Gets the page. </summary>
        public int Page { get; }
        /// <summary> Gets the total elements. </summary>
        public long TotalElements { get; }
        /// <summary> Gets the total pages. </summary>
        public int TotalPages { get; }
    }
}
