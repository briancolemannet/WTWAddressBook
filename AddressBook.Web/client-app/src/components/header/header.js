import React, { Component } from 'react';
import { Link } from 'react-router'

import './header.css';

class Header extends Component {
  render() {
    return (
      <nav className="navbar navbar-default navbar-fixed-top">
        <div className="container">
          <div className="navbar-header">
            <button type="button" className="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
              <span className="sr-only">Toggle navigation</span>
              <span className="icon-bar"></span>
              <span className="icon-bar"></span>
              <span className="icon-bar"></span>
            </button>
            <a className="navbar-brand" href="#">Brian's Address Book</a>
          </div>
          <div id="navbar" className="navbar-collapse collapse">
            <ul className="nav navbar-nav">
              <li><Link to="/contacts">Contacts</Link></li>
              <li><Link to="/add">Add Contact</Link></li>
            </ul>
          </div>
        </div>
      </nav>
    );
  }
}

export default Header;
