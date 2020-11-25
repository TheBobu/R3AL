import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { inject } from "@angular/core/testing";
import { getBaseUrl } from "src/main";
@Component({
  selector: 'app-joblist',
  templateUrl: './joblist.component.html',
  styleUrls: ['./joblist.component.scss']
})
export class JoblistComponent {
  // public job : Joblist;

// constructor(http:HttpClient, @Inject('BASE_URL') baseUrl:string){
  
  // http.get<Joblist>(baseUrl+"api/jobs/1/list").subscribe(result=>{
  //   this.job= result;
  // }, error=>console.log(error));
  // }
}
// interface Joblist{
//   name: string;
//   numberOfProjects: number;
//   numberOfQuizes: number;
//   numberOfGoals: number;
//   status: string;
//   statusProgress: number;
//   milestones: number;
// }

