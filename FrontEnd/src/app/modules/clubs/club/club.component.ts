import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { Trainer } from 'src/app/interfaces/trainer';
import { ClubService } from 'src/app/services/club.service';
import { TrainerService } from 'src/app/services/trainer-service.service';
import { FormControl, FormGroup, AbstractControl} from '@angular/forms';
import { AddTrainer } from 'src/app/interfaces/addTrainer';
@Component({
  selector: 'app-club',
  templateUrl: './club.component.html',
  styleUrls: ['./club.component.scss']
})

export class ClubComponent implements OnInit {

  public subscription: Subscription= new Subscription;
  public id: number=0;
  public trainers: Trainer[]=[];

  constructor(private route : ActivatedRoute,private router:Router,
    private clubService: ClubService,
    private trainerService: TrainerService
    ) { }

  ngOnInit(): void {
    this.subscription = this.route.params.subscribe(params => {
      this.id = +params['id'];
    });
    
    this.clubService.getClubTrainers(this.id).subscribe(
      (result: Trainer[]) => {
        this.trainers = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }

  public back():void
  {
    this.router.navigate(['clubs']);
  }
  public displayedColumns = ['id', 'name', 'style'];

  public trainerForm : FormGroup = new FormGroup(
    {
      id :new FormControl(0),
      name: new FormControl(''),
      styleId:new FormControl(1),
      clubId:new FormControl(this.id)
    });
    
    
  public addTrainer():void{
    this.trainerForm.value.clubId=this.id;
    this.trainerService.addTrainer(this.trainerForm.value).subscribe(
      (result) => {
        console.log(result);
      },
      (error) => {
        console.error(error);
      }
    );
  }

}
