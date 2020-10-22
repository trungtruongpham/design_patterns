namespace state_pattern
{
    public abstract class State
    {
        public string Name { get; set; }
        public abstract void HandleRequest();
        public string GetState()
        {
            return this.Name;
        }
    }
}