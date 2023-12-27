/*
 * Created by SharpDevelop.
 * User: Ads
 * Date: 5/10/2008
 * Time: 8:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace CurrencyTrader
{
	/// <summary>
	/// Description of CurrencyTrader.
	/// </summary>
	public abstract class CurrencyTrader
	{
		private double _exchangeRate;
		
		protected double ExchangeRate
		{
			get {
				return _exchangeRate;
				}
			set {
				_exchangeRate = value;
				}		
		}
		
		protected double ConvertValue(double input)
		{
			return _exchangeRate * input;
		}
		
		protected double ConvertValueInverse(double input)
		{
			return input/_exchangeRate;
		}
	}
}
