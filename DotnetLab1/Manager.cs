namespace DotNetLab1
{
    public class Manager : Employee
    {
        /// <summary>
        /// Am ales virtual pentru a putea specifica valoare default in clasa de baza si
        /// la nevoie pentru a putea inlocui formula de salut intr-o clasa ce extinde, mosteneste
        /// clasa base pentru ca formula de salut sa fie mai specifica, mai precisa.
        /// Se putea si abstract in employee dar nu mai beneficiam de posibiltiatea de
        /// a specifica valoare default => nu mai puteam instantia Employee.
        /// </summary>
        public override string Salutation => "Hello manager";
    }
}
