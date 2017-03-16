import React from 'react';
import ReactDOM from 'react-dom';
import { Provider } from 'react-redux';
import {createStore} from 'redux';

import { Router, Route, hashHistory } from 'react-router';

import App from './App';
import ContactList from './components/contact-list';
import AddContact from './components/add-contact';
import './index.css';

let store = createStore();

ReactDOM.render(
  <Provider store={}>
  </Provider>
  <Router history={hashHistory}>
    <Route path="/" component={App}>
      <Route path="/contacts" component={ContactList} />
      <Route path="/add" component={AddContact} />
    </Route>
  </Router>
  ,
  document.getElementById('root')
);
