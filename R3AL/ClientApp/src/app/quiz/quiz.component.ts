import { HttpClient } from "@angular/common/http";
import { Component, Inject } from "@angular/core";
import { inject } from "@angular/core/testing";
import { getBaseUrl } from "src/main";
@Component({
  selector: "app-quiz",
  templateUrl: "./quiz.component.html",
  styleUrls: ["./quiz.component.scss"],
})
export class QuizComponent {
  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string) {}
}
