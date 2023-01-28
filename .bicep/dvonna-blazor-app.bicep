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


resource blazorAppService 'Microsoft.Web/sites@2021-02-01' = {
  name: siteName
  location: location
  properties: {
    serverFarmId: appServicePlan.id
    siteConfig: {
      appSettings: [
        // {
        //   name: 'DvOnnaConfig:DataEndpoint'
        //   value: 'https://${dataStaticWebApp.properties.defaultHostname}'
        // }
        {
          name: 'ASPNETCORE_ENVIRONMENT'
          value: environment
        }
      ]
    }
  }
}


resource dataStaticWebApp 'Microsoft.Web/staticSites@2021-02-01' existing = {
  name: '${siteName}-data'
}

output dvOnnaDataEndpoint string = 'https://${dataStaticWebApp.properties.defaultHostname}'
