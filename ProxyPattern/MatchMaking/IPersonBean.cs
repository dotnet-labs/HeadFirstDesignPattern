namespace ProxyPattern.MatchMaking
{
    public interface IPersonBean
    {
        string Name { get; set; }
        string Gender { get; set; }
        string Interests { get; set; }

        int GetHotOrNotRating();
        void SetHotOrNotRating(int rating);
    }
}
