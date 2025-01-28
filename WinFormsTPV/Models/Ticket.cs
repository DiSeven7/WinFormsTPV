using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTPV.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public Ticket() { }

        public Ticket(DateTime fecha, int id = -1)
        {
            if (id != -1) { Id = id; };
            Fecha = fecha;
        }
    }
}
