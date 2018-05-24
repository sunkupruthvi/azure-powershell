// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Version2016_09_01
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProviderOperations.
    /// </summary>
    public static partial class ProviderOperationsExtensions
    {
            /// <summary>
            /// Get available application frameworks and their versions
            /// </summary>
            /// <remarks>
            /// Get available application frameworks and their versions
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='osTypeSelected'>
            /// Possible values include: 'Windows', 'Linux'
            /// </param>
            public static IPage<ApplicationStack> GetAvailableStacks(this IProviderOperations operations, string osTypeSelected = default(string))
            {
                return operations.GetAvailableStacksAsync(osTypeSelected).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get available application frameworks and their versions
            /// </summary>
            /// <remarks>
            /// Get available application frameworks and their versions
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='osTypeSelected'>
            /// Possible values include: 'Windows', 'Linux'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApplicationStack>> GetAvailableStacksAsync(this IProviderOperations operations, string osTypeSelected = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAvailableStacksWithHttpMessagesAsync(osTypeSelected, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all available operations for the Microsoft.Web resource provider. Also
            /// exposes resource metric definitions
            /// </summary>
            /// <remarks>
            /// Gets all available operations for the Microsoft.Web resource provider. Also
            /// exposes resource metric definitions
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<CsmOperationDescription> ListOperations(this IProviderOperations operations)
            {
                return operations.ListOperationsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all available operations for the Microsoft.Web resource provider. Also
            /// exposes resource metric definitions
            /// </summary>
            /// <remarks>
            /// Gets all available operations for the Microsoft.Web resource provider. Also
            /// exposes resource metric definitions
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CsmOperationDescription>> ListOperationsAsync(this IProviderOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListOperationsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get available application frameworks and their versions
            /// </summary>
            /// <remarks>
            /// Get available application frameworks and their versions
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='osTypeSelected'>
            /// Possible values include: 'Windows', 'Linux'
            /// </param>
            public static IPage<ApplicationStack> GetAvailableStacksOnPrem(this IProviderOperations operations, string osTypeSelected = default(string))
            {
                return operations.GetAvailableStacksOnPremAsync(osTypeSelected).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get available application frameworks and their versions
            /// </summary>
            /// <remarks>
            /// Get available application frameworks and their versions
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='osTypeSelected'>
            /// Possible values include: 'Windows', 'Linux'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApplicationStack>> GetAvailableStacksOnPremAsync(this IProviderOperations operations, string osTypeSelected = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAvailableStacksOnPremWithHttpMessagesAsync(osTypeSelected, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get available application frameworks and their versions
            /// </summary>
            /// <remarks>
            /// Get available application frameworks and their versions
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ApplicationStack> GetAvailableStacksNext(this IProviderOperations operations, string nextPageLink)
            {
                return operations.GetAvailableStacksNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get available application frameworks and their versions
            /// </summary>
            /// <remarks>
            /// Get available application frameworks and their versions
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApplicationStack>> GetAvailableStacksNextAsync(this IProviderOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAvailableStacksNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all available operations for the Microsoft.Web resource provider. Also
            /// exposes resource metric definitions
            /// </summary>
            /// <remarks>
            /// Gets all available operations for the Microsoft.Web resource provider. Also
            /// exposes resource metric definitions
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<CsmOperationDescription> ListOperationsNext(this IProviderOperations operations, string nextPageLink)
            {
                return operations.ListOperationsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all available operations for the Microsoft.Web resource provider. Also
            /// exposes resource metric definitions
            /// </summary>
            /// <remarks>
            /// Gets all available operations for the Microsoft.Web resource provider. Also
            /// exposes resource metric definitions
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CsmOperationDescription>> ListOperationsNextAsync(this IProviderOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListOperationsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get available application frameworks and their versions
            /// </summary>
            /// <remarks>
            /// Get available application frameworks and their versions
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ApplicationStack> GetAvailableStacksOnPremNext(this IProviderOperations operations, string nextPageLink)
            {
                return operations.GetAvailableStacksOnPremNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get available application frameworks and their versions
            /// </summary>
            /// <remarks>
            /// Get available application frameworks and their versions
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApplicationStack>> GetAvailableStacksOnPremNextAsync(this IProviderOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAvailableStacksOnPremNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
