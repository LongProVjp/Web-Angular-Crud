import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEditDistrictComponent } from './add-edit-district.component';

describe('AddEditDistrictComponent', () => {
  let component: AddEditDistrictComponent;
  let fixture: ComponentFixture<AddEditDistrictComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddEditDistrictComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddEditDistrictComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
