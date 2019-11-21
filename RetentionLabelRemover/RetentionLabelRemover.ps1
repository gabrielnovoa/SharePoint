Add-Type -Path "C:\Program Files\Common Files\Microsoft Shared\Web Server Extensions\16\ISAPI\Microsoft.SharePoint.Client.dll"
Add-Type -Path "C:\Program Files\Common Files\Microsoft Shared\Web Server Extensions\16\ISAPI\Microsoft.SharePoint.Client.Runtime.dll"

$UserName = Read-Host -Prompt 'Input your Username'
$Password = Read-Host 'Input your password?' -AsSecureString
$webURL = Read-Host 'Input your site collection URL'
$listName = Read-Host 'Input your List Name'

$credentials= New-Object Microsoft.SharePoint.Client.SharePointOnlineCredentials($UserName,$Password)

$ctx= New-Object Microsoft.SharePoint.Client.ClientContext($webURL)
$ctx.Credentials = $credentials
try{
	$lists = $ctx.web.Lists
	$list = $lists.GetByTitle($listName)
	$listItems = $list.GetItems([Microsoft.SharePoint.Client.CamlQuery]::CreateAllItemsQuery())
	$ctx.load($listItems)

	$ctx.executeQuery()
	foreach($listItem in $listItems)
	{
		$listItem.SetComplianceTag("", $false, $false, $false, $false);
        $listItem.Update();
	}
    $ctx.executeQuery()
    Write-Host ""
    Write-Host "Total of" $listItems.Count "items were cleared on list" $listName
}
catch{
	write-host "$($_.Exception.Message)" -foregroundcolor red
}