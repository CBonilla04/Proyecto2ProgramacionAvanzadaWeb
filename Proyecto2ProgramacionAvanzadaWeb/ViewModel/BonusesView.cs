using Proyecto2ProgramacionAvanzadaWeb.Models;

namespace Proyecto2ProgramacionAvanzadaWeb.ViewModel
{
    public class BonusesView
    {
        public BonusesView(List<Bonuses> _BonusesAssigned, List<Bonuses> _BonusesAvailable)
        {

            BonusesAssigned = _BonusesAssigned;
            BonusesAvailable = _BonusesAvailable;
        }
        public List<Bonuses> BonusesAssigned { get; set; }
        public List<Bonuses> BonusesAvailable { get; set; }
    }
}
