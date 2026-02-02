using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSzpitala
{
    public class AuditWpis
    {

        private int _userId;
        private Akcja _rodzajAkcji;
        private DateTime _data;

        public AuditWpis(int userId, Akcja rodzajAkcji, DateTime data)
        {
            _userId = userId;
            _rodzajAkcji = rodzajAkcji;
            _data = data;

        }

        public int DostepDoUserId
        {
            get
            {
                return _userId;
            }
        }

        public Akcja DostepDoRodzajAkcji
        {
            get
            {
                return _rodzajAkcji;
            }
        }

        public DateTime Data
        {
            get
            {
                return _data;
            }
        }
    }
}
