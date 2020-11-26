import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { inject } from "@angular/core/testing";
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { getBaseUrl } from "src/main";
@Component({
  selector: 'app-jobdescription',
  templateUrl: './jobdescription.component.html',
  styleUrls: ['./jobdescription.component.scss']
})
export class JobdescriptionComponent {

  public job : Joblist;

  constructor(http:HttpClient, @Inject('BASE_URL') baseUrl:string, private modalService: NgbModal){
    
    http.get<Joblist>(baseUrl+"api/jobs/1/extended").subscribe(result=>{
      this.job= result;
    }, error=>console.log(error));

    }
    
    open(content) {
      this.modalService.open(content, { size: 'lg' });
    }

opened: boolean = false;
showMe: boolean = false;

onClick(event) {
   if(!this.opened) {
       this.opened = true;
       setTimeout(() => {
            this.showMe = true;
       }, 5000)
   }
}
  }

  interface Joblist{
    jobId:number;
    name: string;
    description:string;
    imgPath: string;
    numberOfProjects: number;
    numberOfQuizzes: number;
    numberOfGoals: number;
    status: string;
    statusProgress: number;
    milestones: number;
    requirements: string;
    goals : Goal[];
    projects: Project[];
    quizzes: Quiz[];
  }

  interface Goal{
    title: string;
    goalStatus : string;
    goalId: number;
    milestones:number;
    currentProgress: number;
  }

  interface Project{
    title: string;
    link: string;
  }
  interface Quiz{
    title: string;
    quizId: number;
  }

