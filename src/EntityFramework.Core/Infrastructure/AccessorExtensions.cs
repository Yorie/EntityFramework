// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using JetBrains.Annotations;
using Microsoft.Data.Entity.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Data.Entity.Infrastructure
{
    /// <summary>
    ///     <para>
    ///         Extension methods for <see cref="IAccessor{TService}"/>. 
    ///     </para>
    ///     <para>
    ///         These methods are typically used by database providers (and other extensions). They are generally
    ///         not used in application code.
    ///     </para>
    ///     <para>
    ///         <see cref="IAccessor{TService}"/> is used to hide properties that are not intended to be used in 
    ///         application code but can be used in extension methods written by database providers etc.
    ///     </para>
    /// </summary>
    public static class AccessorExtensions
    {
        /// <summary>
        ///     <para>
        ///         Resolves a service from the <see cref="IServiceProvider"/> exposed from a type that implements 
        ///         <see cref="IAccessor{IServiceProvider}"/>. 
        ///     </para>
        ///     <para>
        ///         This method is typically used by database providers (and other extensions). It is generally
        ///         not used in application code.
        ///     </para>
        ///     <para>
        ///         <see cref="IAccessor{TService}"/> is used to hide properties that are not intended to be used in 
        ///         application code but can be used in extension methods written by database providers etc.
        ///     </para>
        /// </summary>
        /// <typeparam name="TService"> The type of service to be resolved. </typeparam>
        /// <param name="accessor"> The object exposing the service provider. </param>
        /// <returns> The requested service. </returns>
        public static TService GetService<TService>([NotNull] this IAccessor<IServiceProvider> accessor)
            => Check.NotNull(accessor, nameof(accessor)).Service.GetRequiredService<TService>();

        /// <summary>
        ///     <para>
        ///         Gets the value from a property that is being hidden using <see cref="IAccessor{TService}"/>.
        ///     </para>
        ///     <para>
        ///         This method is typically used by database providers (and other extensions). It is generally
        ///         not used in application code.
        ///     </para>
        ///     <para>
        ///         <see cref="IAccessor{TService}"/> is used to hide properties that are not intended to be used in 
        ///         application code but can be used in extension methods written by database providers etc.
        ///     </para>
        /// </summary>
        /// <typeparam name="TService"> The type of the property being hidden by <see cref="IAccessor{TService}"/>. </typeparam>
        /// <param name="accessor"> The object that exposes the property. </param>
        /// <returns> The object assigned to the property. </returns>
        public static TService GetService<TService>([NotNull] this IAccessor<TService> accessor)
            => Check.NotNull(accessor, nameof(accessor)).Service;
    }
}
