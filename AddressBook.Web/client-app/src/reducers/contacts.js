import { GET_CONTACTS } from '../actions';
const INITIAL_STATE = {
    contacts: []
};

const contacts = (state = INITIAL_STATE, action) => {
    switch (action.type) {
        case `${GET_CONTACTS}_FULFILLED`:
            var newState = { ...state, contacts: action.payload };
            console.log('New State:');
            console.dir(newState);
            return newState;
        default:
            return state;
    }
}

export default contacts;
