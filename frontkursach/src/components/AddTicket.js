import React, { Component } from 'react';
import TextField from '@material-ui/core/TextField';
import Button from '@material-ui/core/Button';
import { makeStyles } from '@material-ui/core/styles';
import Table from './ticketTable';
import AddTicketForm from './AddTicketForm';
import { bindActionCreators } from 'redux';
import * as actions from '../actions/actions';
import { connect } from 'react-redux';


const useStyles = makeStyles((theme) => ({
    button: {
        margin: theme.spacing(1),
    },
}));

const AddTicket = ({ Tickets, onAddTicket }) => {
    console.log(Tickets)
    return (
        <div className="AddTicket">
            <AddTicketForm onAddTicket={(tickets) => onAddTicket(tickets)} />
            <Table columns={['time', 'price', 'visits', 'number']} tableData={Tickets} />
        </div>
    );
};

const mapStateToProps = (state) => {
    return {
        Tickets: state.Tickets
    }
}

const mapDispatchToProps = (dispatch) => {
    const { onAddTicket } = bindActionCreators(actions, dispatch)
    console.log(actions, ' 1');
    return {
        onAddTicket: onAddTicket
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(AddTicket);