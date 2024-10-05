namespace RenameApp.Controllers
{
    [AttributeUsage(
        AttributeTargets.Class | AttributeTargets.Method,
        AllowMultiple = false,
        Inherited = true)]
    public class EntityValidationAttribute : Attribute
    {

    }
}
