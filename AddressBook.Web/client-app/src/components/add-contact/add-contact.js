import React, { Component } from 'react';

import './add-contact.css';


class ContactList extends Component {
  constructor(props) {
    super(props);

    this.state = {
      name:'',
      phone:'',
      email:'',
      address:'',
      errors: {}
    };

    this.onFormSubmit = this.onFormSubmit.bind(this);
    this.onInputChange = this.onInputChange.bind(this);
  }

  validate() {
    console.log(`name: ${this.state.name}`);
  }

  onFormSubmit(event) {
    event.preventDefault();
    console.log('submitted');
    this.validate();
  }

  onInputChange(event, stateName) {
    this.setState({ [stateName]: event.target.value });
  }

  render() {
    return (
      <div id="AddContacts">
        <h2>Add Contact</h2>
        <form onSubmit={this.onFormSubmit}>
          <div className={`form-group${this.state.errors.name ? ' has-error' : ''}`}>
            <label htmlFor="Name">Name</label>
            <input value={this.state.name} onChange={event => this.onInputChange(event, 'name')} id="Name" type="text" className="form-control" placeholder="Joe Smith" />
          </div>
          <div className="form-group">
            <label htmlFor="Phone">Phone number</label>
            <input value={this.state.phone} onChange={event => this.onInputChange(event, 'phone')} id="Phone" type="text" className="form-control" placeholder="(801) 555-1234" />
          </div>
          <div className="form-group">
            <label htmlFor="Email">Email</label>
            <input value={this.state.email} onChange={event => this.onInputChange(event, 'email')} id="Email" type="text" className="form-control" placeholder="name@domain.com" />
          </div>
          <div className="form-group">
            <label htmlFor="Address">Address</label>
            <input value={this.state.address} onChange={event => this.onInputChange(event, 'address')} id="Address" type="text" className="form-control" placeholder="1234 Main St., Some City, State" />
          </div>
          <div className="clearfix">
            <button type="submit" className="btn btn-primary pull-right">Add</button>
          </div>
        </form>
      </div>
    );
  }
}

export default ContactList;

