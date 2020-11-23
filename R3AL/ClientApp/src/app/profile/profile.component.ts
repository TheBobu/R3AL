import { HttpClient } from "@angular/common/http";
import { Component, Inject } from "@angular/core";
import { inject } from "@angular/core/testing";
import { getBaseUrl } from "src/main";

@Component({
  selector: "app-profile",
  templateUrl: "./profile.component.html",
  styleUrls: ['./profile.component.scss'],
})
export class ProfileComponent {
   public user: Profile;
  

   constructor(http:HttpClient, @Inject('BASE_URL') baseUrl:string){
  //   http.get<Profile[]>
  this.user={
  username:"andreeapurta",
  firstName:"Andreea",
  lastName:"Purta", 
  jobTitle:"Student" , 
  department:"Marketing",
  email:"andreea@gmail.com", 
  id: 1,
  userType:"client", 
  goals:[{id:1,title:"C#Developer", goalStatus:"inProgress", currentProgress:5, milestone:10 }], 
  projects:[{link:"#", title:"TestProject"}]};
  }
}

interface Profile{
  username:string;
   firstName: string;
   lastName: string;
   jobTitle: string;
   department:string;
   email:string;
   id: number;
   userType: string;
   goals: Goal[];
   projects: Project[];
}

interface Goal{
  id: number;
  title: string;
  goalStatus: string;
  currentProgress: number;
  milestone: number;
}

interface Project{
  link: string;
  title: string;
}