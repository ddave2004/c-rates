export default class api {

    static server = ""

    static GetCurrencyConverstion(source, target) {
        var url = `${this.server}api/Currency/Convert/${source}/${target}`
        return new Promise(async (resolve, reject) => {
            const response = await fetch(url);
            const data = await response.json();
            resolve(data);
            //??reject 

        })
    }

    static GetCurrencyList() {
        var url = `${this.server}api/Currency/GetCurrencyList`
        return new Promise(async (resolve, reject) => {
            const response = await fetch(url);
            const data = await response.json();
            resolve(data);

            //??reject 
        })
    }

    static GetRates(currency) {
        var url = `${this.server}api/Currency/GetRates/${currency}`
        return new Promise(async (resolve, reject) => {
            const response = await fetch(url);
            const data = await response.json();
            var obj = data.rates || {};
            var rates = Object.keys(obj)
                .map(function (key) {
                    return { Currency: key.toUpperCase(), Rate: obj[key] };
                });

            resolve(rates);

            //??reject 

        })
    }
}