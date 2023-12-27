/*
 * Created by SharpDevelop.
 * User: Ads
 * Date: 5/10/2008
 * Time: 8:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace CurrencyTrader
{
	/// <summary>
	/// Description of ActiveCurrencyTrader.
	/// </summary>
	public class ActiveCurrencyTrader : CurrencyTrader
	{
		string _fromCurrency, _toCurrency;
		
		public ActiveCurrencyTrader(double currExchange, string fromCurrency, string toCurrency)
		{
			ExchangeRate = currExchange;
			_fromCurrency = fromCurrency;
			_toCurrency = toCurrency;
		}
		
		public string FromCurrency
		{
			get {
				return _fromCurrency;	
				}
		}
		
		public string ToCurrency
		{
			get {
				return _toCurrency;
				}
		}
		
		public double ConvertTo(double value)
		{
			return ConvertValue(value);
		}
		
		public double ConvertFrom(double value)
		{
			return ConvertValueInverse(value);
		}
	}
}
