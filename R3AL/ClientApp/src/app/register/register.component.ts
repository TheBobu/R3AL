import { Component, Inject } from "@angular/core";
import { Router } from "@angular/router";
import { HttpClient } from "@angular/common/http";

@Component({
  selector: "app-register",
  templateUrl: "./register.component.html",
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent {
  public url: string;
  public http: HttpClient;
  public user: Profile;

  constructor(
    http: HttpClient,
    @Inject("BASE_URL") baseUrl: string,
    private router: Router
  ) {
    this.user = {} as Profile;
    this.url = baseUrl;
    this.http = http;
  }
  onClick() {
    this.user.userType = 1;
    this.http
      .post<Profile>(this.url + "api/login/register", this.user)
      .subscribe((x) => {
          this.user = x;
          this.router.navigate(["/"]);
      });
  }
}


interface Profile {
  username: string;
  firstName: string;
  lastName: string;
  jobTitle: string;
  department: string;
  password: string;
  email: string;
  userId: number;
  userType: number;
}
