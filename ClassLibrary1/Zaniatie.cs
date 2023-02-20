namespace ClassLibrary1
{
    public class Zaniatie
    {
        private readonly Ayditoria name2; // 2 вариант - аудитория
        public Ayditoria Name2 { get => name2; }// 2 вариант - аудитория

        private readonly Discyplina name3;// 3 вариант - дисциплина
        public Discyplina Name3 { get => name3; }// 3 вариант - дисциплина

        private readonly VidZanyatiya name14;// 14 вариант - вид занятия
        public VidZanyatiya Name14 { get => name14; }// 14 вариант - вид занятия

        public Zaniatie(Ayditoria name2,Discyplina name3, VidZanyatiya name14)
        {
            this.name2 = name2;
            this.name3 = name3;
            this.name14 = name14;
        }
    }
}
