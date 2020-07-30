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
            Ajegeg.Add("전투기 조종사들이 제일 무서워하는 것은?", "대공포");
            Ajegeg.Add("세발낙지가 탈모가 오면?", "한발낙지");
            Ajegeg.Add("토끼가 강한 이유는?", "깡과 총이 있어서");
            Ajegeg.Add("개가 재채기를 하면?", "개추");
            Ajegeg.Add("흡혈귀들이 식탁에서 웃음이 끊이질 않는 이유는? (~~해서)", "피식해서");
            Ajegeg.Add("스님이 택시를 타고 한 말은?", "절로가");
            Ajegeg.Add("국내에 마블보다 4배 큰 기업은?", "넷마블");
            Ajegeg.Add("오리가 옳다고 인정하면?", "덕수긍");
            Ajegeg.Add("바람의 엉덩이를 부르는 말은?", "풍뎅이");
            Ajegeg.Add("고양이한테 '야옹'이라고 하면 뭐라고 답할까?", "왜옹");
            Ajegeg.Add("시험 끝나면 친구들끼리 회식하는 곤충은?", "반딧불이");
            Ajegeg.Add("개들이 제일 싫어하는 절은?", "보신각");
            Ajegeg.Add("털이 길게 자란 남자를 4글자로? ", "모자란 놈|모자란놈");
            Ajegeg.Add("파워포인트가 목이 없으면?", "제 목을 입력해주세요|제목을 입력해주세요|제목을입력해주세요");
            Ajegeg.Add("성시경을 먹으면?", "위장내 시경|위장내시경");
            Ajegeg.Add("귀걸이 한 군인은?", "귀뚫아미|귀뚜라미");
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
