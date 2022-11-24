import { Component, OnInit } from '@angular/core';
import { ApiserviceService } from 'src/app/apiservice.service';


@Component({
  selector: 'app-show-district',
  templateUrl: './show-district.component.html',
  styleUrls: ['./show-district.component.css']
})
export class ShowDistrictComponent implements OnInit {

  constructor(private service:ApiserviceService) { }
  DistrictList: any = [];
  ModalTitle = "";
  ActivateAddEditDis: boolean = false;
  dist: any;
  DistrictFilter ="";

  ngOnInit(): void {
    this.refreshDisList();
  }
  addClick() {
    this.dist = {
      districtID: "0",
      districtName: "",
      provinceName: "",
    }
    this.ModalTitle = "Add District";
    this.ActivateAddEditDis = true;
  }
  editClick(item: any) {
    this.dist= item;
    this.ModalTitle = "Edit Employee";
    this.ActivateAddEditDis = true;
  }

  deleteClick(item: any) {
    if (confirm('Are you sure??')) {
      this.service.deleteDistrict(item.districtID).subscribe(data => {
        alert(data.toString());
        this.refreshDisList();
      })
    }
  }

  closeClick() {
    this.ActivateAddEditDis = false;
    this.refreshDisList();
  }

  refreshDisList() {
    this.service.getDistrictList().subscribe(data => {
      this.DistrictList = data;
    });
  }

}
