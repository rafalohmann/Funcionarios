import {Routes} from '@angular/router';

import { MainLayoutComponent } from './layouts/main-layout/main-layout.component';
import { AuthLayoutComponent } from './layouts/auth-layout/auth-layout.component';

export const AppRoutes: Routes = [{
  path: '',
  component: MainLayoutComponent,
  children: [
    {
      path: '',
      redirectTo: 'pages',
      pathMatch: 'full'
    }, {
      path: 'pages',
      loadChildren: './pages/pages.module#PagesModule'
    }, {
      path: 'simple-page',
      loadChildren: './pages/pages.module#PagesModule'
    }
  ]
}, {
  path: '',
  component: AuthLayoutComponent,
  children: [
    {
      path: 'authentication',
      loadChildren: './authentication/authentication.module#AuthenticationModule'
    }
  ]
}, {
  path: '**',
  redirectTo: 'error/404'
}];
