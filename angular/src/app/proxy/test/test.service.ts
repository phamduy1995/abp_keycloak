import { RestService, Rest } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class TestService {
  apiName = 'Default';
  

  getName = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, string>({
      method: 'GET',
      responseType: 'text',
      url: '/api/app/test/name',
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
