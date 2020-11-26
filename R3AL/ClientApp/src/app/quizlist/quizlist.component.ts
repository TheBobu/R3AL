import { HttpClient } from "@angular/common/http";
import { Component, Inject } from "@angular/core";
import { inject } from "@angular/core/testing";
import { getBaseUrl } from "src/main";
@Component({
  selector: "app-quizlist",
  templateUrl: "./quizlist.component.html",
  styleUrls: ["./quizlist.component.scss"],
})
export class QuizlistComponent {
  public quiz: QuizList[];

  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
    http.get<QuizList[]>(baseUrl + "api/jobs/1/list").subscribe(
      (result) => {
        this.quiz = result;
      },
      (error) => console.log(error)
    );
  }
}
interface QuizList {
  quizId: number;
  name: string;
  numberOfQuestions: number;
  goalId: number;
}
