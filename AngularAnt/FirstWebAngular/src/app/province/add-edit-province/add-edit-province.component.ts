import { Component, OnInit, Input} from '@angular/core';
import { ApiserviceService } from 'src/app/apiservice.service';


@Component({
  selector: 'app-add-edit-province',
  templateUrl: './add-edit-province.component.html',
  styleUrls: ['./add-edit-province.component.css']
})
export class AddEditProvinceComponent implements OnInit {
  @Input() provi: any;
  provinceID = "";
  provinceName= "";
  constructor(private service: ApiserviceService) { }
 
  ngOnInit(): void {
    this.provinceID = this.provi.provinceID;
    this.provinceName = this.provi.provinceName;
  }

  
  addProvince() {
    var pro = {
      provinceID: this.provinceID,
      provinceName : this.provinceName
    };
    this.service.addProvince(pro).subscribe(res => {
      alert(res.toString());
    });
  }

  updateProvince() {
    var pro = {
      provinceID: this.provinceID,
      provinceName: this.provinceName
    };
    this.service.updateProvince(pro).subscribe(res => {
      alert(res.toString());
    });
  }
  
}
