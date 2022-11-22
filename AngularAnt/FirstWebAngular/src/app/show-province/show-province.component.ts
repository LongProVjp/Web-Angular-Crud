import { Component, Directive, OnInit } from '@angular/core';
import{ApiserviceService}from 'src/app/apiservice.service';
@Component({
  selector: 'app-show-province',
  templateUrl: './show-province.component.html',
  styleUrls: ['./show-province.component.css']
})
export class ShowProvinceComponent implements OnInit {

  constructor(private service: ApiserviceService) { }
  ModalTitle = "";
  ActivateAddEditProComp: boolean = false;
  provin: any;
  ProvinceList: any=[];
  ProvinceNameFilter = "";
  ngOnInit(): void {
    this.refreshList();
}
closeClick() {
  this.ActivateAddEditProComp = false;
  this.refreshList();
}

addClick() {
  this.provin = {
    id: "0",
    province: "",
    district:"",
  }
  this.ModalTitle = "Add Province";
  this.ActivateAddEditProComp = true;
}

editClick(item: any) {
  this.provin = item;
  this.ModalTitle = "Edit Province";
  this.ActivateAddEditProComp = true;
}

deleteClick(item: any) {
  if (confirm('Are you sure??')) {
    this.service.deleteProvince(item.id).subscribe(data => {
      alert(data.toString());
    this.refreshList();
    })
  }
}

refreshList() {
  this.service.getProvinceList().subscribe(data => {
    this.ProvinceList = data;
  });
}
}
