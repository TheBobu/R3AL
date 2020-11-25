import { Component, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { ActivatedRoute, Router } from "@angular/router";

@Component({
  selector: "app-home",
  templateUrl: "./home.component.html",
  styleUrls: ["./home.component.css"],
})
export class HomeComponent {
  public username: string;
  public password: string;
  public url: string;
  public http: HttpClient;
  public message: string;
  public result: Response;
  constructor(
    http: HttpClient,
    @Inject("BASE_URL") baseUrl: string,
    private router: Router
  ) {
    this.url = baseUrl;
    this.http = http;
  }

  onClick() {
    this.http
      .post<Response>(this.url + "api/login/authenticate", {
        username: this.username,
        password: this.password,
      })
      .subscribe((x) => {
        this.result = x;
        if (this.result.loginResult == 2) {
          this.message = "Success";
          this.router.navigate(["/profile", { id: this.result.user.userId }]);
        } else {
          this.message = "Login Failed!";
        }
        console.log(this.result);
      });
  }
}

interface Response {
  loginResult: number;
  user: Profile;
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
}
