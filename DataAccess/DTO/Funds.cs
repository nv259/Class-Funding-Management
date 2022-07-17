using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class Funds
    {
        private int funded;
        private float sum_money;
        private DateTime time;

        public int Funded { get { return funded; } set { funded = value; } }
        public DateTime Time { get { return time; } set { time = value; } }
        public float Sum_money { get { return sum_money; } set { sum_money = value; } }
    }
}
