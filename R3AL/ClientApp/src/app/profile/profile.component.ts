import { HttpClient } from "@angular/common/http";
import { Component, Inject } from "@angular/core";
import { inject } from "@angular/core/testing";
import { getBaseUrl } from "src/main";
import { CommonModule } from "@angular/common";
import { ActivatedRoute, Router } from "@angular/router";

@Component({
  selector: "app-profile",
  templateUrl: "./profile.component.html",
  styleUrls: ["./profile.component.scss"],
})
export class ProfileComponent {
  public user: Profile;

  constructor(
    http: HttpClient,
    @Inject("BASE_URL") baseUrl: string,
    route: ActivatedRoute
  ) {
    let currentId = route.snapshot.paramMap.get("id");
    http
      .get<Profile>(baseUrl + "api/login/" + currentId + "/extended")
      .subscribe(
        (result) => {
          this.user = result;
        },
        (error) => console.log(error)
      );
  }
}

interface Profile {
  username: string;
  firstName: string;
  lastName: string;
  jobTitle: string;
  department: string;
  email: string;
  userId: number;
  userType: string;
  goals: Goal[];
  projects: Project[];
}

interface Goal {
  id: number;
  title: string;
  goalStatus: string;
  currentProgress: number;
  milestones: number;
}

interface Project {
  link: string;
  title: string;
}
