<#
.Synopsis
Create or update the transaction node.
.Description
Create or update the transaction node.
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/az.blockchain/new-azblockchaintransactionnode
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.ITransactionNode
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

FIREWALLRULE <IFirewallRule[]>: Gets or sets the firewall rules.
  [EndIPAddress <String>]: Gets or sets the end IP address of the firewall rule range.
  [RuleName <String>]: Gets or sets the name of the firewall rules.
  [StartIPAddress <String>]: Gets or sets the start IP address of the firewall rule range.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/new-azblockchaintransactionnode
#>
function New-AzBlockchainTransactionNode {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.ITransactionNode])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Blockchain member name.
    ${BlockchainMemberName},

    [Parameter(Mandatory)]
    [Alias('TransactionNodeName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Transaction node name.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IFirewallRule[]]
    # Gets or sets the firewall rules.
    # To construct, see NOTES section for FIREWALLRULE properties and create a hash table.
    ${FirewallRule},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Gets or sets the transaction node location.
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.Security.SecureString]
    [ValidateNotNullOrEmpty()]
    # Sets the transaction node dns endpoint basic auth password.
    ${Password},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)



process {
    try {
        if ($PSBoundParameters.ContainsKey('Password')) {
            $psTxt = [System.Runtime.InteropServices.marshal]::PtrToStringAuto([System.Runtime.InteropServices.marshal]::SecureStringToBSTR($PSBoundParameters['Password']))
            $PSBoundParameters.Remove('Password')
            $PSBoundParameters.Add('Password', $psTxt)
        }
        Az.Blockchain.internal\New-AzBlockchainTransactionNode @PSBoundParameters
    } catch {
        throw
    }
}

}
