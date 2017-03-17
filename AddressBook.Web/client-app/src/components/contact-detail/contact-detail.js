import React, { Component } from 'react';
import { connect } from 'react-redux';

import { getContacts } from '../../actions';
import './contact-detail.css';


class ContactDetail extends Component {
  componentWillMount() {
  }

  render() {
    return (
      <div id="ContactDetail">
        Contact Detail
      </div>
    );
  }
}

function mapStateToProps(state) {
  return { contacts: state.contacts.contacts };
}

export default connect(mapStateToProps, { getContacts })(ContactDetail);

