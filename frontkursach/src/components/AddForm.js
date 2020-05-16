import React, { Component } from 'react';
import TextField from '@material-ui/core/TextField';
import Button from '@material-ui/core/Button';
import { makeStyles } from '@material-ui/core/styles';
import DropDown from './dropDownPanel';
import {connect} from 'react-redux';


class AddForm extends Component {
    state = {
        allname: '',
        ticketnumber: '',
        flat: '',
        house: '',
        street: '',
        town: '',
        country: ''
    };

    fioChange = (e) => {
        this.setState({ ...this.state, allname: e.target.value });
        //console.log(e.target.value);
    }

    ticketnumberChange = (e) => {
        this.setState({ ...this.state, ticketnumber: e.target.value });
        //console.log(e.target.value);
    }

    flatChange = (e) => {
        this.setState({ ...this.state, flat: e });
        //console.log(e.target.value);
    }

    houseChange = (e) => {
        this.setState({ ...this.state, house: e });
        //console.log(e.target.value);
    }

    streetChange = (e) => {
        this.setState({ ...this.state, street: e});
        //console.log(e.target.value);
    }

    townChange = (e) => {
        this.setState({ ...this.state, town: e});
        //console.log(e.target.value);
    }

    countryChange = (e) => {
        this.setState({ ...this.state, country: e });
        console.log(e);
    }

    btnClick = () => {
        this.props.onAddCustomer(this.state);
    }

    render() {
        console.log(this.state);
        return (
            <div className="AddCustomer">
                <form>
                    <TextField label="ФИО" onChange={this.fioChange} variant="outlined" />
                    <TextField label="Номер абонемента" onChange={this.ticketnumberChange} variant="outlined" />
                    <DropDown datas={this.props.Countries} onChanged={this.countryChange} title="Страна"/>
                    <DropDown datas={this.props.Towns} onChanged={this.townChange} title="Город"/>
                    <DropDown datas={this.props.Streets} onChanged={this.streetChange} title="Улица" />
                    <DropDown datas={this.props.Houses} onChanged={this.houseChange} title="Дом" />
                    <DropDown datas={this.props.Flats} onChanged={this.flatChange} title="Квартира" />
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

const mapStateToProps = (state) => {
    return { Countries: state.Countries, Towns: state.Towns, Streets: state.Streets, Houses: state.Houses, Flats: state.Flats }
}

export default connect(mapStateToProps)(AddForm);
