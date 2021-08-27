import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { CurrencyRates } from './components/CurrencyRates';
import { CurrencyConverter } from './components/CurrencyConverter';


import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
            <Route exact path='/' component={Home} />
            <Route path='/currency-rates' component={CurrencyRates} />
            <Route path='/currency-convert' component={CurrencyConverter} />
      </Layout>
    );
  }
}
