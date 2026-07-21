import { Routes } from '@angular/router';
import { ServerError } from './core/errorHandler/server-error/server-error';
import { TestError } from './core/test-error/test-error';

export const routes: Routes = [
    {path: '', redirectTo: 'home', pathMatch: 'full'},
    {path: 'home', loadComponent: () => import('./features/home/home').then(m => m.Home)},
    {path: 'customers', loadComponent: () => import('./features/customer').then(m => m.Customer)},
//       {
//     path: 'customers/:id',
//     loadComponent: () => import('./customer-detail/customer-detail').then(m => m.CustomerDetailComponent),
//   },
//   {
//     path: 'add-customer',
//     loadComponent: () => import('./customer-form/customer-form').then(m => m.CustomerFormComponent),
//   },
    {path: 'not-found',
        loadComponent: () => import('./core/errorHandler/not-found/not-found').then(e => e.NotFound)
    },
    {path: 'server-error', component:ServerError},
    {path: 'test-error', component:TestError},
    {path: '**', redirectTo: 'home'}
];
