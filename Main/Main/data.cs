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
            Ajegeg.Add("만나면 싸움만 하는 나라는?", "칠레");
            Ajegeg.Add("술이 들깰려면 어떤 음식을 먹어야할까?", "들깨");
            Ajegeg.Add("세상에서 제일 잘생긴 가위는?", "핸썸가이|핸섬가이|핸썸가위|핸섬가위");
            Ajegeg.Add("3월에 대학생들이 강한 이유는? (~~해서)", "개강해서");
            Ajegeg.Add("쏠로가 참외를 보고 하는 말은? (~~롭구나)", "참외롭구나");
            Ajegeg.Add("땅이 우는 소리는?", "흙흙");
        }

        public void Problem(ref string key, ref string value)
        {
            Random rand = new Random();

            int num = rand.Next(0, Ajegeg.Count);
            key = Ajegeg.ElementAt(num).Key;



            value = Ajegeg[key];

        }
    }
}
