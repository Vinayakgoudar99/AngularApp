import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Student } from '../Module/student';
import{Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  url:string="http://localhost:51203/api/Students"
  constructor(private proxy:HttpClient) { }

  public getAllStudents():Observable<Student[]>
  {
   
   return this.proxy.get<Student[]>(this.url);
  }
}
