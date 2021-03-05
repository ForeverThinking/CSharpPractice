namespace command_pattern
{
    /// <summary>
    /// Interface for any submersible object
    /// </summary>
    public interface ISubmersible
    {
        void Dive();

        void Ascend();
    }
}