using RenameApp.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq.Expressions;

namespace RenameApp.Contracts
{
    public partial class WeatherForecast
    {
        [Display(Name = "Temperature Filter")]
        public class TemperatureFilter
        {
            /// <summary>
            /// Query the weather whose temperature is greater than the current filter temperature (Celsius).
            /// </summary>
            [Display(Name = "Temperature (Celsius)")]
            public int? Temperature { get; set; }

            public Expression<Func<WeatherForecast, bool>> ToExpression(bool defaultValue = false)
            {
                Expression<Func<WeatherForecast, bool>>? expression = null;

                if (this.Temperature.HasValue)
                {
                    expression = expression.And(x => x.TemperatureC >= this.Temperature);
                }

                expression ??= x => defaultValue;

                return expression;
            }

        }

        public class CityFilter
        {
            public string City { get; set; } = String.Empty;

            [Display(Name = "Weather Condition")]
            public ICollection<WeatherState>? WeatherStatus { get; set; }

            public Expression<Func<WeatherForecast, bool>> ToExpression(bool defaultValue = false)
            {
                Expression<Func<WeatherForecast, bool>>? expression = null;

                expression = expression.And(x => x.City == this.City);

                if (this.WeatherStatus is not null)
                {
                    expression = expression.And(x => this.WeatherStatus!.Contains(x.WeatherState!.Value));
                }

                expression ??= x => defaultValue;

                return expression;
            }

        }

        public class DateFilter
        {
            public DateOnly? Begindate { get; set; }

            public DateOnly? Enddate { get; set; }

            public Expression<Func<WeatherForecast, bool>> ToExpression(bool defaultValue = false)
            {
                Expression<Func<WeatherForecast, bool>>? expression = null;

                if (this.Begindate.HasValue)
                {
                    expression = expression.And(x => x.DateTime >= this.Begindate);
                }

                if (this.Enddate.HasValue)
                {
                    expression = expression.And(x => x.DateTime <= this.Enddate);
                }

                expression ??= x => defaultValue;

                return expression;
            }

        }
    }
}
