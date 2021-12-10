param siteName string
param location string
param environment string = ''

targetScope = 'subscription'

resource dvonnaResourceGroup 'Microsoft.Resources/resourceGroups@2021-04-01' = {
  name: siteName
  location: location
}

module blazorAppModule 'dvonna-blazor-app.bicep' = {
  name: 'blazor-app'
  scope: resourceGroup(dvonnaResourceGroup.name)
  params: {
    siteName: siteName
    environment: environment
  }
  dependsOn: [
    dvonnaResourceGroup
  ]
}
