import React, { Component } from 'react';
import TextField from '@material-ui/core/TextField';
import Button from '@material-ui/core/Button';
import { makeStyles } from '@material-ui/core/styles';


class AddTicketForm extends Component {
    state = {
        time: '',
        price: '',
        visits: '',
        number: '',
    };

    timeChange = (e) => {
        this.setState({ ...this.state, time: e.target.value });
        //console.log(e.target.value);
    }

    priceChange = (e) => {
        this.setState({ ...this.state, price: e.target.value });
        //console.log(e.target.value);
    }

    visitsChange = (e) => {
        this.setState({ ...this.state, visits: e.target.value });
        //console.log(e.target.value);
    }

    numberChange = (e) => {
        this.setState({ ...this.state, number: e.target.value });
        //console.log(e.target.value);
    }

    btnClick = () => {
        this.props.onAddTicket(this.state);
    }

    render() {
        console.log(this.state);
        return (
            <div className="AddTicket">
                <form>
                    <TextField label="Срок" onChange={this.timeChange} variant="outlined" />
                    <TextField label="Цена" onChange={this.priceChange} variant="outlined" />
                    <TextField label="Количество посещений" onChange={this.visitsChange} variant="outlined" />
                    <TextField label="Номер абонемента" onChange={this.numberChange} variant="outlined" />
                    <Button onClick={this.btnClick}
                        variant="contained"
                        color="primary"
                        size="large"
                    // className={classes.button}
                    >
                        Submit
      </Button>
                </form>
            </div>
        );
    }
};

export default AddTicketForm;