import React, { Component } from 'react';
import './App.css';
import 'bootstrap/dist/css/bootstrap.css';
import 'bootstrap/dist/css/bootstrap-theme.css';

import Header from './components/header/header';

class App extends Component {
  render() {
    return (
      <div className="App">
        <Header />
        <div id="MainContainer" className="container">
        {this.props.children}
        </div>
      </div>
    );
  }
}

export default App;
