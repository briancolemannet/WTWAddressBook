import React from 'react';
import ReactDOM from 'react-dom';
import { Provider } from 'react-redux';
import { createStore, applyMiddleware } from 'redux';
import promiseMiddleware from 'redux-promise-middleware';

import { Router, Route, hashHistory } from 'react-router';

import App from './App';
import ContactList from './components/contact-list';
import AddContact from './components/add-contact';
import addressBookApp from './reducers';
import './index.css';

let store = createStore(addressBookApp, applyMiddleware(promiseMiddleware()));

ReactDOM.render(
  <Provider store={store}>
    <Router history={hashHistory}>
      <Route path="/" component={App}>
        <Route path="/contacts" component={ContactList} />
        <Route path="/add" component={AddContact} />
      </Route>
    </Router>
  </Provider>,
  document.getElementById('root')
);
