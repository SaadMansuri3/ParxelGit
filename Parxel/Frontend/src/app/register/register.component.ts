import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(private http:HttpClient) { }

  GetAllUsers():Observable<string[]>{
    return this.http.get<any>('https://localhost:44349/api/Account')
  }


  ngOnInit(): void {
    this.GetAllUsers().subscribe(userList =>{
      console.log(userList);
    })
  }

}
