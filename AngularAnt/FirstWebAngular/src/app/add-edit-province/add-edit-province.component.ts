import { Component, OnInit, Input} from '@angular/core';
import { ApiserviceService } from 'src/app/apiservice.service';


@Component({
  selector: 'app-add-edit-province',
  templateUrl: './add-edit-province.component.html',
  styleUrls: ['./add-edit-province.component.css']
})
export class AddEditProvinceComponent implements OnInit {
  @Input() provi: any;
  id = "";
  province= "";
  district="";
  constructor(private service: ApiserviceService) { }
 
  ngOnInit(): void {
    this.id = this.provi.id;
    this.province = this.provi.province;
    this.district = this.provi.district;
  }

  
  addProvince() {
    var pro = {
      id: this.id,
      province: this.province,
      district:this.district
    };
    this.service.addProvince(pro).subscribe(res => {
      alert(res.toString());
    });
  }

  updateProvince() {
    var pro = {
      id: this.id,
      province: this.province,
      district:this.district
    };
    this.service.updateProvince(pro).subscribe(res => {
      alert(res.toString());
    });
  }
  
}
