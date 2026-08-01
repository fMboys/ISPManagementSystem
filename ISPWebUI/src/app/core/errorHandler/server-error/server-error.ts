import { Component, computed, inject } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-server-error',
  imports: [],
  templateUrl: './server-error.html',
  styleUrl: './server-error.css',
})
export class ServerError {
  private router = inject(Router);

  nagivations = computed(() => this.router.currentNavigation());
  error = computed(() => this.nagivations()?.extras?.state?.['error']);
}
