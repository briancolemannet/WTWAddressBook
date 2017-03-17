import axios from 'axios';

const API_BASE_URL = 'http://localhost:53235/api/';

export const ADD_CONTACT = 'ADD_CONTACT';
export const EDIT_CONTACT = 'EDIT_CONTACT';
export const GET_CONTACTS = 'GET_CONTACTS';

export const getContacts = () => {
    const request = axios.get(`${API_BASE_URL}contacts`).then(resp => {
        return resp.data.contacts;
    });
    return {
        type: GET_CONTACTS,
        payload: request
    };
};

export const addContact = (contact) => {
    return {
        type: ADD_CONTACT,
        contact
    };
};

export const editContact = (contact) => {
    return {
        type: EDIT_CONTACT,
        contact
    };
};

