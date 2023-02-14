import { Component,OnInit } from '@angular/core';
import { Student } from '../../Module/student';
import { StudentService } from '../../Services/student.service';

@Component({
  selector: 'app-matser',
  templateUrl: './matser.component.html',
  styleUrls: ['./matser.component.css']
})
export class MatserComponent implements OnInit 
{
  students:Student[]=[];
  constructor(private service:StudentService)
  {

  }
  ngOnInit():void{
    this.service.getAllStudents().subscribe((data:Student[])=>{
      //console.log(data)
      this.students=data; 
    })
    
  }
}
