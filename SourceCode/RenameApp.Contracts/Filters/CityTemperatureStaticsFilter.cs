using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations;
using RenameApp.Common;

namespace RenameApp.Contracts
{
    public partial class CityTemperatureStatics
    {
        public class CityTemperatureStaticsQueryModel
        {
            public WeatherForecast WeatherForecast { get; set; }
        }

        public class DateFilter
        {
            public DateOnly? BeginDate { get; set; }

            public DateOnly? EndDate { get; set; }

            public Expression<Func<CityTemperatureStaticsQueryModel, bool>> ToExpression(
                bool defaultValue = false)
            {
                Expression<Func<CityTemperatureStaticsQueryModel, bool>>? expression = null;

                if (this.BeginDate.HasValue)
                {
                    expression = expression.And(x => x.WeatherForecast.DateTime >= this.BeginDate);
                }

                if (this.EndDate.HasValue)
                {
                    expression = expression.And(x => x.WeatherForecast.DateTime <= this.EndDate);
                }

                expression ??= x => defaultValue;

                return expression;
            }
        }
    }
}
