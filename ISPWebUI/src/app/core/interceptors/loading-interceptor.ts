import { HttpInterceptorFn } from '@angular/common/http';
import { inject } from '@angular/core';
import { LoaderService } from '../services/loader.service';
import { delay, finalize } from 'rxjs';

export const loadingInterceptor: HttpInterceptorFn = (req, next) => {
  const spinnerService = inject(LoaderService);
  spinnerService.loader();
  return next(req).pipe(
    delay(1000),
    finalize(() => {
      spinnerService.idle();
    })
  );
};
