
export const ADD_CONTACT = 'ADD_CONTACT';

export const EDIT_CONTACT = 'EDIT_CONTACT';

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

