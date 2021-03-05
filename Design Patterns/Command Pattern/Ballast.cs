namespace command_pattern
{
    /// <summary>
    /// Command invoker to control depth of classes implementing ISubmersible
    /// </summary>
    public class Ballast
    {
        private IDepthCommand _dive;
        private IDepthCommand _ascend;

        public Ballast(IDepthCommand dive, IDepthCommand ascend)
        {
            this._ascend = ascend;
            this._dive = dive;
        }

        public void AddAir()
        {
            _ascend.ChangeDepth();
        }

        public void BlowAir()
        {
            _dive.ChangeDepth();
        }
    }
}