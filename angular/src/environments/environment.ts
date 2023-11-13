import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'KeyCloakIntegrate',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44376/',
    redirectUri: baseUrl,
    clientId: 'KeyCloakIntegrate_App',
    responseType: 'code',
    scope: 'offline_access KeyCloakIntegrate',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44376',
      rootNamespace: 'KeyCloakIntegrate',
    },
  },
} as Environment;
