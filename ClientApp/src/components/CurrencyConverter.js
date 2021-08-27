import React, { useState, useEffect, useMemo, useCallback } from 'react';
import api from '../Services/api';
import { makeStyles } from '@material-ui/core/styles';
import {
    Typography,
    Grid,
    TextField,
    CircularProgress 
} from '@material-ui/core';

import Autocomplete from '@material-ui/lab/Autocomplete';

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

export function CurrencyConverter(props) {
    const classes = useStyles();
    const [loading, setLoading] = useState(false);
    const [currencyList, setCurrencyList] = useState([]);

    const [rate, setRate] = useState();
    const [baseAmount, setBaseAmount] = useState();
    const [targetAmount, setTargetAmount] = useState();

    const [baseCurrency, setBaseCurrency] = useState('');
    const [targetCurrency, setTargetCurrency] = useState('');

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
        if (baseCurrency && targetCurrency && baseAmount) {
            setLoading(true)
            api.GetCurrencyConverstion(baseCurrency, targetCurrency)
                .then(conversion => {
                    setRate(conversion.conversion_rate);
                    setTargetAmount((conversion.conversion_rate * baseAmount).toFixed(3));
                    setLoading(false)
                })
        }
    }, [baseAmount,baseCurrency,targetCurrency])

    const handleBaseAmount = useCallback((event) => {
        setBaseAmount(event.target.value);
    }, []);

    const handleChangeTargetCurrency = useCallback((event, newValue) => {
        if (newValue == null) {
            newValue = ''
        }
        setTargetCurrency(newValue);
    }, []);

    const handleChangeBaseCurrency = useCallback((event, newValue) => {
        if (newValue == null) {
            newValue = ''
        }
        setBaseCurrency(newValue);
    }, []);

    const baseCurrencyList = useMemo(() => {
        return <Autocomplete
            id="combo-box-base"
            size="small"
            options={currencyList}
            onChange={handleChangeBaseCurrency}
            style={{ width: 150 }}
            renderInput={(params) => <TextField {...params} value={baseCurrency} variant="outlined" />}
        />
    }, [baseCurrency, currencyList, handleChangeBaseCurrency])

    const targetCurrencyList = useMemo(() => {
       return <Autocomplete
           id="combo-box-target"
           size="small"
           options={currencyList}
           onChange={handleChangeTargetCurrency}
            style={{ width: 150 }}
           renderInput={(params) => <TextField {...params} value={targetCurrency }  variant="outlined" />}
        />
    }, [currencyList, handleChangeTargetCurrency,targetCurrency])

    return (
        <div>
            <Typography variant="h6" gutterBottom>Currency Converter </Typography>
            <Grid container className={classes.header}
                spacing={0}
                direction="row">
                <Grid item xs={4} lg={2} align="center">
                    {baseCurrencyList}
                    <Typography variant="h1"><TextField type="number" onChange={handleBaseAmount} value={baseAmount || ''}
                        style={{ width: 100 }}
                         /></Typography>

                </Grid>
                <Grid item xs={2} lg={1}></Grid>
                <Grid item xs={4} lg={2} align="center">
                    {targetCurrencyList}
                    {loading ? <CircularProgress /> : <Typography variant="h5" mt={2}>{targetAmount}</Typography>}
                </Grid>
            </Grid>
        </div>
    );
}
