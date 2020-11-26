import { Component } from "@angular/core";

@Component({
  selector: "app-goals",
  templateUrl: "./goals.component.html",
})
export class GoalsComponent {

  public pdfSrc: string;
onFileSelected() {
  let $img: any = document.querySelector('#file');

  if (typeof (FileReader) !== 'undefined') {
    let reader = new FileReader();

    reader.onload = (e: any) => {
      this.pdfSrc = e.target.result;
    }; 

    reader.readAsArrayBuffer($img.files[0]);
  }
}
}
