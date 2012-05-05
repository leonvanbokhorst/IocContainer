namespace IocContainer
{
    public class SonyWalkman
    {
        private readonly ITapeCassette _tapeCassette;

        public SonyWalkman(ITapeCassette tapeCassette)
        {
            _tapeCassette = tapeCassette;
        }

        public string Play()
        {
            return string.Format("Now Playing {0} - {1}",
                                 _tapeCassette.Artist,
                                 _tapeCassette.Album);
        }
    }
}