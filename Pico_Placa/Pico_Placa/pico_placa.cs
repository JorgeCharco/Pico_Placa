using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pico_Placa
{
    class pico_placa
    {
        private string placa;        
        private string fecha;
        private string hora;

        private DateTime dia_DT;
        private DateTime hora_DT;
        
        public pico_placa(string placa, String fecha, String hora)
        {
            this.placa = placa;
            this.fecha = fecha;
            this.hora = hora;
        }

        public bool verificarDatosPlaca()
        {
            //*************************************************************************
            //Se verifica la cantidad de carácteres que conforman la placa del vehículo
            //*************************************************************************
            if (this.placa.Length >= 6)
            {
                return true; //return true si cumple con la longitud mínimas de la placa
            }
            else
            {
                return false; //return false cuando no cumple con la longitud de la placa
            }
        }


        public bool verificarFechaHora()
        {
            //******************************************************************
            //Se verifica que haga el parse de string a date de forma correcta
            //******************************************************************            
            if (DateTime.TryParseExact(this.fecha,"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out dia_DT))
            {                
                if (!(DateTime.TryParseExact(this.hora, "HH:mm", null, System.Globalization.DateTimeStyles.None, out hora_DT)))
                {
                    return false; // cuando la hora no tiene el formato adecuado hh:mm
                }
                
                return true; // Cuando la hora está escrita correctamente hh:mm
                
            }
            else
            {
                return false; // cuando la fecha no tiene formato adecuado dd/MM/yyyy
            }
            
        }

        public bool verificarRoad()
        {
            string dia = this.dia_DT.DayOfWeek.ToString();
            byte ultimo_digito_placa =  byte.Parse(this.placa.Substring(this.placa.Length - 1, 1));

            if (dia == "Monday" && (ultimo_digito_placa == 1 || ultimo_digito_placa == 2))
            {
                return horarioDisponible();
            }

            if (dia == "Tuesday" && (ultimo_digito_placa == 3 || ultimo_digito_placa == 4))
            {
                return horarioDisponible();
            }

            if (dia == "Wednesday" && (ultimo_digito_placa == 5 || ultimo_digito_placa == 6))
            {
                return horarioDisponible();
            }

            if (dia == "Thursday" && (ultimo_digito_placa == 7 || ultimo_digito_placa == 8))
            {
                return horarioDisponible();
            }

            if (dia == "Friday" && (ultimo_digito_placa == 9 || ultimo_digito_placa == 0))
            {
                return horarioDisponible();
            }

            return true;
        }

        public bool horarioDisponible()
        {
            Int32 horaUsuario = Convert.ToInt32(hora_DT.ToString("HHmm"));
            Int32 horaLimiteM1 = Convert.ToInt32(Convert.ToDateTime("07:00").ToString("HHmm"));
            Int32 horaLimiteM2 = Convert.ToInt32(Convert.ToDateTime("09:30").ToString("HHmm"));
            Int32 horaLimiteT1 = Convert.ToInt32(Convert.ToDateTime("16:00").ToString("HHmm"));
            Int32 horaLimiteT2 = Convert.ToInt32(Convert.ToDateTime("19:30").ToString("HHmm"));
             
            if (horaUsuario>=horaLimiteM1 && horaUsuario<=horaLimiteM2  || horaUsuario>=horaLimiteT1 && horaUsuario <= horaLimiteT2)
            {
                return false; // no puede circular en el horario escogido por el usuario.
            }
            return true;
        }

    }
}
