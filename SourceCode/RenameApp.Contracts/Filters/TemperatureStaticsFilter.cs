using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations;
using RenameApp.Common;

namespace RenameApp.Contracts
{
    public partial class TemperatureStatics
    {
        public class TemperatureStaticsQueryModel
        {
            public WeatherForecast WeatherForecast { get; set; }
        }

        public class CityFilter
        {
            public string? City { get; set; }

            public ICollection<WeatherState>? WeatherStatus { get; set; }

            public Expression<Func<TemperatureStaticsQueryModel, bool>> ToExpression(bool defaultValue = false)
            {
                Expression<Func<TemperatureStaticsQueryModel, bool>>? expression = null;

                if (!String.IsNullOrEmpty(this.City))
                {
                    expression = expression.And(x => x.WeatherForecast.City == this.City);
                }

                if (this.WeatherStatus is not null)
                {
                    expression = expression.And(x => this.WeatherStatus!.Contains(x.WeatherForecast.WeatherState!.Value));
                }

                expression ??= x => defaultValue;

                return expression;
            }
        }
    }
}
