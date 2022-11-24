import { Component, OnInit, Input } from '@angular/core';
import { ApiserviceService } from 'src/app/apiservice.service';

@Component({
  selector: 'app-add-edit-district',
  templateUrl: './add-edit-district.component.html',
  styleUrls: ['./add-edit-district.component.css']
})
export class AddEditDistrictComponent implements OnInit {
  @Input() dis: any;
  districtID = "";
  districtName = "";
  provinceName = "";
  ProvinceList: any =[];

  constructor(private service: ApiserviceService) { }
 
  ngOnInit(): void {
    this.loadEmployeeList();
  }

  loadEmployeeList() {

    this.service.getAllDepartmentNames().subscribe((data: any) => {
      this.ProvinceList = data;

      this.districtID = this.dis.districtID;
      this.districtName = this.dis.districtName;
      this.provinceName = this.dis.provinceName;
    });
  }

  addDistrict() {
    var val = {
      districtID :this.districtID,
      districtName : this.districtName,
      provinceName :this.provinceName,
    };

    this.service.addDistrict(val).subscribe(res => {
      alert(res.toString());
    });
  }

  updateDistrict() {
    var val = {
      districtID:this.districtID,
      districtName : this.districtName,
      provinceName :this.provinceName,
    };

    this.service.updateDistrict(val).subscribe(res => {
      alert(res.toString());
    });
  }
}
