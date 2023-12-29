using ZenjectExample.Abstracts.Inputs;
using ZenjectExample.Inputs;

namespace ZenjectExample.Factories
{
    public class InputReaderFactory : IInputReaderFactory
    {
        IInputReader _inputReader;

        public IInputReader Create()
        {
            SwitchInputReader();
            return _inputReader;
        }

        void SwitchInputReader()
        {
            _inputReader = this._inputReader is NewInputReader || _inputReader == null ? 
                new OldInputReader() : 
                new NewInputReader();
        }
    }

    public interface IInputReaderFactory
    {
        IInputReader Create();
    }
}