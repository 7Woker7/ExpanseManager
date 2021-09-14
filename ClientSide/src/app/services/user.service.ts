import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IUser } from '../models/IUser';

@Injectable({
  providedIn: 'root'
})

export class UserService{

  constructor(private _http: HttpClient) {  }

  getCurrentUser(){
    return this._http.get<IUser>('/api/current-user')
  }

  getAllUsers(){
    return this._http.get<IUser>('/api/user');
  }

  getUser(id: number){
    return this._http.get<IUser>('/api/user/' + id);
  }

  postUser(user: IUser){
    return this._http.post<IUser>('/api/user', user);
  }

  putUser(user: IUser){
    return this._http.put<IUser>('/api/user/' + user.id, user);
  }

  deleteUser(id: number){
    return this._http.delete<IUser>('/api/user/' + id);
  }

}