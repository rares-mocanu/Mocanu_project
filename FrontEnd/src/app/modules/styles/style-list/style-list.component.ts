import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Style } from 'src/app/interfaces/style';
import { StyleService } from 'src/app/services/style.service';

@Component({
  selector: 'app-style-list',
  templateUrl: './style-list.component.html',
  styleUrls: ['./style-list.component.scss']
})
export class StyleListComponent implements OnInit {

  constructor(private router : Router,
    private styleService:StyleService) { }
    public styles:Style[]=[];
  ngOnInit(): void {
    this.styleService.getStyles().subscribe(
      (result: Style[]) => {
        this.styles = result;
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
  public displayedColumns = ['id', 'name', 'type', 'description'];


}
