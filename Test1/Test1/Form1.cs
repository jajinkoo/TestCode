using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // c# 6.0기능
        {/*
            ///1. ? 연산자 null 문자인지 확인하고 초기화 시키는명령어 
            // int? cnt = 객체?.Count; // 카운트 객체가 null인제 체크 null 이면 cnt도 null로 된다. 

            //. ?? 연산자
            // int[] row = { 1,2,3};
            // int ncnt = row[0]?.Count ?? 0; 


            //2. 문자열 내샵 기능  (이건 유용한듯)
            //$기능으로 string.format({0}) 이런식의 포맷 생략 시킬수 있다. 
            Rectangle r = new Rectangle();
            r.Height = 100;
            r.Width = 100;

            string str = $"{r.Height} * {r.Width} = {(r.Height * r.Width)}";

            string str1 = string.Format("{0}*{1} = ({2})", r.Height, r.Width, r.Height * r.Width);

            //3. Dictionary 초기화 방법 
            //기존 
            var scores = new Dictionary<string, int>()
            {
                { "kim", 100},
                { "lee", 90}
            };
            int sc = scores["lee"];

            //#6.0방법 
            var scores2 = new Dictionary<string, int>()
            {
                ["kim"] = 100,
                ["lee"] = 90
            };
            int sc2 = scores2["lee"];
            */

            var A = new[]{ 1, 2, 3 };

            var L = new List<int>(A){ [2] = 9};

        }
    }
}
