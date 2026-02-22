using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ModelSzpitala
{
    public class AuditWpis
    {

        private int? _userId;
        private Akcja _rodzajAkcji;
        private DateTime _data;
        private bool sukces;

        [JsonConstructor]
        public AuditWpis() 
        {
        
        }

        public AuditWpis(int? userId, Akcja rodzajAkcji, DateTime data, bool sukces)
        {
            _userId = userId;
            _rodzajAkcji = rodzajAkcji;
            _data = data;
            this.sukces = sukces;
        }

        public int? UserId
        {
            get
            {
                return _userId;
            }
        }

        public Akcja RodzajAkcji
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

        public bool Sukces
        {
            get
            {
                return sukces;
            }
        }
    }
}
