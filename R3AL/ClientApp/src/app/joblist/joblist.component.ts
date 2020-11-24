import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { inject } from "@angular/core/testing";
import { getBaseUrl } from "src/main";
@Component({
  selector: 'app-joblist',
  templateUrl: './joblist.component.html',
  styleUrls: ['./joblist.component.css']
})
export class JoblistComponent {
  public job : Joblist;

constructor(http:HttpClient, @Inject('BASE_URL') baseUrl:string){
  
  http.get<Joblist>(baseUrl+"api/").subscribe(result=>{
    this.job= result;
  }, error=>console.log(error));
  }
}
interface Joblist{
  name: string;
  numberOfProjects: number;
  numberOfQuizes: number;
  numberOfDocs: number;
  status: string;
  statusProgress: number;
  milestones: number;
}

