using System;

namespace HoraExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            TimeSpan horaInicial = new TimeSpan(10, 30, 00);
            TimeSpan horaFinal = new TimeSpan(12, 45, 00);

            TimeSpan diferenca = horaFinal.Subtract(horaInicial);
            Console.WriteLine(diferenca);
            */

            TimeSpan[] escalaTrabalho = new TimeSpan[4];
            escalaTrabalho[0] = new TimeSpan(08, 00, 00);
            escalaTrabalho[1] = new TimeSpan(12, 00, 00);
            escalaTrabalho[2] = new TimeSpan(13, 30, 00);
            escalaTrabalho[3] = new TimeSpan(17, 30, 00);

            TimeSpan[] escalaAutorizada = new TimeSpan[4];
            escalaAutorizada[0] = new TimeSpan(07, 00, 00);
            escalaAutorizada[1] = new TimeSpan(12, 00, 00);
            escalaAutorizada[2] = new TimeSpan(13, 30, 00);
            escalaAutorizada[3] = new TimeSpan(17, 30, 00);

            TimeSpan[] horarioFeito = new TimeSpan[4];
            horarioFeito[0] = new TimeSpan(07, 45, 00);
            horarioFeito[1] = new TimeSpan(12, 00, 00);
            horarioFeito[2] = new TimeSpan(12, 30, 00);
            horarioFeito[3] = new TimeSpan(17, 30, 00);

            HoraExtra horaExtra = new HoraExtra(escalaTrabalho, escalaAutorizada, horarioFeito);
            Console.WriteLine(horaExtra.CalculaHoraExtra());
        }
    }
}
