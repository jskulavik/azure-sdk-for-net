// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    public static partial class RunbookOperationsExtensions
    {
        /// <summary>
        /// Retrieve the content of runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the runbook content operation.
        /// </returns>
        public static RunbookContentResponse Content(this IRunbookOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookOperations)s).ContentAsync(resourceGroupName, automationAccount, runbookName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the content of runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the runbook content operation.
        /// </returns>
        public static Task<RunbookContentResponse> ContentAsync(this IRunbookOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return operations.ContentAsync(resourceGroupName, automationAccount, runbookName, CancellationToken.None);
        }
        
        /// <summary>
        /// Create the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The create or update parameters for runbook.
        /// </param>
        /// <returns>
        /// The response model for the runbook create response.
        /// </returns>
        public static RunbookCreateOrUpdateResponse CreateOrUpdate(this IRunbookOperations operations, string resourceGroupName, string automationAccount, RunbookCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookOperations)s).CreateOrUpdateAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The create or update parameters for runbook.
        /// </param>
        /// <returns>
        /// The response model for the runbook create response.
        /// </returns>
        public static Task<RunbookCreateOrUpdateResponse> CreateOrUpdateAsync(this IRunbookOperations operations, string resourceGroupName, string automationAccount, RunbookCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Create the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The create or update parameters for runbook.
        /// </param>
        /// <returns>
        /// The response model for the runbook create response.
        /// </returns>
        public static RunbookCreateOrUpdateResponse CreateOrUpdateWithDraft(this IRunbookOperations operations, string resourceGroupName, string automationAccount, RunbookCreateOrUpdateDraftParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookOperations)s).CreateOrUpdateWithDraftAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The create or update parameters for runbook.
        /// </param>
        /// <returns>
        /// The response model for the runbook create response.
        /// </returns>
        public static Task<RunbookCreateOrUpdateResponse> CreateOrUpdateWithDraftAsync(this IRunbookOperations operations, string resourceGroupName, string automationAccount, RunbookCreateOrUpdateDraftParameters parameters)
        {
            return operations.CreateOrUpdateWithDraftAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete the runbook by name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IRunbookOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookOperations)s).DeleteAsync(resourceGroupName, automationAccount, runbookName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete the runbook by name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IRunbookOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return operations.DeleteAsync(resourceGroupName, automationAccount, runbookName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the get runbook operation.
        /// </returns>
        public static RunbookGetResponse Get(this IRunbookOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookOperations)s).GetAsync(resourceGroupName, automationAccount, runbookName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <returns>
        /// The response model for the get runbook operation.
        /// </returns>
        public static Task<RunbookGetResponse> GetAsync(this IRunbookOperations operations, string resourceGroupName, string automationAccount, string runbookName)
        {
            return operations.GetAsync(resourceGroupName, automationAccount, runbookName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a list of runbooks.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list runbook operation.
        /// </returns>
        public static RunbookListResponse List(this IRunbookOperations operations, string resourceGroupName, string automationAccount)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookOperations)s).ListAsync(resourceGroupName, automationAccount);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of runbooks.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list runbook operation.
        /// </returns>
        public static Task<RunbookListResponse> ListAsync(this IRunbookOperations operations, string resourceGroupName, string automationAccount)
        {
            return operations.ListAsync(resourceGroupName, automationAccount, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve next list of runbooks.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list runbook operation.
        /// </returns>
        public static RunbookListResponse ListNext(this IRunbookOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve next list of runbooks.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list runbook operation.
        /// </returns>
        public static Task<RunbookListResponse> ListNextAsync(this IRunbookOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Update the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The patch parameters for runbook.
        /// </param>
        /// <returns>
        /// The response model for the get runbook operation.
        /// </returns>
        public static RunbookGetResponse Patch(this IRunbookOperations operations, string resourceGroupName, string automationAccount, RunbookPatchParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRunbookOperations)s).PatchAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Update the runbook identified by runbook name.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IRunbookOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The patch parameters for runbook.
        /// </param>
        /// <returns>
        /// The response model for the get runbook operation.
        /// </returns>
        public static Task<RunbookGetResponse> PatchAsync(this IRunbookOperations operations, string resourceGroupName, string automationAccount, RunbookPatchParameters parameters)
        {
            return operations.PatchAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
    }
}