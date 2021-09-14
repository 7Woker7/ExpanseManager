import { HttpClient } from '@angular/common/http';

export class ValueService{
    constructor(private http: HttpClient){  }

    GetValue(){
        return this.http.get('api/value');
    }
}