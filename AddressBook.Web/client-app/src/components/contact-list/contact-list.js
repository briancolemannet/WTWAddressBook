import React, { Component } from 'react';
import { connect } from 'react-redux';
import { Link } from 'react-router';

import { getContacts } from '../../actions';
import './contact-list.css';


class ContactList extends Component {
  componentWillMount() {
    this.props.getContacts();
  }

  renderContact(contact) {
    return (
      <Link key={contact.id} to={`/contacts/${contact.id}`} className="list-group-item">{contact.name}</Link>
    );
  }

  render() {
    console.dir(this.props);
    return (
      <div id="ContactList">
        <div className="list-group">
          {this.props.contacts.map(this.renderContact)}
        </div>
      </div>
    );
  }
}

function mapStateToProps(state) {
  return { contacts: state.contacts.contacts };
}

export default connect(mapStateToProps, { getContacts })(ContactList);

