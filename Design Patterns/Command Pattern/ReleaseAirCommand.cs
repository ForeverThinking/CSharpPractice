namespace command_pattern
{
    /// <summary>
    /// Command class to increase depth by releasing air from ballast
    /// </summary>
    public class ReleaseAirCommand : IDepthCommand
    {
        private ISubmersible _submersible;

        public ReleaseAirCommand(ISubmersible submersible)
        {
            this._submersible = submersible;
        }

        public void ChangeDepth()
        {
            _submersible.Dive();
        }
    }
}