import { inject } from '@angular/core';
import { Service } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';

@Service()
export class LoaderService {
    loaderRequestCount = 0;
    private spinnerService = inject(NgxSpinnerService);

    loader(){
        this.loaderRequestCount++;
        this.spinnerService.show(undefined, {
            type: 'ball-scale-multiple',
            bdColor: 'rgba(255,255,255,0.7)',
            color: '#333333'
        });
    }

    idle() {
        this.loaderRequestCount--;
        if (this.loaderRequestCount <= 0) {
            this.loaderRequestCount = 0;
            this.spinnerService.hide();
        }
    }
}
