﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection;
using System.Threading.Tasks;

namespace currency_rates.Services
{
    /* 
     * Classes Generated from online JSON to C# converter, 
     * Note: Changed type for any property of Rates class to be double from int **/
    public class Rates
    {
        public double USD { get; set; }
        public double AED { get; set; }
        public double AFN { get; set; }
        public double ALL { get; set; }
        public double AMD { get; set; }
        public double ANG { get; set; }
        public double AOA { get; set; }
        public double ARS { get; set; }
        public double AUD { get; set; }
        public double AWG { get; set; }
        public double AZN { get; set; }
        public double BAM { get; set; }
        public double BBD { get; set; }
        public double BDT { get; set; }
        public double BGN { get; set; }
        public double BHD { get; set; }
        public double BIF { get; set; }
        public double BMD { get; set; }
        public double BND { get; set; }
        public double BOB { get; set; }
        public double BRL { get; set; }
        public double BSD { get; set; }
        public double BTN { get; set; }
        public double BWP { get; set; }
        public double BYN { get; set; }
        public double BZD { get; set; }
        public double CAD { get; set; }
        public double CDF { get; set; }
        public double CHF { get; set; }
        public double CLP { get; set; }
        public double CNY { get; set; }
        public double COP { get; set; }
        public double CRC { get; set; }
        public double CUC { get; set; }
        public double CUP { get; set; }
        public double CVE { get; set; }
        public double CZK { get; set; }
        public double DJF { get; set; }
        public double DKK { get; set; }
        public double DOP { get; set; }
        public double DZD { get; set; }
        public double EGP { get; set; }
        public double ERN { get; set; }
        public double ETB { get; set; }
        public double EUR { get; set; }
        public double FJD { get; set; }
        public double FKP { get; set; }
        public double FOK { get; set; }
        public double GBP { get; set; }
        public double GEL { get; set; }
        public double GGP { get; set; }
        public double GHS { get; set; }
        public double GIP { get; set; }
        public double GMD { get; set; }
        public double GNF { get; set; }
        public double GTQ { get; set; }
        public double GYD { get; set; }
        public double HKD { get; set; }
        public double HNL { get; set; }
        public double HRK { get; set; }
        public double HTG { get; set; }
        public double HUF { get; set; }
        public double IDR { get; set; }
        public double ILS { get; set; }
        public double IMP { get; set; }
        public double INR { get; set; }
        public double IQD { get; set; }
        public double IRR { get; set; }
        public double ISK { get; set; }
        public double JMD { get; set; }
        public double JOD { get; set; }
        public double JPY { get; set; }
        public double KES { get; set; }
        public double KGS { get; set; }
        public double KHR { get; set; }
        public double KID { get; set; }
        public double KMF { get; set; }
        public double KRW { get; set; }
        public double KWD { get; set; }
        public double KYD { get; set; }
        public double KZT { get; set; }
        public double LAK { get; set; }
        public double LBP { get; set; }
        public double LKR { get; set; }
        public double LRD { get; set; }
        public double LSL { get; set; }
        public double LYD { get; set; }
        public double MAD { get; set; }
        public double MDL { get; set; }
        public double MGA { get; set; }
        public double MKD { get; set; }
        public double MMK { get; set; }
        public double MNT { get; set; }
        public double MOP { get; set; }
        public double MRU { get; set; }
        public double MUR { get; set; }
        public double MVR { get; set; }
        public double MWK { get; set; }
        public double MXN { get; set; }
        public double MYR { get; set; }
        public double MZN { get; set; }
        public double NAD { get; set; }
        public double NGN { get; set; }
        public double NIO { get; set; }
        public double NOK { get; set; }
        public double NPR { get; set; }
        public double NZD { get; set; }
        public double OMR { get; set; }
        public double PAB { get; set; }
        public double PEN { get; set; }
        public double PGK { get; set; }
        public double PHP { get; set; }
        public double PKR { get; set; }
        public double PLN { get; set; }
        public double PYG { get; set; }
        public double QAR { get; set; }
        public double RON { get; set; }
        public double RSD { get; set; }
        public double RUB { get; set; }
        public double RWF { get; set; }
        public double SAR { get; set; }
        public double SBD { get; set; }
        public double SCR { get; set; }
        public double SDG { get; set; }
        public double SEK { get; set; }
        public double SGD { get; set; }
        public double SHP { get; set; }
        public double SLL { get; set; }
        public double SOS { get; set; }
        public double SRD { get; set; }
        public double SSP { get; set; }
        public double STN { get; set; }
        public double SYP { get; set; }
        public double SZL { get; set; }
        public double THB { get; set; }
        public double TJS { get; set; }
        public double TMT { get; set; }
        public double TND { get; set; }
        public double TOP { get; set; }
        public double TRY { get; set; }
        public double TTD { get; set; }
        public double TVD { get; set; }
        public double TWD { get; set; }
        public double TZS { get; set; }
        public double UAH { get; set; }
        public double UGX { get; set; }
        public double UYU { get; set; }
        public double UZS { get; set; }
        public double VES { get; set; }
        public double VND { get; set; }
        public double VUV { get; set; }
        public double WST { get; set; }
        public double XAF { get; set; }
        public double XCD { get; set; }
        public double XDR { get; set; }
        public double XOF { get; set; }
        public double XPF { get; set; }
        public double YER { get; set; }
        public double ZAR { get; set; }
        public double ZMW { get; set; }
    }
    public class StandardRate
    {
        public string provider { get; set; }
        public string WARNING_UPGRADE_TO_V6 { get; set; }
        public string terms { get; set; }
        public string @base { get; set; }
        public string date { get; set; }
        public int time_last_updated { get; set; }
        public Rates rates { get; set; }
    }

