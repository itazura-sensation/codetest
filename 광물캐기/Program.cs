using System;
using System.Collections.Generic;

namespace 광물캐기
{
    public class Solution
    {
        public int solution(int[] picks, string[] minerals)
        {
            Console.WriteLine("start");
            int answer = 0;
            List<int> list = new List<int>();
            //int power = 0;
            int dia =picks[0];
            int iron = picks[1];
            int stone = picks[2];
           // minerals.IsFixedSize();
            Console.WriteLine(minerals.Length);
            for (int i = 0; i < minerals.Length; i+=5)
            {
                int minepoint = 0;
                //예외문 하나 만들어주기 ex) i+5까지 고려하기
                if (i + 5 > minerals.Length) 
                {
                    //예외문 작성
                    for (int k = i; k < minerals.Length; k++) 
                    {
                        switch (minerals[k])
                        {
                            case "diamond":
                                minepoint += 100;
                                break;
                            case "iron":
                                minepoint += 10;
                                break;
                            case "stone":
                                minepoint += 1;
                                break;
                        }
                    }
                    list.Add(minepoint);
                    break;
                }
                
                for (int j = i; j < i + 5; j++) 
                {
                    
                    switch (minerals[j])
                    {
                        case "diamond":
                            minepoint += 100;
                            break;
                        case "iron":
                            minepoint += 10;
                            break;
                        case "stone":
                            minepoint += 1;
                            break;
                    }

                }
                list.Add(minepoint);
            }
            Console.WriteLine(list.Count);
            list.Sort((a, b) => b.CompareTo(a));
            
                for (int i = 0; i < dia; i++) //다이아 곡괭이 작업
                {
                    int a = 1;//다이아 캘떄
                    int b = 1;//철 캘떄 
                    int c = 1;//아이언 캘떄
                    answer += list[0] / 100 * a;
                    answer += (list[0] % 100) / 10 * b;
                    answer += (list[0] % 10) / 1 * c;
                    list.RemoveAt(0);
                    if (list.Count <= 0) 
                    { return answer; }
                }
                for (int i = 0; i < iron; i++) //철 곡괭이 작업
                {
                    int a = 5;//다이아 캘떄 드는 피로도 위에서부터 
                    int b = 1;//철 캘떄 
                    int c = 1;//아이언 캘떄
                    answer += list[0] / 100 * a;
                    answer += (list[0] % 100) / 10 * b;
                    answer += (list[0] % 10) / 1 * c;
                    list.RemoveAt(0);
                    if (list.Count <= 0)
                    { return answer; }
                }
                for (int i = 0; i < stone; i++) //돌 곡괭이 작업
                {
                    int a = 25;//다이아 캘떄
                    int b = 5;//철 캘떄 
                    int c = 1;//아이언 캘떄
                    answer += list[0] / 100 * a;
                    answer += (list[0] % 100) / 10 * b;
                    answer += (list[0] % 10) / 1 * c;
                    list.RemoveAt(0);
                    if (list.Count <= 0)
                    { return answer; }
                }
            return answer;
        }
        static void Main(string[] args)
        {
            int finsih = 0;
            Solution a = new Solution();
            int[] pick = { 0, 1, 1 };
            string[] minerals = { "diamond", "diamond", "diamond", "diamond", "diamond", "iron", "iron", "iron", "iron", "iron", "diamond" };
            finsih = a.solution(pick, minerals);
            Console.WriteLine(finsih);
        }
    }
}   
