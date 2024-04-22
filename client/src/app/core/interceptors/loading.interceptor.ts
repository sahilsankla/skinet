import { HttpHandler, HttpInterceptor,HttpRequest,HttpEvent} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, delay, finalize } from 'rxjs';
import { BusyService } from '../services/busy.service';

@Injectable()
export class loadingInterceptor implements HttpInterceptor{

  constructor(private busyService: BusyService){}
  

intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>>{
  this.busyService.busy();
  return next.handle(request).pipe(
    delay(1000),
    finalize(() => this.busyService.idle())
  )
}
}