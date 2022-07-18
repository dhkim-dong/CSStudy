using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._04단계
{
    internal class _04_08
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());

            // 변수명을 for반복문을 통해서 만들고 싶다. -> map or (reflection : 클래스 객체를 얻어온다.)

            Dictionary<string, string> mapName = new Dictionary<string, string>();
            Dictionary<string, double> mapTot = new Dictionary<string, double>();
            Dictionary<string, string[]> mapValue = new Dictionary<string, string[]>();
            for (int i = 0; i < N; i++)
            {
                mapName.Add(String.Format("input{0}", i.ToString()), Console.ReadLine());
                mapValue.Add(String.Format("value{0}", i.ToString()), mapName["input" + i].Split());
                mapTot.Add(String.Format("Tot{0}", i.ToString()), 0);

                for (int x = 0; x < int.Parse(mapValue["value" + i][0]); x++)
                {
                    mapTot["Tot" + i] += double.Parse(mapValue["value" + i][x]);
                }               
            }

            string[] results = new string[N];
            
            // 평균을 넘는 학생들의 비율 : 전체 데이터 중 평균보다 많은 데이터 / 전체 인원 수 (배열의 첫 번째)
            // 소수점 3자리 표기법
            for (int i = 0; i < N; i++)
            {
                results[i] = String.Format("{0:0.000}", mapTot["Tot" + i] / int.Parse(mapValue["value" + i][0]));
                sb.Append(results[i] + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
