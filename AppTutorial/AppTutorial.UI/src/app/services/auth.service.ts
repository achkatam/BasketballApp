import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environments/environment.prod';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  constructor(private http: HttpClient) {}

  loginPath = environment.apiUrl + 'identity/login';
  registerPath = environment.apiUrl + 'identity/register';

  login(data: any): Observable<any> {
    return this.http.post(this.loginPath, data);
  }

  register(data: any): Observable<any> {
    return this.http.post(this.registerPath, data);
  }

  getToken(){
    return localStorage.getItem('token');
  }

  saveToken(token:string){
    localStorage.setItem('token',token);
  }
}