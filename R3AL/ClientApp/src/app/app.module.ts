import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http";
import { RouterModule } from "@angular/router";
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppComponent } from "./app.component";
import { NavMenuComponent } from "./nav-menu/nav-menu.component";
import { HomeComponent } from "./home/home.component";
import { QuizComponent } from "./quiz/quiz.component";
import { GoalsComponent } from "./goals/goals.component";
import { ProfileComponent } from "./profile/profile.component";
import { ProjectsComponent } from "./projects/projects.component";
import { RegisterComponent } from "./register/register.component";
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import { JoblistComponent } from "./joblist/joblist.component";

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    QuizComponent,
    GoalsComponent,
    ProfileComponent,
    ProjectsComponent,
    RegisterComponent,
    JoblistComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: "ng-cli-universal" }),
    HttpClientModule,
    FormsModule,
    NgbModule,
    AngularFontAwesomeModule,
    RouterModule.forRoot([
      { path: "", component: HomeComponent, pathMatch: "full" },
      { path: "quiz", component: QuizComponent },
      { path: "goals", component: GoalsComponent },
      { path: "profile", component: ProfileComponent },
      { path: "projects", component: ProjectsComponent },
      { path: "register", component: RegisterComponent },
      { path: "joblist", component: JoblistComponent },
    ]),
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
