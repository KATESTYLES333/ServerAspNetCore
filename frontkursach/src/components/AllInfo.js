import React, { Component } from 'react';
import TextField from '@material-ui/core/TextField';
import Button from '@material-ui/core/Button';
import { makeStyles } from '@material-ui/core/styles';
import Table from './allInfoTable';
import { connect } from 'react-redux';


const useStyles = makeStyles((theme) => ({
    button: {
        margin: theme.spacing(1),
    },
}));

const AllInfo = ({ allInfo }) => {
    console.log(allInfo[0].visits)
    return (
        <div className="AllInfo">
            <Table columns={['allname', 'ticketnumber', 'flat', 'house', 'street', 'town', 'country', 'time', 'visits', 'price']}
                tableData={allInfo} />
        </div>
    );
};

const mapStateToProps = (state) => {
    // let newArr = [];
    // for (let index = 0; index < state.Customers.length; index++) {
    //     newArr.push({ ...state.Customers, ...state.Tickets })
    // }
    return {
        allInfo: state.Customers.map((item, index) => ({ ...item, ...state.Tickets[index] }))
    }
}

export default connect(mapStateToProps)(AllInfo);