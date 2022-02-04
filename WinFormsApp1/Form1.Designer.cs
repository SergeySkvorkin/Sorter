namespace WinFormsApp1
{
    partial class SORTER
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxCardboardSn = new System.Windows.Forms.TextBox();
            this.txtBoxLaptopSn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmBoxLaptopModel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chBoxCardboardDamage = new System.Windows.Forms.CheckBox();
            this.chBoxCardboardDirt = new System.Windows.Forms.CheckBox();
            this.chBoxCardboardWritings = new System.Windows.Forms.CheckBox();
            this.chBoxCardboardStickers = new System.Windows.Forms.CheckBox();
            this.chBoxCardboardDent = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxCardboardOther = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxLaptopOther = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chBoxLaptopDamage = new System.Windows.Forms.CheckBox();
            this.chBoxLaptopStickers = new System.Windows.Forms.CheckBox();
            this.chBoxLaptopWritings = new System.Windows.Forms.CheckBox();
            this.chBoxLaptopDirt = new System.Windows.Forms.CheckBox();
            this.chBoxLaptopScretchs = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chBoxEquipmentCharger = new System.Windows.Forms.CheckBox();
            this.chBoxquipmentLodgment = new System.Windows.Forms.CheckBox();
            this.chBoxEequipmentBag = new System.Windows.Forms.CheckBox();
            this.chBoxeEquipmentPapers = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(686, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить в базу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "S/N коробки";
            // 
            // txtBoxCardboardSn
            // 
            this.txtBoxCardboardSn.Location = new System.Drawing.Point(12, 89);
            this.txtBoxCardboardSn.Name = "txtBoxCardboardSn";
            this.txtBoxCardboardSn.Size = new System.Drawing.Size(121, 23);
            this.txtBoxCardboardSn.TabIndex = 2;
            // 
            // txtBoxLaptopSn
            // 
            this.txtBoxLaptopSn.Location = new System.Drawing.Point(12, 141);
            this.txtBoxLaptopSn.Name = "txtBoxLaptopSn";
            this.txtBoxLaptopSn.Size = new System.Drawing.Size(121, 23);
            this.txtBoxLaptopSn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "S/N ноутбука";
            // 
            // cmBoxLaptopModel
            // 
            this.cmBoxLaptopModel.FormattingEnabled = true;
            this.cmBoxLaptopModel.Location = new System.Drawing.Point(12, 42);
            this.cmBoxLaptopModel.Name = "cmBoxLaptopModel";
            this.cmBoxLaptopModel.Size = new System.Drawing.Size(121, 23);
            this.cmBoxLaptopModel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Модель ноутбука";
            // 
            // chBoxCardboardDamage
            // 
            this.chBoxCardboardDamage.AutoSize = true;
            this.chBoxCardboardDamage.Location = new System.Drawing.Point(155, 42);
            this.chBoxCardboardDamage.Name = "chBoxCardboardDamage";
            this.chBoxCardboardDamage.Size = new System.Drawing.Size(102, 19);
            this.chBoxCardboardDamage.TabIndex = 7;
            this.chBoxCardboardDamage.Text = "Повреждения";
            this.chBoxCardboardDamage.UseVisualStyleBackColor = true;
            this.chBoxCardboardDamage.CheckedChanged += new System.EventHandler(this.chBoxCardboardDamage_CheckedChanged);
            // 
            // chBoxCardboardDirt
            // 
            this.chBoxCardboardDirt.AutoSize = true;
            this.chBoxCardboardDirt.Location = new System.Drawing.Point(155, 67);
            this.chBoxCardboardDirt.Name = "chBoxCardboardDirt";
            this.chBoxCardboardDirt.Size = new System.Drawing.Size(56, 19);
            this.chBoxCardboardDirt.TabIndex = 8;
            this.chBoxCardboardDirt.Text = "Грязь";
            this.chBoxCardboardDirt.UseVisualStyleBackColor = true;
            this.chBoxCardboardDirt.CheckedChanged += new System.EventHandler(this.chBoxCardboardDirt_CheckedChanged);
            // 
            // chBoxCardboardWritings
            // 
            this.chBoxCardboardWritings.AutoSize = true;
            this.chBoxCardboardWritings.Location = new System.Drawing.Point(155, 92);
            this.chBoxCardboardWritings.Name = "chBoxCardboardWritings";
            this.chBoxCardboardWritings.Size = new System.Drawing.Size(74, 19);
            this.chBoxCardboardWritings.TabIndex = 9;
            this.chBoxCardboardWritings.Text = "Надписи";
            this.chBoxCardboardWritings.UseVisualStyleBackColor = true;
            this.chBoxCardboardWritings.CheckedChanged += new System.EventHandler(this.chBoxCardboardWritings_CheckedChanged);
            // 
            // chBoxCardboardStickers
            // 
            this.chBoxCardboardStickers.AutoSize = true;
            this.chBoxCardboardStickers.Location = new System.Drawing.Point(155, 117);
            this.chBoxCardboardStickers.Name = "chBoxCardboardStickers";
            this.chBoxCardboardStickers.Size = new System.Drawing.Size(118, 19);
            this.chBoxCardboardStickers.TabIndex = 10;
            this.chBoxCardboardStickers.Text = "Наклейки\\Скотч";
            this.chBoxCardboardStickers.UseVisualStyleBackColor = true;
            this.chBoxCardboardStickers.CheckedChanged += new System.EventHandler(this.chBoxCardboardStickers_CheckedChanged);
            // 
            // chBoxCardboardDent
            // 
            this.chBoxCardboardDent.AutoSize = true;
            this.chBoxCardboardDent.Location = new System.Drawing.Point(155, 141);
            this.chBoxCardboardDent.Name = "chBoxCardboardDent";
            this.chBoxCardboardDent.Size = new System.Drawing.Size(76, 19);
            this.chBoxCardboardDent.TabIndex = 11;
            this.chBoxCardboardDent.Text = "Вмятины";
            this.chBoxCardboardDent.UseVisualStyleBackColor = true;
            this.chBoxCardboardDent.CheckedChanged += new System.EventHandler(this.chBoxCardboardDent_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "На коробке присутствуют:";
            // 
            // txtBoxCardboardOther
            // 
            this.txtBoxCardboardOther.Location = new System.Drawing.Point(155, 177);
            this.txtBoxCardboardOther.Name = "txtBoxCardboardOther";
            this.txtBoxCardboardOther.Size = new System.Drawing.Size(142, 23);
            this.txtBoxCardboardOther.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Другое:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Другое:";
            // 
            // txtBoxLaptopOther
            // 
            this.txtBoxLaptopOther.Location = new System.Drawing.Point(314, 178);
            this.txtBoxLaptopOther.Name = "txtBoxLaptopOther";
            this.txtBoxLaptopOther.Size = new System.Drawing.Size(157, 23);
            this.txtBoxLaptopOther.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "На ноутбуке присутствуют:";
            // 
            // chBoxLaptopDamage
            // 
            this.chBoxLaptopDamage.AutoSize = true;
            this.chBoxLaptopDamage.Location = new System.Drawing.Point(314, 142);
            this.chBoxLaptopDamage.Name = "chBoxLaptopDamage";
            this.chBoxLaptopDamage.Size = new System.Drawing.Size(150, 19);
            this.chBoxLaptopDamage.TabIndex = 19;
            this.chBoxLaptopDamage.Text = "Повреждения корпуса";
            this.chBoxLaptopDamage.UseVisualStyleBackColor = true;
            this.chBoxLaptopDamage.CheckedChanged += new System.EventHandler(this.chBoxLaptopDamage_CheckedChanged);
            // 
            // chBoxLaptopStickers
            // 
            this.chBoxLaptopStickers.AutoSize = true;
            this.chBoxLaptopStickers.Location = new System.Drawing.Point(314, 118);
            this.chBoxLaptopStickers.Name = "chBoxLaptopStickers";
            this.chBoxLaptopStickers.Size = new System.Drawing.Size(118, 19);
            this.chBoxLaptopStickers.TabIndex = 18;
            this.chBoxLaptopStickers.Text = "Наклейки\\Скотч";
            this.chBoxLaptopStickers.UseVisualStyleBackColor = true;
            this.chBoxLaptopStickers.CheckedChanged += new System.EventHandler(this.chBoxLaptopStickers_CheckedChanged);
            // 
            // chBoxLaptopWritings
            // 
            this.chBoxLaptopWritings.AutoSize = true;
            this.chBoxLaptopWritings.Location = new System.Drawing.Point(314, 93);
            this.chBoxLaptopWritings.Name = "chBoxLaptopWritings";
            this.chBoxLaptopWritings.Size = new System.Drawing.Size(74, 19);
            this.chBoxLaptopWritings.TabIndex = 17;
            this.chBoxLaptopWritings.Text = "Надписи";
            this.chBoxLaptopWritings.UseVisualStyleBackColor = true;
            this.chBoxLaptopWritings.CheckedChanged += new System.EventHandler(this.chBoxLaptopWritings_CheckedChanged);
            // 
            // chBoxLaptopDirt
            // 
            this.chBoxLaptopDirt.AutoSize = true;
            this.chBoxLaptopDirt.Location = new System.Drawing.Point(314, 68);
            this.chBoxLaptopDirt.Name = "chBoxLaptopDirt";
            this.chBoxLaptopDirt.Size = new System.Drawing.Size(56, 19);
            this.chBoxLaptopDirt.TabIndex = 16;
            this.chBoxLaptopDirt.Text = "Грязь";
            this.chBoxLaptopDirt.UseVisualStyleBackColor = true;
            this.chBoxLaptopDirt.CheckedChanged += new System.EventHandler(this.chBoxLaptopDirt_CheckedChanged);
            // 
            // chBoxLaptopScretchs
            // 
            this.chBoxLaptopScretchs.AutoSize = true;
            this.chBoxLaptopScretchs.Location = new System.Drawing.Point(314, 43);
            this.chBoxLaptopScretchs.Name = "chBoxLaptopScretchs";
            this.chBoxLaptopScretchs.Size = new System.Drawing.Size(84, 19);
            this.chBoxLaptopScretchs.TabIndex = 15;
            this.chBoxLaptopScretchs.Text = "Царапины";
            this.chBoxLaptopScretchs.UseVisualStyleBackColor = false;
            this.chBoxLaptopScretchs.CheckedChanged += new System.EventHandler(this.chBoxLaptopScretchs_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(477, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "В комплектации отсутствует:";
            // 
            // chBoxEquipmentCharger
            // 
            this.chBoxEquipmentCharger.AutoSize = true;
            this.chBoxEquipmentCharger.Location = new System.Drawing.Point(477, 118);
            this.chBoxEquipmentCharger.Name = "chBoxEquipmentCharger";
            this.chBoxEquipmentCharger.Size = new System.Drawing.Size(70, 19);
            this.chBoxEquipmentCharger.TabIndex = 26;
            this.chBoxEquipmentCharger.Text = "Зарядка";
            this.chBoxEquipmentCharger.UseVisualStyleBackColor = true;
            // 
            // chBoxquipmentLodgment
            // 
            this.chBoxquipmentLodgment.AutoSize = true;
            this.chBoxquipmentLodgment.Location = new System.Drawing.Point(477, 93);
            this.chBoxquipmentLodgment.Name = "chBoxquipmentLodgment";
            this.chBoxquipmentLodgment.Size = new System.Drawing.Size(83, 19);
            this.chBoxquipmentLodgment.TabIndex = 25;
            this.chBoxquipmentLodgment.Text = "Ложемент";
            this.chBoxquipmentLodgment.UseVisualStyleBackColor = true;
            this.chBoxquipmentLodgment.CheckedChanged += new System.EventHandler(this.chBoxEquipmentLodgment_CheckedChanged);
            // 
            // chBoxEequipmentBag
            // 
            this.chBoxEequipmentBag.AutoSize = true;
            this.chBoxEequipmentBag.Location = new System.Drawing.Point(477, 68);
            this.chBoxEequipmentBag.Name = "chBoxEequipmentBag";
            this.chBoxEequipmentBag.Size = new System.Drawing.Size(127, 19);
            this.chBoxEequipmentBag.TabIndex = 24;
            this.chBoxEequipmentBag.Text = "Защитный мешок";
            this.chBoxEequipmentBag.UseVisualStyleBackColor = true;
            this.chBoxEequipmentBag.CheckedChanged += new System.EventHandler(this.chBoxEquipmentBag_CheckedChanged);
            // 
            // chBoxeEquipmentPapers
            // 
            this.chBoxeEquipmentPapers.AutoSize = true;
            this.chBoxeEquipmentPapers.Location = new System.Drawing.Point(477, 43);
            this.chBoxeEquipmentPapers.Name = "chBoxeEquipmentPapers";
            this.chBoxeEquipmentPapers.Size = new System.Drawing.Size(92, 19);
            this.chBoxeEquipmentPapers.TabIndex = 23;
            this.chBoxeEquipmentPapers.Text = "Мукулатура";
            this.chBoxeEquipmentPapers.UseVisualStyleBackColor = true;
            this.chBoxeEquipmentPapers.CheckedChanged += new System.EventHandler(this.chBoxEquipmentPapers_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(649, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Система\\Неисправности";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(649, 63);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(143, 23);
            this.txtBox.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(649, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Операционная система:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(649, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "Неисправность(Если имеется)";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(646, 117);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(148, 23);
            this.textBox6.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(646, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 15);
            this.label12.TabIndex = 33;
            this.label12.Text = "Количество ноутбуков в базе";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(646, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 15);
            this.label13.TabIndex = 34;
            this.label13.Text = "2:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(646, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 15);
            this.label14.TabIndex = 35;
            this.label14.Text = "1:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(646, 207);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 15);
            this.label15.TabIndex = 36;
            this.label15.Text = "3:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(646, 222);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 15);
            this.label16.TabIndex = 37;
            this.label16.Text = "4:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(647, 238);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 15);
            this.label18.TabIndex = 39;
            this.label18.Text = "5:";
            // 
            // SORTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 313);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chBoxEquipmentCharger);
            this.Controls.Add(this.chBoxquipmentLodgment);
            this.Controls.Add(this.chBoxEequipmentBag);
            this.Controls.Add(this.chBoxeEquipmentPapers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxLaptopOther);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chBoxLaptopDamage);
            this.Controls.Add(this.chBoxLaptopStickers);
            this.Controls.Add(this.chBoxLaptopWritings);
            this.Controls.Add(this.chBoxLaptopDirt);
            this.Controls.Add(this.chBoxLaptopScretchs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxCardboardOther);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chBoxCardboardDent);
            this.Controls.Add(this.chBoxCardboardStickers);
            this.Controls.Add(this.chBoxCardboardWritings);
            this.Controls.Add(this.chBoxCardboardDirt);
            this.Controls.Add(this.chBoxCardboardDamage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmBoxLaptopModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxLaptopSn);
            this.Controls.Add(this.txtBoxCardboardSn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "SORTER";
            this.Text = "SORTER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txtBoxCardboardSn;
        private TextBox txtBoxLaptopSn;
        private Label label2;
        private ComboBox cmBoxLaptopModel;
        private Label label3;
        private CheckBox chBoxCardboardDamage;
        private CheckBox chBoxCardboardDirt;
        private CheckBox chBoxCardboardWritings;
        private CheckBox chBoxCardboardStickers;
        private CheckBox chBoxCardboardDent;
        private Label label4;
        private TextBox txtBoxCardboardOther;
        private Label label5;
        private Label label6;
        private TextBox txtBoxLaptopOther;
        private Label label7;
        private CheckBox chBoxLaptopDamage;
        private CheckBox chBoxLaptopStickers;
        private CheckBox chBoxLaptopWritings;
        private CheckBox chBoxLaptopDirt;
        private CheckBox chBoxLaptopScretchs;
        private Label label8;
        private CheckBox chBoxEquipmentCharger;
        private CheckBox chBoxquipmentLodgment;
        private CheckBox chBoxEequipmentBag;
        private CheckBox chBoxeEquipmentPapers;
        private Label label9;
        private TextBox txtBox;
        private Label label10;
        private Label label11;
        private TextBox textBox6;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label18;
    }
}