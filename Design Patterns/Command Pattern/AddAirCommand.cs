namespace command_pattern
{
    /// <summary>
    /// Command class to decrease depth by adding air into ballast
    /// </summary>
    public class AddAirCommand : IDepthCommand
    {
        private ISubmersible _submersible;

        public AddAirCommand(ISubmersible submersible)
        {
            this._submersible = submersible;
        }

        public void ChangeDepth()
        {
            _submersible.Ascend();
        }
    }
}