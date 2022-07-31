using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contact_tracing
{
    internal class JSON
    {
        public string date { get; set; }
        public string time { get; set; }
        public string platformOrLocation { get; set; }
        public string teamName { get; set; }
        public string calledBy { get; set; }
        public string type { get; set; }
        public string facilitator { get; set; }
        public string noteTaker{ get; set; }
        public string timekeeper { get; set; }
        public string attendees { get; set; }
        public string pleaseRead { get; set; }
        public string pleaseBring { get; set; }
        public string agendaItem { get; set; }
        public string presenter { get; set; }
        public string actionItem1 { get; set; }
        public string actionItem2 { get; set; }
        public string actionItem3 { get; set; }
        public string personResponsible1 { get; set; }
        public string personResponsible2 { get; set; }
        public string personResponsible3 { get; set; }
        public string deadline1 { get; set; }
        public string deadline2 { get; set; }
        public string deadline3 { get; set; }
        public string conclusion1 { get; set; }
        public string conclusion2 { get; set; }
        public string conclusion3 { get; set; }
        public string observers { get; set; }
        public string resources { get; set; }
        public string specialNotes { get; set; }

    }
}
