"use strict";
var router_1 = require("@angular/router");
var index_component_1 = require("./index.component");
var users_component_1 = require("./users.component");
var roles_component_1 = require("./roles.component");
var appRoutes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: index_component_1.IndexComponent, data: { title: 'Home' } },
    { path: 'users', component: users_component_1.UsersComponent, data: { title: 'Users' } },
    { path: 'roles', component: roles_component_1.RolesComponent, data: { title: 'Roles' } }
];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
exports.routedComponents = [index_component_1.IndexComponent, users_component_1.UsersComponent, roles_component_1.RolesComponent];
//# sourceMappingURL=app.routing.js.map