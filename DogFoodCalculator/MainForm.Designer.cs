
namespace DogFoodCalculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.tbFat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFiber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMoisture = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAsh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCarbs = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAct1 = new System.Windows.Forms.RadioButton();
            this.rbAct2 = new System.Windows.Forms.RadioButton();
            this.rbAct4 = new System.Windows.Forms.RadioButton();
            this.rbAct3 = new System.Windows.Forms.RadioButton();
            this.rbAct5 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbProtein = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDER = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbME = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTotalFood = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fat";
            // 
            // tbFat
            // 
            this.tbFat.Location = new System.Drawing.Point(89, 48);
            this.tbFat.Name = "tbFat";
            this.tbFat.Size = new System.Drawing.Size(100, 20);
            this.tbFat.TabIndex = 1;
            this.tbFat.TextChanged += new System.EventHandler(this.CalculateCarbs);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fiber";
            // 
            // tbFiber
            // 
            this.tbFiber.Location = new System.Drawing.Point(89, 74);
            this.tbFiber.Name = "tbFiber";
            this.tbFiber.Size = new System.Drawing.Size(100, 20);
            this.tbFiber.TabIndex = 2;
            this.tbFiber.TextChanged += new System.EventHandler(this.CalculateCarbs);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Moisture";
            // 
            // tbMoisture
            // 
            this.tbMoisture.Location = new System.Drawing.Point(89, 100);
            this.tbMoisture.Name = "tbMoisture";
            this.tbMoisture.Size = new System.Drawing.Size(100, 20);
            this.tbMoisture.TabIndex = 3;
            this.tbMoisture.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ash";
            // 
            // tbAsh
            // 
            this.tbAsh.Location = new System.Drawing.Point(89, 126);
            this.tbAsh.Name = "tbAsh";
            this.tbAsh.Size = new System.Drawing.Size(100, 20);
            this.tbAsh.TabIndex = 4;
            this.tbAsh.TextChanged += new System.EventHandler(this.CalculateCarbs);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Carbs";
            // 
            // tbCarbs
            // 
            this.tbCarbs.Enabled = false;
            this.tbCarbs.Location = new System.Drawing.Point(89, 152);
            this.tbCarbs.Name = "tbCarbs";
            this.tbCarbs.Size = new System.Drawing.Size(100, 20);
            this.tbCarbs.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbProtein);
            this.groupBox1.Controls.Add(this.tbCarbs);
            this.groupBox1.Controls.Add(this.tbFat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbAsh);
            this.groupBox1.Controls.Add(this.tbFiber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbMoisture);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 272);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Food Content in Percentage";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 69);
            this.label7.TabIndex = 12;
            this.label7.Text = "Carbs are the Nitrogen Free Extract ones. Calculated automatically with formula, " +
    "Carbs = 100 - (% protein + % fat + % fibre + % moisture + % ash) Moisture defaul" +
    "t is 10%.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tbWeight);
            this.groupBox2.Controls.Add(this.rbAct5);
            this.groupBox2.Controls.Add(this.rbAct4);
            this.groupBox2.Controls.Add(this.rbAct3);
            this.groupBox2.Controls.Add(this.rbAct2);
            this.groupBox2.Controls.Add(this.rbAct1);
            this.groupBox2.Location = new System.Drawing.Point(213, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 272);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Dog Activity";
            // 
            // rbAct1
            // 
            this.rbAct1.AutoSize = true;
            this.rbAct1.Checked = true;
            this.rbAct1.Location = new System.Drawing.Point(6, 23);
            this.rbAct1.Name = "rbAct1";
            this.rbAct1.Size = new System.Drawing.Size(90, 17);
            this.rbAct1.TabIndex = 0;
            this.rbAct1.TabStop = true;
            this.rbAct1.Text = "<1h/day walk";
            this.rbAct1.UseVisualStyleBackColor = true;
            // 
            // rbAct2
            // 
            this.rbAct2.AutoSize = true;
            this.rbAct2.Location = new System.Drawing.Point(6, 49);
            this.rbAct2.Name = "rbAct2";
            this.rbAct2.Size = new System.Drawing.Size(93, 17);
            this.rbAct2.TabIndex = 1;
            this.rbAct2.Text = "1-3h/day walk";
            this.rbAct2.UseVisualStyleBackColor = true;
            // 
            // rbAct4
            // 
            this.rbAct4.AutoSize = true;
            this.rbAct4.Location = new System.Drawing.Point(6, 101);
            this.rbAct4.Name = "rbAct4";
            this.rbAct4.Size = new System.Drawing.Size(162, 17);
            this.rbAct4.TabIndex = 3;
            this.rbAct4.Text = "3-6h/day or handling a ranch";
            this.rbAct4.UseVisualStyleBackColor = true;
            // 
            // rbAct3
            // 
            this.rbAct3.AutoSize = true;
            this.rbAct3.Location = new System.Drawing.Point(6, 75);
            this.rbAct3.Name = "rbAct3";
            this.rbAct3.Size = new System.Drawing.Size(125, 17);
            this.rbAct3.TabIndex = 2;
            this.rbAct3.Text = "1-3h/day run or fetch";
            this.rbAct3.UseVisualStyleBackColor = true;
            // 
            // rbAct5
            // 
            this.rbAct5.AutoSize = true;
            this.rbAct5.Location = new System.Drawing.Point(6, 127);
            this.rbAct5.Name = "rbAct5";
            this.rbAct5.Size = new System.Drawing.Size(155, 17);
            this.rbAct5.TabIndex = 4;
            this.rbAct5.Text = "my dog sled racing in -100C";
            this.rbAct5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbTotalFood);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbME);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbDER);
            this.groupBox3.Location = new System.Drawing.Point(440, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 272);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. So How Much?";
            // 
            // tbProtein
            // 
            this.tbProtein.Location = new System.Drawing.Point(89, 22);
            this.tbProtein.Name = "tbProtein";
            this.tbProtein.Size = new System.Drawing.Size(100, 20);
            this.tbProtein.TabIndex = 0;
            this.tbProtein.TextChanged += new System.EventHandler(this.CalculateCarbs);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Protein";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Daily Enery Requirement";
            // 
            // tbDER
            // 
            this.tbDER.Enabled = false;
            this.tbDER.Location = new System.Drawing.Point(9, 48);
            this.tbDER.Name = "tbDER";
            this.tbDER.Size = new System.Drawing.Size(185, 20);
            this.tbDER.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 52);
            this.label9.TabIndex = 15;
            this.label9.Text = "Metabolisable Energy (Kcal/100g food) from food. Formula is            (ME fat + " +
    "ME protein + ME carbohydrate) X 10";
            // 
            // tbME
            // 
            this.tbME.Enabled = false;
            this.tbME.Location = new System.Drawing.Point(9, 127);
            this.tbME.Name = "tbME";
            this.tbME.Size = new System.Drawing.Size(185, 20);
            this.tbME.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Food amount in grams";
            // 
            // tbTotalFood
            // 
            this.tbTotalFood.Enabled = false;
            this.tbTotalFood.Location = new System.Drawing.Point(9, 174);
            this.tbTotalFood.Name = "tbTotalFood";
            this.tbTotalFood.Size = new System.Drawing.Size(185, 20);
            this.tbTotalFood.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Dog Weight in kg";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(115, 152);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(100, 20);
            this.tbWeight.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 296);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "How Much Food Should I Gave to My Dog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFiber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMoisture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAsh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCarbs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProtein;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbAct5;
        private System.Windows.Forms.RadioButton rbAct4;
        private System.Windows.Forms.RadioButton rbAct3;
        private System.Windows.Forms.RadioButton rbAct2;
        private System.Windows.Forms.RadioButton rbAct1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbTotalFood;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbME;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDER;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbWeight;
    }
}

