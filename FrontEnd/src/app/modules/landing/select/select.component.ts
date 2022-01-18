import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-select',
  templateUrl: './select.component.html',
  styleUrls: ['./select.component.scss']
})
export class SelectComponent implements OnInit {

  constructor(private router : Router) { }

  ngOnInit(): void {
  }
  public back():void
  {
    this.router.navigate(['/']);
  }
  public clubs():void
  {
    this.router.navigate(['/clubs']);
  }
  public styles():void
  {
    this.router.navigate(['/styles']);

  }

}
