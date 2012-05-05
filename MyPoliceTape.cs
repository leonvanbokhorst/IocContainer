namespace IocContainer
{
    public class MyPoliceTape : ITapeCassette
    {
        #region ITapeCassette Members

        public string Artist
        {
            get { return "The Police"; }
        }

        public string Album
        {
            get { return "Outlandos d'amour"; }
        }

        #endregion
    }
}