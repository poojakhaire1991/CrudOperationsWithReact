import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchCustomer } from './components/FetchCustomer';
import { AddCustomer } from './components/AddCustomer';

export const routes = <Layout>
    <Route exact path='/' component={Home} />
    <Route path='/fetchcustomer' component={FetchCustomer} />
    <Route path='/customer/UpdateCustomer/:custid' component={AddCustomer} />
    <Route path='/addcustomer' component={AddCustomer} />
</Layout>;
