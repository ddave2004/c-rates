import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
        <>
            <a href="/currency-rates">Go to currency rates component</a>
        </>
    );
  }
}
