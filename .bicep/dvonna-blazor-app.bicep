param siteName string
param location string = resourceGroup().location
param environment string


resource appServicePlan 'Microsoft.Web/serverfarms@2021-02-01' = {
  name: '${siteName}-serviceplan'
  location: location
  kind: 'linux'
  sku: {
    name: 'F1'
    capacity: 1
  }
}


resource dataStaticWebApp 'Microsoft.Web/staticSites@2021-02-01' existing = {
  name: '${siteName}-data'
}


resource blazorAppService 'Microsoft.Web/sites@2021-02-01' = {
  name: siteName
  location: location
  properties: {
    serverFarmId: appServicePlan.id
    siteConfig: {
      appSettings: [
        {
          name: 'DvOnnaConfig:DataEndpoint'
          value: 'https://${dataStaticWebApp.properties.defaultHostname}'
        }
        {
          name: 'ASPNETCORE_ENVIRONMENT'
          value: environment
        }
      ]
    }
  }
  dependsOn: [
    appServicePlan
    dataStaticWebApp
  ]
}
