import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'StoreManagement',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:5001',
    redirectUri: baseUrl,
    clientId: 'StoreManagement_App',
    responseType: 'code',
    scope: 'offline_access StoreManagement',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:5001',
      rootNamespace: 'Dsi.StoreManagement',
    },
  },
} as Environment;
