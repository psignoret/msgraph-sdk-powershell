---
external help file:
Module Name: Microsoft.Graph.Identity.DirectorySettings
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorysettings/update-mggroupsetting
schema: 2.0.0
---

# Update-MgGroupSetting

## SYNOPSIS
Update the navigation property settings in groups

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgGroupSetting -DirectorySettingId <String> -GroupId <String> [-DisplayName <String>] [-Id <String>]
 [-TemplateId <String>] [-Values <IMicrosoftGraphSettingValue[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgGroupSetting -DirectorySettingId <String> -GroupId <String>
 -BodyParameter <IMicrosoftGraphDirectorySetting> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgGroupSetting -InputObject <IIdentityDirectorySettingsIdentity>
 -BodyParameter <IMicrosoftGraphDirectorySetting> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgGroupSetting -InputObject <IIdentityDirectorySettingsIdentity> [-DisplayName <String>] [-Id <String>]
 [-TemplateId <String>] [-Values <IMicrosoftGraphSettingValue[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property settings in groups

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -BodyParameter
directorySetting
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectorySetting
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -DirectorySettingId
key: directorySetting-id of directorySetting

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DisplayName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -GroupId
key: group-id of group

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityDirectorySettingsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TemplateId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Values
.
To construct, see NOTES section for VALUES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSettingValue[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IIdentityDirectorySettingsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectorySetting

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphDirectorySetting>: directorySetting
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 
  - `[TemplateId <String>]`: 
  - `[Values <IMicrosoftGraphSettingValue[]>]`: 
    - `[Name <String>]`: Name of the setting (as defined by the groupSettingTemplate).
    - `[Value <String>]`: Value of the setting.

#### INPUTOBJECT <IIdentityDirectorySettingsIdentity>: Identity Parameter
  - `[DirectorySettingId <String>]`: key: directorySetting-id of directorySetting
  - `[GroupId <String>]`: key: group-id of group

#### VALUES <IMicrosoftGraphSettingValue[]>: .
  - `[Name <String>]`: Name of the setting (as defined by the groupSettingTemplate).
  - `[Value <String>]`: Value of the setting.

## RELATED LINKS

