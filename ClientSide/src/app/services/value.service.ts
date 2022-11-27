import { HttpClient} from '@angular/common/http';
import { InjectableCompiler } from '@angular/compiler/src/injectable_compiler';
import { Injectable } from '@angular/core';

@Injectable({providedIn: "root"})
export class ValueService{
     constructor(private _http: HttpClient){  }

     GetValue(){
         return this._http.get('http://localhost:5000/api/value')
         .subscribe((res)=>{
            console.log(res);
         });
     }
}