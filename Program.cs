using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{
    class Program
    {
        /*
         *現在の日時から、今月のカレンダーを画面に
         * 表示するプログラム
         * 
         * */

        static void Main(string[] args)
        {
            DateTime dateNow = DateTime.Now; //現在の日時を取得

            //現在の年月日を表示
            Console.Write("{0}年 {1}月 {2}日\n", dateNow.Year, dateNow.Month,dateNow.Day);

            //現在の年月の一日を取得する
            DateTime dateFirst = DateTime.Parse(string.Format("{0}/{1}/1", dateNow.Year, dateNow.Month));

            DisplayCalender(dateFirst);//カレンダー表示
            Console.ReadLine();
        }

        /*１カ月分のカレンダーを画面に表示
         * パラメータ
         *  dateFirst:表示したい年月の１日を表すDateTime
         */
        static void DisplayCalender(DateTime dateFirst)
        {
            int week;
            int month = dateFirst.Month;

            //曜日タイトルの表示
            Console.Write("-------------------\n");
            Console.Write("日 月 火 水 木 金 土\n");

            //１日の開始位置まで空白を表示
            for (week = 0; week < (int)dateFirst.DayOfWeek; week++)
            {
                Console.Write("   ");
            }


            //月の終わりの日まで１週間ごとに日にちを表示する
            while (month == dateFirst.Month)
            {
                for (; week < 7 && month == dateFirst.Month; week++)
                {
                   Console.Write("{0,2} ", dateFirst.Day);
                    dateFirst = dateFirst.AddDays(1);//翌日にする
                }
                Console.Write("\n");
                week = 0;
            }

        }
    }
}
