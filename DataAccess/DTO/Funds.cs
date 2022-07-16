using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class Funds
    {
        private int april, may, june, july, charge;
        private float sum_money;
        private DateTime time;

        public int April { get { return april; } set { april = value; } }
        public int May { get { return may; } set { may = value; } }
        public int June { get { return june; } set { june = value; } }
        public int July { get { return july; } set { july = value; } }
        public int Charge { get { return charge; } set { charge = value; } }
        public DateTime Time { get { return time; } set { time = value; } }
        public float Sum_money { get { return sum_money; } set { sum_money = value; } }
    }
}
