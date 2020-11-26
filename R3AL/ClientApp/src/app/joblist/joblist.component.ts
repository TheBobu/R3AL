import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { inject } from "@angular/core/testing";
import { getBaseUrl } from "src/main";
import { Router } from '@angular/router';
@Component({
  selector: 'app-joblist',
  templateUrl: './joblist.component.html',
  styleUrls: ['./joblist.component.scss']
})
export class JoblistComponent {
  public job : Joblist[];
  public router: Router;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, router: Router){
    this.router = router;
  http.get<Joblist[]>(baseUrl+"api/jobs/1/list").subscribe(result=>{
    this.job= result;
  }, error=>console.log(error));
  }

  goToJob(id: number) {
    this.router.navigate(["/jobdescription", { id: id}]);
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
}

