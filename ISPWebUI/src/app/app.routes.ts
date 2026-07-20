import { Routes } from '@angular/router';

export const routes: Routes = [
    {path: '', redirectTo: 'home', pathMatch: 'full'},
    {path: 'home', loadComponent: () => import('./features/home/home').then(m => m.Home)},
    {path: 'customer', loadComponent: () => import('./features/customer').then(m => m.Customer)},
//       {
//     path: 'customers/:id',
//     loadComponent: () => import('./customer-detail/customer-detail').then(m => m.CustomerDetailComponent),
//   },
//   {
//     path: 'add-customer',
//     loadComponent: () => import('./customer-form/customer-form').then(m => m.CustomerFormComponent),
//   },
    {path: '**', redirectTo: 'home'}
];
