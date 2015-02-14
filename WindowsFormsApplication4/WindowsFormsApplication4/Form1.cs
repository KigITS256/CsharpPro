using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class ds1 : Form
    {
        public ds1()
        {
            InitializeComponent();
        }
       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tbx3.Enabled = false;
             tbx4.Enabled = false;
             tbx7.Enabled = false;
             tbx8.Enabled = false;
            tbx11.Enabled = false;
                tbx12.Enabled = false;
               tbx15.Enabled = false;
               tbx16.Enabled = false;
             
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tbx3.Enabled = true;
            tbx4.Enabled = true;
            tbx7.Enabled = true;
            tbx8.Enabled = true;
            tbx11.Enabled = true;
            tbx12.Enabled = true;
            tbx15.Enabled = true;
            tbx16.Enabled = true;
           
            
        }
        double Min = 999999, Max = 0;
        double[] p1 = new double[4];
        double[] p2 = new double[4];
        double[] p3 = new double[4];
        double[] p4 = new double[4];
        private void button1_Click(object sender, EventArgs e)
        {
            double[,] ar = new double[4, 4];
           
            ar[0, 0] = double.Parse(tbx1.Text); ar[1, 0] = double.Parse(tbx2.Text); ar[2, 0] = double.Parse(tbx3.Text); ar[3, 0] = double.Parse(tbx4.Text);
            ar[0, 1] = double.Parse(tbx5.Text); ar[1, 1] = double.Parse(tbx6.Text); ar[2, 1] = double.Parse(tbx7.Text); ar[3, 1] = double.Parse(tbx8.Text);
            ar[0, 2] = double.Parse(tbx9.Text); ar[1, 2] = double.Parse(tbx10.Text); ar[2, 2] = double.Parse(tbx11.Text); ar[3, 2] = double.Parse(tbx12.Text);
            ar[0, 3] = double.Parse(tbx13.Text); ar[1, 3] = double.Parse(tbx14.Text); ar[2, 3] = double.Parse(tbx15.Text); ar[3, 3] = double.Parse(tbx16.Text);


            for(int i=0;i<=3;i++){
                p1[i] = ar[i, 0];
                p2[i] = ar[i, 1];
                p3[i] = ar[i, 2];
                p4[i] = ar[i, 3];      
           
           }

                /*[00][10][20][30]
                  [01][11][21][31]
                 *[02][12][22][32]
                 *[03][13][23][33]
                 */
           
            ts1.Text = Convert.ToString(density(p1, p1));
            ts2.Text = Convert.ToString(density(p1, p2));
            ts3.Text = Convert.ToString(density(p1, p3));
            ts4.Text = Convert.ToString(density(p1, p4));
            ts7.Text = Convert.ToString(density(p2, p3));
            ts8.Text = Convert.ToString(density(p2, p4));
            ts12.Text = Convert.ToString(density(p3, p4));
            ts6.Text = Convert.ToString(density(p3, p3));
            ts11.Text = Convert.ToString(density(p3, p3));
            ts16.Text = Convert.ToString(density(p4, p4));

                ts5.Text = ts2.Text;
                ts9.Text = ts3.Text;
                ts10.Text = ts7.Text;
                ts14.Text = ts8.Text;
                ts15.Text = ts12.Text;
                ts13.Text = ts4.Text;
                
                double []MinMax=new double[13]; 
                
                MinMax[1]= double.Parse(ts2.Text);
                MinMax[2]= double.Parse(ts3.Text);
                MinMax[3]= double.Parse(ts4.Text);
                MinMax[4]= double.Parse(ts5.Text);
               
                MinMax[5]= double.Parse(ts7.Text);
                MinMax[6]= double.Parse(ts8.Text);
                MinMax[7]= double.Parse(ts9.Text);
                MinMax[8]= double.Parse(ts10.Text);
                
                MinMax[9]= double.Parse(ts12.Text);
                MinMax[10]= double.Parse(ts13.Text);
                MinMax[11]= double.Parse(ts14.Text);
                MinMax[12]=  double.Parse(ts15.Text);
               
            
            for(int s=1;s<=12;s++){
                if (MinMax[s] < Min)
                {
                Min = MinMax[s];

            }
            else if (Max < MinMax[s])
            {
                Max = MinMax[s];
            }
            
            }
            tbxMin.Text = Convert.ToString(Min);
            tbxMax.Text = Convert.ToString(Max);


            btS1.Text = Convert.ToString(double.Parse(ts1.Text));
            btS2.Text = Convert.ToString(Math.Round((double.Parse(ts2.Text) - Min) / (Max - Min), 3));
            btS3.Text = Convert.ToString(Math.Round((double.Parse(ts3.Text) - Min) / (Max - Min), 3));
            btS4.Text = Convert.ToString(Math.Round((double.Parse(ts4.Text) - Min) / (Max - Min), 3));
            btS5.Text = Convert.ToString(Math.Round((double.Parse(ts5.Text) - Min) / (Max - Min), 3));
            btS6.Text = Convert.ToString(double.Parse(ts6.Text));
            btS7.Text = Convert.ToString(Math.Round((double.Parse(ts7.Text) - Min) / (Max - Min), 3));
            btS8.Text = Convert.ToString(Math.Round((double.Parse(ts8.Text) - Min) / (Max - Min), 3));
            btS9.Text = Convert.ToString(Math.Round((double.Parse(ts9.Text) - Min) / (Max - Min), 3));
            btS10.Text = Convert.ToString(Math.Round((double.Parse(ts10.Text) - Min) / (Max - Min), 3));
            btS11.Text = Convert.ToString(double.Parse(ts11.Text));
            btS12.Text = Convert.ToString(Math.Round((double.Parse(ts12.Text) - Min) / (Max - Min), 3));
            btS13.Text = Convert.ToString(Math.Round((double.Parse(ts13.Text) - Min) / (Max - Min), 3));
            btS14.Text = Convert.ToString(Math.Round((double.Parse(ts14.Text) - Min) / (Max - Min), 3));
            btS15.Text = Convert.ToString(Math.Round((double.Parse(ts15.Text) - Min) / (Max - Min), 3));
            btS16.Text = Convert.ToString(double.Parse(ts16.Text));

            ds0.Text = Convert.ToString(0);
            ds6.Text = Convert.ToString(0);
            ds11.Text = Convert.ToString(0);
            ds16.Text = Convert.ToString(0);
            ds2.Text = Convert.ToString(cosine(p1,p2));
            ds3.Text = Convert.ToString(cosine(p1, p3));
            ds4.Text = Convert.ToString(cosine(p1, p4));
            ds7.Text = Convert.ToString(cosine(p2, p3));
            ds8.Text = Convert.ToString(cosine(p4, p2));
            ds12.Text = Convert.ToString(cosine(p3, p4));
            ds5.Text=ds2.Text ;
             ds10.Text=ds7.Text;
             ds15.Text=ds12.Text;
            ds14.Text = ds8.Text;
            ds9.Text = ds3.Text;
            ds13.Text = ds4.Text;
            Ck1 = 1;
            Ck = 1;
            
        }
        public double cosine(double[] ar, double[] ar1)
        {
            double dp1_dp2,dp1,dp2,sum;
            dp1_dp2 = Math.Round((ar[0] * ar1[0]) +
                (ar[1] * ar1[1]) +
                (ar[2] * ar1[2]) +
                (ar[3] * ar1[3]),3);
            dp1 = Math.Round(Math.Pow(Math.Pow(ar[0],2) + Math.Pow(ar[1],2) + Math.Pow(ar[2],2) + Math.Pow(ar[3],2),0.5),3);
            dp2 = Math.Round(Math.Pow(Math.Pow(ar1[0], 2) + Math.Pow(ar1[1], 2) + Math.Pow(ar1[2], 2) + Math.Pow(ar1[3], 2), 0.5),3);
            sum = Math.Round((dp1_dp2)/(dp1*dp2),3);
            return sum;
        }
        public double density(double []ar,double[] ar1)
        { 
            double sum;
            sum=Math.Round(Math.Pow(
                 Math.Pow(ar[0] - ar1[0], 2) +
                 Math.Pow(ar[1] - ar1[1], 2) +
                 Math.Pow(ar[2] - ar1[2], 2) +
                 Math.Pow(ar[3] - ar1[3], 2)
                , 0.5), 3);
            

            return sum;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Select();
            return;
         
           
        }
        int Ck = 0;
        private void btnOn_Click(object sender, EventArgs e)
        {
            
            if (Ck == 1)
            {
                btS1.Text = Convert.ToString(double.Parse(ts1.Text));
                btS2.Text = Convert.ToString(Math.Round(1-((double.Parse(ts2.Text) - Min) / (Max - Min)),3));
                btS3.Text = Convert.ToString(Math.Round(1 - ((double.Parse(ts3.Text) - Min) / (Max - Min)), 3));
                btS4.Text = Convert.ToString(Math.Round(1 - ((double.Parse(ts4.Text) - Min) / (Max - Min)), 3));
                btS5.Text = Convert.ToString(Math.Round(1 - ((double.Parse(ts5.Text) - Min) / (Max - Min)), 3));
                btS6.Text = Convert.ToString(double.Parse(ts6.Text));
                btS7.Text = Convert.ToString(Math.Round(1 - ((double.Parse(ts7.Text) - Min) / (Max - Min)), 3));
                btS8.Text = Convert.ToString(Math.Round(1 - ((double.Parse(ts8.Text) - Min) / (Max - Min)), 3));
                btS9.Text = Convert.ToString(Math.Round(1 - ((double.Parse(ts9.Text) - Min) / (Max - Min)), 3));
                btS10.Text = Convert.ToString(Math.Round(1 - ((double.Parse(ts10.Text) - Min) / (Max - Min)), 3));
                btS11.Text = Convert.ToString(double.Parse(ts11.Text));
                btS12.Text = Convert.ToString(Math.Round(1 - ((double.Parse(ts12.Text) - Min) / (Max - Min)), 3));
                btS13.Text = Convert.ToString(Math.Round(1 - ((double.Parse(ts13.Text) - Min) / (Max - Min)), 3));
                btS14.Text = Convert.ToString(Math.Round(1 - ((double.Parse(ts14.Text) - Min) / (Max - Min)), 3));
                btS15.Text = Convert.ToString(Math.Round(1 - ((double.Parse(ts15.Text) - Min) / (Max - Min)), 3));
                btS16.Text = Convert.ToString(double.Parse(ts16.Text));
                
                btnOn.Text = "off[0-1]";
            Ck = 0;
            }else{
                btS1.Text = Convert.ToString(double.Parse(ts1.Text));
                btS2.Text = Convert.ToString(Math.Round((double.Parse(ts2.Text) - Min) / (Max - Min),3));
                btS3.Text = Convert.ToString(Math.Round((double.Parse(ts3.Text) - Min) / (Max - Min), 3));
                btS4.Text = Convert.ToString(Math.Round((double.Parse(ts4.Text) - Min) / (Max - Min), 3));
                btS5.Text = Convert.ToString(Math.Round((double.Parse(ts5.Text) - Min) / (Max - Min), 3));
                btS6.Text = Convert.ToString(double.Parse(ts6.Text));
                btS7.Text = Convert.ToString(Math.Round((double.Parse(ts7.Text) - Min) / (Max - Min), 3));
                btS8.Text = Convert.ToString(Math.Round((double.Parse(ts8.Text) - Min) / (Max - Min), 3));
                btS9.Text = Convert.ToString(Math.Round((double.Parse(ts9.Text) - Min) / (Max - Min), 3));
                btS10.Text = Convert.ToString(Math.Round((double.Parse(ts10.Text) - Min) / (Max - Min), 3));
                btS11.Text = Convert.ToString(double.Parse(ts11.Text));
                btS12.Text = Convert.ToString(Math.Round((double.Parse(ts12.Text) - Min) / (Max - Min), 3));
                btS13.Text = Convert.ToString(Math.Round((double.Parse(ts13.Text) - Min) / (Max - Min), 3));
                btS14.Text = Convert.ToString(Math.Round((double.Parse(ts14.Text) - Min) / (Max - Min), 3));
                btS15.Text = Convert.ToString(Math.Round((double.Parse(ts15.Text) - Min) / (Max - Min), 3));
                btS16.Text = Convert.ToString(double.Parse(ts16.Text));
                btnOn.Text = "On[0-1]";
                
                Ck = 0;

            }
        }

        private void ล้างค่า_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการจะล้างค่าโปรแกรมหรือไม่ ?", "ล้างค่าโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                btS1.Text = "";
                btS2.Text = "";
                btS3.Text = "";
                btS4.Text = "";
                btS5.Text = "";
                btS6.Text = "";
                btS7.Text = "";
                btS8.Text = "";
                btS9.Text = "";
                btS10.Text = "";
                btS11.Text = "";
                btS12.Text = "";
                btS13.Text = "";
                btS14.Text = "";
                btS15.Text = "";
                btS16.Text = "";

                ds0.Text = "";
                ds2.Text = "";
                ds3.Text = "";
                ds4.Text = "";
                ds5.Text = "";
                ds6.Text = "";
                ds7.Text = "";
                ds8.Text = "";
                ds9.Text = "";
                ds10.Text = "";
                ds11.Text = "";
                ds12.Text = "";
                ds13.Text = "";
                ds14.Text = "";
                ds15.Text = "";
                ds16.Text = "";

                ts1.Text = "";
                ts2.Text = "";
                ts3.Text = "";
                ts4.Text = "";
                ts5.Text = "";
                ts6.Text = "";
                ts7.Text = "";
                ts8.Text = "";
                ts9.Text = "";
                ts10.Text = "";
                ts11.Text = "";
                ts12.Text = "";
                ts13.Text = "";
                ts14.Text = "";
                ts15.Text = "";
                ts16.Text = "";

                tbx1.Text = "0";
                tbx2.Text = "0";
                tbx3.Text = "0";
                tbx4.Text = "0";
                tbx5.Text = "0";
                tbx6.Text = "0";
                tbx7.Text = "0";
                tbx8.Text = "0";
                tbx9.Text = "0";
                tbx10.Text = "0";
                tbx11.Text = "0";
                tbx12.Text = "0";
                tbx13.Text = "0";
                tbx14.Text = "0";
                tbx15.Text = "0";
                tbx16.Text = "0";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("คุณต้องการจะปิดโปรแกรมหรือไม่ ?", "ปิดโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        int Ck1 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (Ck1 == 0)
            {

                Ck1 = 1;
                button2.Text = "On[0-1]";
                ds0.Text = Convert.ToString(0);
                ds6.Text = Convert.ToString(0);
                ds11.Text = Convert.ToString(0);
                ds16.Text = Convert.ToString(0);
                ds2.Text = Convert.ToString(cosine(p1, p2));
                ds3.Text = Convert.ToString(cosine(p1, p3));
                ds4.Text = Convert.ToString(cosine(p1, p4));
                ds7.Text = Convert.ToString(cosine(p2, p3));
                ds8.Text = Convert.ToString(cosine(p4, p2));
                ds12.Text = Convert.ToString(cosine(p3, p4));
                ds5.Text = ds2.Text;
                ds10.Text = ds7.Text;
                ds15.Text = ds12.Text;
                ds14.Text = ds8.Text;
                ds9.Text = ds3.Text;
                ds13.Text = ds4.Text;
            }
            else
            {
                ds0.Text = Convert.ToString(0);
                ds6.Text = Convert.ToString(0);
                ds11.Text = Convert.ToString(0);
                ds16.Text = Convert.ToString(0);
                ds2.Text = Convert.ToString(1-cosine(p1, p2));
                ds3.Text = Convert.ToString(1-cosine(p1, p3));
                ds4.Text = Convert.ToString(1-cosine(p1, p4));
                ds7.Text = Convert.ToString(1-cosine(p2, p3));
                ds8.Text = Convert.ToString(1-cosine(p4, p2));
                ds12.Text = Convert.ToString(1-cosine(p3, p4));
                ds5.Text = ds2.Text;
                ds10.Text = ds7.Text;
                ds15.Text = ds12.Text;
                ds14.Text = ds8.Text;
                ds9.Text = ds3.Text;
                ds13.Text = ds4.Text;
                button2.Text = "off[0-1]";
                
                Ck1 = 0;

            }
        }

        
    }
}
