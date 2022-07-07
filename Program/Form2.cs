using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Program;
using System.Runtime.InteropServices;

namespace Program
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        string UserName = Environment.UserName; //UserName에 Window 사용자 계정 이름 저장

        bool Ispass(char ch)    //학과의 끝이 '부' 또는 '과'인지 판별 메서드
        {
            if ((ch == 0XACFC) || (ch == 0XBD80))
                return true;
            else
                return false;
        }

        public Form2()
        {
            InitializeComponent();

            //가장 앞으로 배치
            TopMost = true;

            //현재 시간을 labtime에 표시하기 위해 timer1 가동
            timer1.Start();
        }



        private void metroButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.labtime.Text = datetime.ToString("yyyy/MM/dd/ HH:mm");
        }

        private void btnagree_Click(object sender, EventArgs e)
        {  
            //현재 시간 출력
            DateTime datetime = DateTime.Now;
            this.labtime.Text = datetime.ToString("yyyy/MM/dd/ HH:mm:ss");

            bool check_department = false;

            //DB Sever 정보 및 SQL
            string conncetstring = string.Format("Server = {0}; Port = {1}; Database = {2}; Uid = {3}; Pwd = {4}", "203.241.227.164", "0415", UserName, "root", "1683");
            string insert_sql = "INSERT INTO test(Department, Name, Stud_num, Start_time, Using_purpose)" + "VALUES('" + this.txtdepart.Text + "','" + this.txtname.Text + "','" + this.txtstdnum.Text + "','" + this.labtime.Text + "','" + this.txtpurpose.Text + "');";

            string[] dp = new string[]
            {
                "의용공학부", "의용공학과", "의예과", "의학과", "간호학과", "간호학과", "국제어문학부", "인문문화학부", "음악학과", "사회과학대학",
                "공공인재학부", "보건행정학과", "사회복지학과", "상담심리치료학과", "미디어커뮤니케이션학과", "유아교육과",
                "특수교육과", "스포츠헬스케어학과", "소비자가족학과", "국제경상학부", "경영통상학과", "경영대학", "경영학부",
                "경영학과", "경제통상학과", "토목도시환경공학부", "건설환경공학부", "건축학과", "산업경영공학과", "전자IT기계자동차공학부",
                "미래에너지공학과", "디자인엔지니어링학과", "실내건축학과", "멀티미디어학부", "실내디자인과", "시각디자인과", "제품디자인과",
                "영상디자인과", "환경공학과", "토목도시공학부", "컴퓨터공학과", "드론IoT시뮬레이션학부", "통계학과", "물리치료학과", "보건안전공학과",
                "의공학부",  "임상병리학과", "작업치료학과", "보건관리학과", "산업안전보건학과", "임상병리학과",
                "나노융합공학부", "제약공학과", "식품생명과학부", "식품영양식품공학부", "헬스케어IT학과", "헬스케어IT공학과", "바이오테크놀로지학부",
                "바이오테크놀로지학과", "의생명화학과학과"
            };

            for(int i = 0; i < dp.Length; i++)
            {
                if(this.txtdepart.Text == dp[i])
                {
                    check_department = true;
                    break;
                }
            }

            bool check_stdnum = false;

            string studentnum = this.txtstdnum.Text;
            char[] number = studentnum.ToCharArray();

            if (number[0] == '1' || number[0] == '2')
                check_stdnum = true;

            string department = this.txtdepart.Text;
            char[] ch = department.ToCharArray();
            int counting = 0;

            string std_number = this.txtstdnum.Text;
            int check = 0;
            bool chk = int.TryParse(std_number, out check);
            
            string name = this.txtname.Text;
            char[] char_name = name.ToCharArray();
            int count = 0;

            for(int i = 0; i < name.Length; i++)
            {
                if ((char_name[i] >= 0XAC00) && (char_name[i] <= 0XD79F))
                    count++;
            }
            
            for(int i = 0; i < department.Length; i++)
            {
                if ((ch[i] >= 0XAC00) && (ch[i] <= 0XD79F))
                    counting++;
            }     

            //동의 버튼 클릭 시 DB Sever로 입력 정보 자동 송신
            if (this.txtdepart.Text == "")
                MessageBox.Show("사용자 정보를 올바르게 입력해주세요.", "Error", MessageBoxButtons.OK);

            else
            {
                if ((Ispass(ch[(this.txtdepart.Text.Length - 1)]) == true))  //학과 판별
                {
                    if (check_department == true)
                    {
                        if ((chk == true) && (this.txtstdnum.Text.Length == 8) && check_stdnum == true)    //학번 숫자 여부 판별
                        {
                            if ((name.Length == count) && (name.Length <= 5) && (name.Length >= 2))
                            {
                                if (department.Length == counting)
                                {
                                    using (MySqlConnection conn = new MySqlConnection(conncetstring))
                                    {
                                        conn.Open();
                                        MySqlCommand cmd = new MySqlCommand(insert_sql, conn);
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                    }
                                    Application.Exit();
                                }
                                else
                                    MessageBox.Show("학과를 올바르게 입력해주세요.", "Error", MessageBoxButtons.OK);
                            }
                            else
                                MessageBox.Show("이름을 올바르게 입력해주세요.", "Error", MessageBoxButtons.OK);
                        }
                        else
                            MessageBox.Show("학번을 올바르게 입력해 주세요.", "Error", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("학과를 올바르게 입력해 주세요.", "Error", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("학과는 학과(부)까지 입력해주세요.", "Error", MessageBoxButtons.OK);
            }
        }

        private void metroLabel1_DoubleClick(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
