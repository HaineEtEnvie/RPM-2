// https://docs.google.com/document/d/1KZXfKJussGflgWnWylGbFrwmdcn3liYKIsgmtxB1mN0/edit
namespace ClassLibrary1
{
    public class Zaniatie
    {
        private readonly Discyplina discyplina;
        public Discyplina Discyplina { get => discyplina; }

        private readonly Sotrydnik sotrydnik;
        public Sotrydnik Sotrydnik { get => sotrydnik; }

        private readonly Ayditoria ayditoria;
        public Ayditoria Ayditoria { get => ayditoria; }

        private readonly Gryppa gryppa;
        public Gryppa Gryppa { get => gryppa; }

        private readonly Para para;
        public Para Para { get => para; }

        private readonly VidZanyatiya vidZanyatiya;
        public VidZanyatiya VidZanyatiya { get => vidZanyatiya; }

        public Zaniatie(Discyplina discyplina, Sotrydnik sotrydnik,Ayditoria ayditoria, Gryppa gryppa,  Para para, VidZanyatiya vidZanyatiya)
        {
            this.discyplina = discyplina;
            this.sotrydnik = sotrydnik;
            this.ayditoria = ayditoria;
            this.gryppa = gryppa;
            this.para = para;
            this.vidZanyatiya = vidZanyatiya;
        }
    }
}
