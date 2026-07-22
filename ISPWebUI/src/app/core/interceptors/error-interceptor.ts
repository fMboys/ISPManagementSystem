import { HttpInterceptorFn } from '@angular/common/http';
import { inject } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { catchError } from 'rxjs/internal/operators/catchError';

export const errorInterceptor: HttpInterceptorFn = (req, next) => {
  const router = inject(Router);
  const toastr = inject(ToastrService);
  return next(req).pipe(
    catchError(error => {
      if (error){
        // if (error.status === 404) {
        //     router.navigateByUrl('/not-found');
        // }
        switch (error.status) {
          case 0:
            toastr.error('Network Error - check your connection.', 'Error 0');
            console.error('Error 0: Network Error - check your connection.');
            break;
          case 400:
              toastr.error(error.error?.message || 'Bad Request', 'Error 400');
              break;
          case 401:
            toastr.error(error.error?.message || 'Unauthorized', 'Error 401');
            break;
          case 404:
            console.error('Error 404: Resource Not Found');
            router.navigateByUrl('/not-found');
            break;
          case 500:
            console.error('Error 500: Internal Server Error');
            const navigationExtras = { state: { error: error.error}};
            router.navigateByUrl('/server-error', navigationExtras);
            break;
          default:
            console.error(`Error ${error.status}: ${error.message}`);
            break;
        }
      }
      throw error;
    })
  );
};
