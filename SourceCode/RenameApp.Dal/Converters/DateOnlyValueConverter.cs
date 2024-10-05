using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RenameApp.Dal
{
    public class DateOnlyValueConverter : ValueConverter<DateOnly, DateTime>
    {
        public DateOnlyValueConverter() : base(
            dateonly => dateonly.ToDateTime(TimeOnly.MinValue),
            datetime => DateOnly.FromDateTime(datetime))
        {

        }
    }
}
