import data from './datas.json'
import axios from 'axios'

const initialState = data;

const reducer = (state = initialState, action) => {
    switch (action.type) {
        case "AddCustomer":
            const newCustomers = [...state.Customers, action.payload];
            return { ...state, Customers: [...newCustomers] }
        case "AddTicket":
            const newTickets = [...state.Tickets, action.payload];
            return { ...state, Tickets: [...newTickets] }
        default:
            return state;
    }
}

axios.get('https://localhost:44346/api/Customers/GetAll')
  .then(function (response) {
    // handle success
    console.log(response);
  })

export default reducer;