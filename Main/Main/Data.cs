using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Data 
    {
        // 아재개그 모음
        public Dictionary<string, string> Ajegag = new Dictionary<string, string>();


        public Data()
        {
            Reset();
        }

        // 리셋 함수
        public void Reset()
        {
            Ajegag.Add("소금의 유통기한은 몇일일까?", "천일");
            Ajegag.Add("미소의 반댓말은?", "당기소");
            Ajegag.Add("만나면 싸움만 하는 나라는?", "칠레");
            Ajegag.Add("술이 들깰려면 어떤 음식을 먹어야할까?", "들깨");
            Ajegag.Add("세상에서 제일 잘생긴 가위는?", "핸썸가이|핸섬가이|핸썸가위|핸섬가위");
            Ajegag.Add("3월에 대학생들이 강한 이유는? (~~해서)", "개강해서");
            Ajegag.Add("쏠로가 참외를 보고 하는 말은? (~~롭구나)", "참외롭구나");
            Ajegag.Add("땅이 우는 소리는?", "흙흙");
            Ajegag.Add("전투기 조종사들이 제일 무서워하는 것은?", "대공포");
            Ajegag.Add("세발낙지가 탈모가 오면?", "한발낙지");
            Ajegag.Add("토끼가 강한 이유는? (~과~이 있어서)", "깡과 총이 있어서|깡과총이있어서|깡,총|총과 깡이 있어서|총과깡이있어서|총, 깡|깡, 총|총,깡|깡,총");
            Ajegag.Add("개가 재채기를 하면?", "개추");
            Ajegag.Add("흡혈귀들이 식탁에서 웃음이 끊이질 않는 이유는? (~~해서)", "피식해서");
            Ajegag.Add("스님이 택시를 타고 한 말은?", "절로가");
            Ajegag.Add("국내에 마블보다 4배 큰 기업은?", "넷마블");
            Ajegag.Add("오리가 옳다고 인정하면?", "덕수긍");
            Ajegag.Add("바람의 엉덩이를 부르는 말은?", "풍뎅이");
            Ajegag.Add("고양이한테 '야옹'이라고 하면 뭐라고 답할까?", "왜옹");
            Ajegag.Add("시험 끝나면 친구들끼리 회식하는 곤충은?", "반딧불이");
            Ajegag.Add("개들이 제일 싫어하는 절은?", "보신각");
            Ajegag.Add("털이 길게 자란 남자를 4글자로? ", "모자란놈|모자란 놈");
            Ajegag.Add("파워포인트가 목이 없으면?", "제목을입력해주세요|제 목을 입력해주세요|제목을 입력해주세요");
            Ajegag.Add("성시경을 먹으면?", "위장내시경|위장내 시경");
            Ajegag.Add("귀걸이 한 군인은?", "귀뚫아미|귀뚜라미");
            Ajegag.Add("노인을 묶으면?", "타이틀");
            Ajegag.Add("자동차가 죽으면 묻히는 무덤은?", "부르릉");
            Ajegag.Add("설거지할 때 그릇을 돌리면서 씻으면?", "워싱턴디쉬|워싱 턴 디쉬");
            Ajegag.Add("언론통제를 다른 말로 하면?", "보도블럭");
            Ajegag.Add("센 척하는 애들이 활동하는 갤러리는?", "가오갤|가디언즈오브갤럭시|가디언즈 오브 갤럭시");
            Ajegag.Add("가장 '정의로운' 달은?", "10|10월|악토벌");
            Ajegag.Add("세상에서 가장 잘 속는 음식은?", "소금");
            Ajegag.Add("퉁퉁이 엄마의 이름은?", "모퉁이");
            Ajegag.Add("닭에게 사이즈가 작은 옷을 입히면?", "꼭끼오|꼭기오|곡끼오");
            Ajegag.Add("감옥을 돌로 지으면 안 되는 이유는? (~~되니까)", "석방|석방되니까");
            Ajegag.Add("히어로들의 뼈는 무슨 색일까? (~~색)", "영웅본색|영웅 bone색|영웅bone색|영웅 본색");
        }

        public void Problem(ref string key, ref string value)
        {
            Random rand = new Random();

            int num = rand.Next(0, Ajegag.Count); // 랜덤으로 아재개그 하나 뽑기
            key = Ajegag.ElementAt(num).Key;

            value = Ajegag[key];
        }


    }
}
