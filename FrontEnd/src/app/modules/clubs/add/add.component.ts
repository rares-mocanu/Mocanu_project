import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, AbstractControl } from '@angular/forms';
import { Router } from '@angular/router';
import { ClubService } from 'src/app/services/club.service';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.scss']
})
export class AddComponent implements OnInit {

  constructor(private router : Router,
    private clubService: ClubService) { }

  ngOnInit(): void {
  }
public clubForm : FormGroup = new FormGroup(
  {
    id:new FormControl(0),
    name: new FormControl(''),
    address:new FormControl(''),
    email:new FormControl(''),
  });

  public addClub():void{
    this.clubService.addClub(this.clubForm.value).subscribe(
      (result) => {
        console.log(result);
      },
      (error) => {
        console.error(error);
      }
    );
    this.back();
  }
  public back():void
  {
    this.router.navigate(['clubs']);
  }

}
