namespace state_pattern
{
    public class Document
    {
        private State _state;

        public void SetState(State state)
        {
            this._state = state;
        }

        public void ApplyState()
        {
            this._state.HandleRequest();
        }
    }
}