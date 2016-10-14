namespace ProxyPattern.PersonBean
{
    public class PersonBeanImpl : IPersonBean
    {
        private int _rating;
        private int _ratingCount;

        public PersonBeanImpl()
        {
            _ratingCount = 0;
        }

        public string Name { get; set; }
        public string Gender { get; set; }
        public string Interests { get; set; }
        public int GetHotOrNotRating()
        {
            if (_ratingCount == 0) return 0;
            return _rating / _ratingCount;
        }

        public void SetHotOrNotRating(int rating)
        {
            _rating += rating;
            _ratingCount++; 
        }
    }
}
