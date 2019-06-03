namespace PluginsEditorEnvironment
{
    public interface IValidator<T>
    {
        bool Validate(T validatableObject, out string error);
    }
}
