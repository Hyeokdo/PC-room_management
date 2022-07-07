
namespace Program
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnagree = new MetroFramework.Controls.MetroButton();
            this.btnexit = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtdepart = new System.Windows.Forms.TextBox();
            this.txtstdnum = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpurpose = new System.Windows.Forms.TextBox();
            this.labtime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 304);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(204, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "개인 정보 수집에 동의합니다.";
            this.metroLabel1.DoubleClick += new System.EventHandler(this.metroLabel1_DoubleClick);
            // 
            // btnagree
            // 
            this.btnagree.Location = new System.Drawing.Point(14, 339);
            this.btnagree.Name = "btnagree";
            this.btnagree.Size = new System.Drawing.Size(96, 35);
            this.btnagree.TabIndex = 5;
            this.btnagree.Text = "동의";
            this.btnagree.Click += new System.EventHandler(this.btnagree_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(116, 339);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(96, 35);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "닫기";
            this.btnexit.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "학과";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 95);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 20);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "학번";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 130);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 20);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "이름";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 165);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(39, 20);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "시간";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 200);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 20);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "사용목적";
            // 
            // txtdepart
            // 
            this.txtdepart.Location = new System.Drawing.Point(66, 60);
            this.txtdepart.Multiline = true;
            this.txtdepart.Name = "txtdepart";
            this.txtdepart.Size = new System.Drawing.Size(128, 19);
            this.txtdepart.TabIndex = 1;
            // 
            // txtstdnum
            // 
            this.txtstdnum.Location = new System.Drawing.Point(66, 95);
            this.txtstdnum.Multiline = true;
            this.txtstdnum.Name = "txtstdnum";
            this.txtstdnum.Size = new System.Drawing.Size(128, 19);
            this.txtstdnum.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(66, 130);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(128, 19);
            this.txtname.TabIndex = 3;
            // 
            // txtpurpose
            // 
            this.txtpurpose.Location = new System.Drawing.Point(23, 222);
            this.txtpurpose.Multiline = true;
            this.txtpurpose.Name = "txtpurpose";
            this.txtpurpose.Size = new System.Drawing.Size(171, 69);
            this.txtpurpose.TabIndex = 4;
            // 
            // labtime
            // 
            this.labtime.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labtime.Location = new System.Drawing.Point(66, 169);
            this.labtime.Name = "labtime";
            this.labtime.Size = new System.Drawing.Size(128, 19);
            this.labtime.TabIndex = 5;
            this.labtime.Text = " ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(231, 397);
            this.ControlBox = false;
            this.Controls.Add(this.labtime);
            this.Controls.Add(this.txtpurpose);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtstdnum);
            this.Controls.Add(this.txtdepart);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnagree);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnagree;
        private MetroFramework.Controls.MetroButton btnexit;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TextBox txtdepart;
        private System.Windows.Forms.TextBox txtstdnum;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpurpose;
        private System.Windows.Forms.Label labtime;
        private System.Windows.Forms.Timer timer1;
    }
}