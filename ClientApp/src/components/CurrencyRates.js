import React, { useState, useEffect, useMemo, useCallback } from 'react';
import api from '../Services/api';
import { makeStyles } from '@material-ui/core/styles';
import {
    Input,
    Select,
    MenuItem,
    Table,
    TableBody,
    TableCell,
    TableContainer,
    TableHead,
    TableRow,
    Typography,
    Grid,
} from '@material-ui/core';

const ITEM_HEIGHT = 48;
const MenuProps = {
    PaperProps: {
        style: {
            maxHeight: ITEM_HEIGHT * 4.5,
            width: 250,
        },
    },
};

const useStyles = makeStyles({
    root: {
        width: '100%',
    },
    header :{
        flexGrow: 1,
},
    container: {
        maxHeight: 440,
    },
});

export function CurrencyRates(props) {
    const classes = useStyles();
    const [loading, setLoading] = useState(false);
    const [rates, setRates] = useState([]);
    const [currency, setCurrency] = useState('');
    const [currencyList, setCurrencyList] = useState([]);

    useEffect(() => {
        setLoading(true)
        //TODO : set and check in localstorage/sessionstorage
        api.GetCurrencyList()
            .then(currencies => {
                setCurrencyList(currencies);
                setLoading(false)
            })
    }, [])

    useEffect(() => {
        if (currency) {
            setLoading(true)
            api.GetRates(currency)
                .then(rates => {
                    setRates(rates);
                    setLoading(false)
                })
        }
    }, [currency])

    const handleChangeCurrency = useCallback((event) => {
        setCurrency(event.target.value);
    },[]);

    const currencySelector = useMemo(() => {
        return <Select
            id="selected-currency"
            value={currency}
            style={{ width: 100 }}
            onChange={handleChangeCurrency}
            input={<Input />}
            MenuProps={MenuProps}
        >
            {currencyList.map((name) => (
                <MenuItem key={name} value={name}>
                    {name}
                </MenuItem>
            ))}
        </Select>
    }, [currency, currencyList, handleChangeCurrency])

    const rateTable = useMemo(() => {
        return (
            <TableContainer className={classes.container}>
                <Table stickyHeader size="small" aria-label="sticky table">
                    <TableHead>
                        <TableRow>
                            <TableCell>Currency</TableCell>
                            <TableCell>Rate</TableCell>

                        </TableRow>
                    </TableHead>
                    <TableBody>
                        {rates.filter(r => r.Currency !== currency).map((row) => {
                            return (
                                <TableRow tabIndex={-1} key={row.Currency}>
                                    <TableCell>
                                        {row.Currency}
                                    </TableCell>
                                    <TableCell>
                                        {row.Rate}
                                    </TableCell>
                                </TableRow>
                            );
                        })}
                    </TableBody>
                </Table>
            </TableContainer>
        );
    }, [rates, currency]);

    return (
        <div>
            <Grid container
                className={classes.header}
                spacing={0}
                direction="row"
                justifyContent="space-between"
                alignItems="center" >
                <Grid item xs={12} lg={12}>
                    <Typography variant="h6" gutterBottom>Currency Rates For : {currencySelector}</Typography>
                </Grid>
            </Grid>
            {loading
                ? <p><em>Loading...</em></p>
                : rateTable}
        </div>
    );
}
