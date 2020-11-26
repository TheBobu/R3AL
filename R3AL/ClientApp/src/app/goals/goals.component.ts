import { Component, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { ActivatedRoute } from "@angular/router";

@Component({
  selector: "app-goals",
  templateUrl: "./goals.component.html",
})
export class GoalsComponent {
  public goals: Goal[];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, route:ActivatedRoute) {
    let currentId = route.snapshot.paramMap.get("id");

    http.get<Goal[]>(baseUrl + "api/goals/users/"+currentId).subscribe(result => {
      this.goals = result;
    }, error => console.log(error));
  }
}
interface Goal {
  goalId: number;
  title: string;
  goalStatus: string;
  currentProgress: number;
  milestones: number;
  description: string;
}
