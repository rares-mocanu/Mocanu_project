import { Component, OnDestroy, OnInit } from '@angular/core';
import {Router} from '@angular/router';
import { Club } from 'src/app/interfaces/club';
import { ClubService } from 'src/app/services/club.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {

  constructor(private router : Router,
    private clubService: ClubService) { }

  ngOnInit(): void {
    this.clubService.getClubs().subscribe(
      (result: Club[]) => {
        this.clubs = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }
  public back():void
  {
    this.router.navigate(['landing']);
  }
  public clubs : Club[]= [];
  public displayedColumns = ['id', 'name', 'address', 'email','details'];
public add():void
{
  this.router.navigate(['clubs/add']);
}
public displayClub(id:any):void
{
  this.router.navigate(['clubs/club/',id]);
}
}
