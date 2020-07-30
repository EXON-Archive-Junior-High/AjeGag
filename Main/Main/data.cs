using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Data
    {
        public Dictionary<string, string> Ajegeg = new Dictionary<string, string>();

        public Data()
        {
            Reset();
        }
        public void Reset()
        {
            Ajegeg.Add("소금의 유통기한은 몇일일까?", "천일");
            Ajegeg.Add("미소의 반댓말은?", "당기소");

        }

        public string Problem()
        {
            Random rand = new Random();
            return Ajegeg.ElementAt(rand.Next(0, Ajegeg.Count)).Key;
        }
    }
}
