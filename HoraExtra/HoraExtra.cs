using System;


namespace HoraExtra
{
    internal class HoraExtra
    {
        public TimeSpan[] escalaTrabalho { get; set; }
        public TimeSpan[] escalaAutorizada { get; set; }
        public TimeSpan[] horarioFeito { get; set; }

        public HoraExtra() { }

        public HoraExtra(TimeSpan[] escalaTrabalho, TimeSpan[] escalaAutorizada, TimeSpan[] horarioFeito)
        {
            this.escalaTrabalho = escalaTrabalho;
            this.escalaAutorizada = escalaAutorizada;
            this.horarioFeito = horarioFeito;
        }

        public TimeSpan CalculaHoraExtra()
        {
            TimeSpan horaExtra = TimeSpan.Zero;
            if (horarioFeito[0] > escalaAutorizada[0] && horarioFeito[0] < escalaTrabalho[0])
            {
                horaExtra += escalaTrabalho[0].Subtract(horarioFeito[0]);
            }
            if (horarioFeito[1] < escalaAutorizada[1] && horarioFeito[1] > escalaTrabalho[1])
            {
                horaExtra += escalaTrabalho[1].Subtract(horarioFeito[1]);
            }
            if (horarioFeito[2] > escalaAutorizada[2] && horarioFeito[2] < escalaTrabalho[2])
            {
                horaExtra += escalaTrabalho[2].Subtract(horarioFeito[2]);
            }
            if (horarioFeito[3] < escalaAutorizada[3] && horarioFeito[3] > escalaTrabalho[3])
                horaExtra += escalaTrabalho[3].Subtract(horarioFeito[3]);
            return horaExtra;
        }
    }
}
