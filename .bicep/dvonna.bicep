param siteName string
param location string

targetScope = 'subscription'

resource dvonnaResourceGroup 'Microsoft.Resources/resourceGroups@2021-04-01' = {
  name: siteName
  location: location
}
