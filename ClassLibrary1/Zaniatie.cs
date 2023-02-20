namespace ClassLibrary1
{
    public class Zaniatie
    {
        private readonly Ayditoria ayditoria; // 2 вариант - аудитория
        public Ayditoria Ayditoria { get => ayditoria; }// 2 вариант - аудитория

        private readonly Discyplina discyplina;// 3 вариант - дисциплина
        public Discyplina Discyplina { get => discyplina; }// 3 вариант - дисциплина

        private readonly VidZanyatiya vidZanyatiya;// 14 вариант - вид занятия
        public VidZanyatiya VidZanyatiya { get => vidZanyatiya; }// 14 вариант - вид занятия

        public Zaniatie(Ayditoria ayditoria,Discyplina discyplina, VidZanyatiya vidZanyatiya)
        {
            this.ayditoria = ayditoria;
            this.discyplina = discyplina;
            this.vidZanyatiya = vidZanyatiya;
        }
    }
}
