namespace System.ComponentModel
{
    internal class KeyEventArgs
    {
        private Action<object, Windows.Forms.KeyEventArgs> detectorTeclas_DoWork;

        public KeyEventArgs(Action<object, Windows.Forms.KeyEventArgs> detectorTeclas_DoWork)
        {
            this.detectorTeclas_DoWork = detectorTeclas_DoWork;
        }
    }
}