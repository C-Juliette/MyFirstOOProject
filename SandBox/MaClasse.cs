namespace SandBox
{
    public class MaClasse
    {
        #region attributes

        private string _tata;

        #endregion

        #region Properties (getters & setters)

        public string GetTata()
        {
            return _tata;
        }

        public void SetTata(string tata)
        {
            _tata = tata;
        }

        #endregion

        #region Constructors

        public MaClasse()
        {
        }
        
        public MaClasse(string parametre)
        {
            _tata = parametre;
        }

        #endregion

        #region Methods

        public void DoubleWord()
        {
            _tata += _tata;
        }

        #endregion
    }
}