using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pralka
{
    public class Pralka   //// TEST GITHUB 
    {


        private string _model;
        private bool _zasilanie;      
        private bool _wlacznik;
        private string _proszek;
        private string _programPranie;




        public Pralka()
        {
            _model = "Whirlpool";
            _zasilanie = false;
            _wlacznik = false;
            _proszek = "";
            _programPranie = "";



        }

        public Pralka(bool zasilanie, bool wlacznik, string proszek)
        {

            _zasilanie = zasilanie;
            _wlacznik = wlacznik;
            _proszek = proszek;
           
        }


        public void WlaczPralke()
        {
            if(_zasilanie)
            {
                _wlacznik = true;
            }
        }

        public void WylaczPralke()
        {
            if(_proszek=="" && _programPranie=="")
            {
                _wlacznik = false;
            }
        }

        public void PodlaczDoProdu()
        {
            _zasilanie = true;
        }

        public void OdlaczOdPradu()
        {
            _wlacznik = false;
            _programPranie = "";
            _proszek = "";
            _zasilanie = false;
        }

        public void UruchomProgram(string nazwaProgramu)
        {
            _programPranie = nazwaProgramu;
            if(_wlacznik && _zasilanie && _proszek!="" )
            {
                Console.WriteLine("Napełnianie wodą");
                Console.WriteLine("Pranie z programem "+_programPranie);
                Console.WriteLine("Płukanie");
                Console.WriteLine("Wirowanie");
                Console.WriteLine("Wypompowanie wody");
                Console.WriteLine("Koniec");
                _proszek = "";
              //  _programPranie = "";
            }
            else
            {
                if (!_wlacznik) Console.WriteLine("Nie włączyłeś pralki");
                if (!_zasilanie) Console.WriteLine("Nie podłączona do prądu");
                if (_proszek == "") Console.WriteLine("Uzupełnij proszek");
                if (_programPranie == "") Console.WriteLine("Ustaw program");
            }
        }

        public void WsypProszek(string proszek)
        {
            _proszek = proszek;
        }
  

    }

}
