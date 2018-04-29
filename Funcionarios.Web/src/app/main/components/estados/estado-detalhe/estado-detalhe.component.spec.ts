import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EstadoDetalheComponent } from './estado-detalhe.component';

describe('EstadoDetalheComponent', () => {
  let component: EstadoDetalheComponent;
  let fixture: ComponentFixture<EstadoDetalheComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EstadoDetalheComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EstadoDetalheComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
