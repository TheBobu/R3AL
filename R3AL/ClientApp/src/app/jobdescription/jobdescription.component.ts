import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { inject } from "@angular/core/testing";
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { getBaseUrl } from "src/main";
import { ActivatedRoute } from '@angular/router';
@Component({
  selector: 'app-jobdescription',
  templateUrl: './jobdescription.component.html',
  styleUrls: ['./jobdescription.component.scss']
})
export class JobdescriptionComponent {

  public job = {} as Joblist;

    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, route: ActivatedRoute, private modalService: NgbModal){
    let currentId = route.snapshot.paramMap.get("id");
    http.get<Joblist>(baseUrl+"api/jobs/"+currentId+"/extended").subscribe(result=>{
      this.job= result;
    }, error=>console.log(error));

    }
    
    open(content) {
      this.modalService.open(content, { size: 'lg' });
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
    projects: Project[];
    goals : Goal[];
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

