namespace IocContainer
{
    public class MyGenesisTape : ITapeCassette
    {
        #region ITapeCassette Members

        public string Artist
        {
            get { return "Genesis"; }
        }

        public string Album
        {
            get { return "Selling England by the Pound"; }
        }

        #endregion
    }
}