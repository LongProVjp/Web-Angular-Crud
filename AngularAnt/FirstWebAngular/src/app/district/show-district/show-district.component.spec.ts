import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowDistrictComponent } from './show-district.component';

describe('ShowDistrictComponent', () => {
  let component: ShowDistrictComponent;
  let fixture: ComponentFixture<ShowDistrictComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowDistrictComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ShowDistrictComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