    public class ConversionRate
    {
        //public string result { get; set; }
        //public string documentation { get; set; }
        //public string terms_of_use { get; set; }
        //public int time_last_update_unix { get; set; }
        //public string time_last_update_utc { get; set; }
        //public int time_next_update_unix { get; set; }
        //public string time_next_update_utc { get; set; }
        public string base_code { get; set; }
        public string target_code { get; set; }
        public double? conversion_rate { get; set; }
    }

    /* End */

    public class CurrencyApi
    {
        static HttpClient client = new HttpClient();

        public CurrencyApi(/*api key*/)
        {

        }

        public static List<string> GetCurrencyList()
        {
            //optimize
            return typeof(Rates)
                .GetMembers()
                .Where(m => m.MemberType == MemberTypes.Property)
                .Select(m => m.Name)
                .ToList();
        }

        public static async Task<ConversionRate> GetConversionRateAsync(string baseCurrency, string targetCurrency)
        {
            ConversionRate conversion = null;
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://api.exchangerate-api.com/v4/latest/" + baseCurrency);
                if (response.IsSuccessStatusCode)
                {
                    StandardRate rates = await response.Content.ReadFromJsonAsync<StandardRate>();
                    var obj = typeof(Rates).GetProperty(targetCurrency).GetValue(rates.rates, null);
                    conversion = new ConversionRate()
                    {
                        base_code = baseCurrency,
                        target_code = targetCurrency,
                        conversion_rate = (double)obj
                    };
                }
            }
            catch (Exception ex)
            {

            }
            return conversion;
        }

        public static async Task<StandardRate> GetRatesAsync(string currency)
        {
            //TODO : Can we just return row JSON string  to avoid parsing performance cost ??
            StandardRate rates = null;
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://api.exchangerate-api.com/v4/latest/" + currency);
                if (response.IsSuccessStatusCode)
                {
                    rates = await response.Content.ReadFromJsonAsync<StandardRate>();
                }
            }
            catch (Exception ex)
            {

            }
            return rates;
        }

        public static string GetRates(string currency)
        {
            try
            {
                var requestTask = Task.Run(async () => await client.GetAsync("https://api.exchangerate-api.com/v4/latest/" + currency));
                HttpResponseMessage response = requestTask.Result;
                if (response.IsSuccessStatusCode)
                {
                    var contentTask = Task.Run(async () => await response.Content.ReadAsStringAsync());
                    return contentTask.Result;
                }
            }
            catch (Exception ex)
            {
                //handle this or throw it back for consumer to handle it
            }

            return "{}";
        }
    }
}
