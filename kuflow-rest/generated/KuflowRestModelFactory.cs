// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Kuflow.Rest.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class KuflowRestModelFactory
    {
        /// <summary> Initializes a new instance of Authentication. </summary>
        /// <param name="createdBy"> Who create this model. </param>
        /// <param name="createdAt"> When this model was created. </param>
        /// <param name="lastModifiedBy"> Who was last update this model. </param>
        /// <param name="lastModifiedAt"> When this model type was last updated. </param>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="token"></param>
        /// <param name="expiredAt"></param>
        /// <returns> A new <see cref="Models.Authentication"/> instance for mocking. </returns>
        public static Authentication Authentication(Guid? createdBy = null, DateTimeOffset? createdAt = null, Guid? lastModifiedBy = null, DateTimeOffset? lastModifiedAt = null, Guid? id = null, string type = null, string token = null, DateTimeOffset? expiredAt = null)
        {
            return new Authentication(AuditedObjectType.Authentication, createdBy, createdAt, lastModifiedBy, lastModifiedAt, id, type, token, expiredAt);
        }

        /// <summary> Initializes a new instance of PrincipalPage. </summary>
        /// <param name="metadata"></param>
        /// <param name="content"></param>
        /// <returns> A new <see cref="Models.PrincipalPage"/> instance for mocking. </returns>
        public static PrincipalPage PrincipalPage(PageMetadata metadata = null, IEnumerable<Principal> content = null)
        {
            content ??= new List<Principal>();

            return new PrincipalPage(PagedObjectType.PrincipalPage, metadata, content?.ToList());
        }

        /// <summary> Initializes a new instance of Page. </summary>
        /// <param name="metadata"></param>
        /// <returns> A new <see cref="Models.Page"/> instance for mocking. </returns>
        public static Page Page(PageMetadata metadata = null)
        {
            return new UnknownPage(default, metadata);
        }

        /// <summary> Initializes a new instance of PageMetadata. </summary>
        /// <param name="size"></param>
        /// <param name="page"></param>
        /// <param name="totalElements"></param>
        /// <param name="totalPages"></param>
        /// <returns> A new <see cref="Models.PageMetadata"/> instance for mocking. </returns>
        public static PageMetadata PageMetadata(int size = default, int page = default, long totalElements = default, int totalPages = default)
        {
            return new PageMetadata(size, page, totalElements, totalPages);
        }

        /// <summary> Initializes a new instance of ProcessPage. </summary>
        /// <param name="metadata"></param>
        /// <param name="content"></param>
        /// <returns> A new <see cref="Models.ProcessPage"/> instance for mocking. </returns>
        public static ProcessPage ProcessPage(PageMetadata metadata = null, IEnumerable<ProcessPageItem> content = null)
        {
            content ??= new List<ProcessPageItem>();

            return new ProcessPage(PagedObjectType.ProcessPage, metadata, content?.ToList());
        }

        /// <summary> Initializes a new instance of TaskPage. </summary>
        /// <param name="metadata"></param>
        /// <param name="content"></param>
        /// <returns> A new <see cref="Models.TaskPage"/> instance for mocking. </returns>
        public static TaskPage TaskPage(PageMetadata metadata = null, IEnumerable<TaskPageItem> content = null)
        {
            content ??= new List<TaskPageItem>();

            return new TaskPage(PagedObjectType.TaskPage, metadata, content?.ToList());
        }
    }
}
