import * as React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Header from './components/Header'
import List from './components/ListOfContries'

import './custom.css'

export default () => (
    <Layout>
        <Header>
            <Route path='/' component={List} />
        </Header>
    </Layout>
);
