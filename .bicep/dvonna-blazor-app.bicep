param siteName string
param location string = resourceGroup().location


resource appServicePlan 'Microsoft.Web/serverfarms@2021-02-01' = {
  name: '${siteName}-serviceplan'
  location: location
  properties: {
    reserved: true
  }
  sku: {
    name: 'F1'
  }
}


resource dataStaticWebApp 'Microsoft.Web/staticSites@2021-02-01' existing = {
  name: '${siteName}-data'
}

var staticDataSiteUrl = 'https://${dataStaticWebApp.properties.defaultHostname}'


resource blazorAppService 'Microsoft.Web/sites@2021-02-01' = {
  name: siteName
  location: location
  properties: {
    serverFarmId: appServicePlan.id
  }
  dependsOn: [
    appServicePlan
    dataStaticWebApp
  ]
}


output dataEndpoint string = staticDataSiteUrl
