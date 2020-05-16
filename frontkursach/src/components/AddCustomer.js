import React, { Component } from 'react';
import TextField from '@material-ui/core/TextField';
import Button from '@material-ui/core/Button';
import { makeStyles } from '@material-ui/core/styles';
import Table from './table';
import AddForm from './AddForm';
import { bindActionCreators } from 'redux';
import * as actions from '../actions/actions';
import { connect } from 'react-redux';


const useStyles = makeStyles((theme) => ({
    button: {
        margin: theme.spacing(1),
    },
}));

const AddCustomer = ({ Customers, onAddCustomer }) => {

    return (
        <div className="AddCustomer">
            <AddForm onAddCustomer={(customers) => onAddCustomer(customers)} />
            <Table columns={['allname', 'ticketnumber', 'flat', 'house', 'street', 'town', 'country']} tableData={Customers} />
        </div>
    );
};

const mapStateToProps = (state) => {
    return {
        Customers: state.Customers
    }
}

const mapDispatchToProps = (dispatch) => {
    const { onAddCustomer } = bindActionCreators(actions, dispatch)
    console.log(actions, 'zhopa');
    return {
        onAddCustomer: onAddCustomer
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(AddCustomer);