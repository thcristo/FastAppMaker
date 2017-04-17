import { Routes, RouterModule } from '@angular/router';
import { IndexComponent } from './index.component';
import { UsersComponent } from './users.component';
import { RolesComponent } from './roles.component';

const appRoutes: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: IndexComponent, data: { title: 'Home' } },
    { path: 'users', component: UsersComponent, data: { title: 'Users' } },
    { path: 'roles', component: RolesComponent, data: { title: 'Roles' } }
];

export const routing = RouterModule.forRoot(appRoutes);

export const routedComponents = [IndexComponent, UsersComponent, RolesComponent];
