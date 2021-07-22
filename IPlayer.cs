namespace LSP_Illustration
{
    interface IPlayer
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        bool NeedsOut { get; set; }

        void ShouldPlay(int fouls, int minutesPlayed);
        void Substitution(IPlayer teammate);
    }
}