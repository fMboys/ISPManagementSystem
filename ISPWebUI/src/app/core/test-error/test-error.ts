import { HttpClient } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import { environment } from '../../../environments/environment';

@Component({
  selector: 'app-test-error',
  imports: [],
  templateUrl: './test-error.html',
  styleUrl: './test-error.css',
})
export class TestError {
  private httpClient = inject(HttpClient);
  baseUrl = environment.apiUrl;

  get500Error() {
    this.httpClient.get(this.baseUrl + 'error-test').subscribe({
      next: (response) => {
        console.log(response);
      },
      error: (error) => {
        console.error(error);
      },
    });
  }
}
