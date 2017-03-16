import { combineReducers } from 'redux';

import contacts from './contacts';


const addressBookApp = combineReducers({
    contacts
});

export default addressBookApp;