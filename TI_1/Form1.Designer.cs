namespace TI_1
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.groupBox_RailFence = new System.Windows.Forms.GroupBox();
      this.textBox_DecrRail = new System.Windows.Forms.TextBox();
      this.button_DecrRail = new System.Windows.Forms.Button();
      this.textBox_NameDecrRail = new System.Windows.Forms.TextBox();
      this.textBox_EncrRail = new System.Windows.Forms.TextBox();
      this.textBox_IshTxtRail = new System.Windows.Forms.TextBox();
      this.button_EncrRail = new System.Windows.Forms.Button();
      this.textBox_IshFRail = new System.Windows.Forms.TextBox();
      this.groupBox_Vizhiner = new System.Windows.Forms.GroupBox();
      this.textBox_DecrTxtV = new System.Windows.Forms.TextBox();
      this.button_DecrVizh = new System.Windows.Forms.Button();
      this.textBox_EncrVizh = new System.Windows.Forms.TextBox();
      this.textBox_VizhDecr = new System.Windows.Forms.TextBox();
      this.textBox_VIshTxt = new System.Windows.Forms.TextBox();
      this.button_EncrVizh = new System.Windows.Forms.Button();
      this.textBox_VFName = new System.Windows.Forms.TextBox();
      this.groupBox_Choice = new System.Windows.Forms.GroupBox();
      this.radioButton_RailFence = new System.Windows.Forms.RadioButton();
      this.radioButton_Vizhiner = new System.Windows.Forms.RadioButton();
      this.button_Close = new System.Windows.Forms.Button();
      this.textBox_Key = new System.Windows.Forms.TextBox();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.button_Clear = new System.Windows.Forms.Button();
      this.groupBox_RailFence.SuspendLayout();
      this.groupBox_Vizhiner.SuspendLayout();
      this.groupBox_Choice.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox_RailFence
      // 
      this.groupBox_RailFence.Controls.Add(this.textBox_DecrRail);
      this.groupBox_RailFence.Controls.Add(this.button_DecrRail);
      this.groupBox_RailFence.Controls.Add(this.textBox_NameDecrRail);
      this.groupBox_RailFence.Controls.Add(this.textBox_EncrRail);
      this.groupBox_RailFence.Controls.Add(this.textBox_IshTxtRail);
      this.groupBox_RailFence.Controls.Add(this.button_EncrRail);
      this.groupBox_RailFence.Controls.Add(this.textBox_IshFRail);
      this.groupBox_RailFence.Location = new System.Drawing.Point(12, 87);
      this.groupBox_RailFence.Name = "groupBox_RailFence";
      this.groupBox_RailFence.Size = new System.Drawing.Size(404, 549);
      this.groupBox_RailFence.TabIndex = 0;
      this.groupBox_RailFence.TabStop = false;
      this.groupBox_RailFence.Text = "Железодорожная изгородь";
      // 
      // textBox_DecrRail
      // 
      this.textBox_DecrRail.Location = new System.Drawing.Point(6, 463);
      this.textBox_DecrRail.Multiline = true;
      this.textBox_DecrRail.Name = "textBox_DecrRail";
      this.textBox_DecrRail.Size = new System.Drawing.Size(383, 65);
      this.textBox_DecrRail.TabIndex = 9;
      // 
      // button_DecrRail
      // 
      this.button_DecrRail.Location = new System.Drawing.Point(6, 386);
      this.button_DecrRail.Name = "button_DecrRail";
      this.button_DecrRail.Size = new System.Drawing.Size(383, 49);
      this.button_DecrRail.TabIndex = 8;
      this.button_DecrRail.Text = "Открыть и расшифровать файл";
      this.button_DecrRail.UseVisualStyleBackColor = true;
      this.button_DecrRail.Click += new System.EventHandler(this.button_DecrRail_Click);
      // 
      // textBox_NameDecrRail
      // 
      this.textBox_NameDecrRail.Location = new System.Drawing.Point(6, 341);
      this.textBox_NameDecrRail.Name = "textBox_NameDecrRail";
      this.textBox_NameDecrRail.Size = new System.Drawing.Size(383, 22);
      this.textBox_NameDecrRail.TabIndex = 7;
      // 
      // textBox_EncrRail
      // 
      this.textBox_EncrRail.Location = new System.Drawing.Point(6, 245);
      this.textBox_EncrRail.Multiline = true;
      this.textBox_EncrRail.Name = "textBox_EncrRail";
      this.textBox_EncrRail.Size = new System.Drawing.Size(383, 65);
      this.textBox_EncrRail.TabIndex = 8;
      // 
      // textBox_IshTxtRail
      // 
      this.textBox_IshTxtRail.Location = new System.Drawing.Point(6, 153);
      this.textBox_IshTxtRail.Multiline = true;
      this.textBox_IshTxtRail.Name = "textBox_IshTxtRail";
      this.textBox_IshTxtRail.Size = new System.Drawing.Size(383, 65);
      this.textBox_IshTxtRail.TabIndex = 7;
      // 
      // button_EncrRail
      // 
      this.button_EncrRail.Location = new System.Drawing.Point(6, 85);
      this.button_EncrRail.Name = "button_EncrRail";
      this.button_EncrRail.Size = new System.Drawing.Size(383, 49);
      this.button_EncrRail.TabIndex = 4;
      this.button_EncrRail.Text = "Открыть и зашифровать файл";
      this.button_EncrRail.UseVisualStyleBackColor = true;
      this.button_EncrRail.Click += new System.EventHandler(this.button_EncrRail_Click);
      // 
      // textBox_IshFRail
      // 
      this.textBox_IshFRail.Location = new System.Drawing.Point(6, 48);
      this.textBox_IshFRail.Name = "textBox_IshFRail";
      this.textBox_IshFRail.Size = new System.Drawing.Size(383, 22);
      this.textBox_IshFRail.TabIndex = 1;
      // 
      // groupBox_Vizhiner
      // 
      this.groupBox_Vizhiner.Controls.Add(this.textBox_DecrTxtV);
      this.groupBox_Vizhiner.Controls.Add(this.button_DecrVizh);
      this.groupBox_Vizhiner.Controls.Add(this.textBox_EncrVizh);
      this.groupBox_Vizhiner.Controls.Add(this.textBox_VizhDecr);
      this.groupBox_Vizhiner.Controls.Add(this.textBox_VIshTxt);
      this.groupBox_Vizhiner.Controls.Add(this.button_EncrVizh);
      this.groupBox_Vizhiner.Controls.Add(this.textBox_VFName);
      this.groupBox_Vizhiner.Location = new System.Drawing.Point(686, 87);
      this.groupBox_Vizhiner.Name = "groupBox_Vizhiner";
      this.groupBox_Vizhiner.Size = new System.Drawing.Size(415, 549);
      this.groupBox_Vizhiner.TabIndex = 1;
      this.groupBox_Vizhiner.TabStop = false;
      this.groupBox_Vizhiner.Text = "Виженер с прямым ключом";
      // 
      // textBox_DecrTxtV
      // 
      this.textBox_DecrTxtV.Location = new System.Drawing.Point(15, 463);
      this.textBox_DecrTxtV.Multiline = true;
      this.textBox_DecrTxtV.Name = "textBox_DecrTxtV";
      this.textBox_DecrTxtV.Size = new System.Drawing.Size(383, 65);
      this.textBox_DecrTxtV.TabIndex = 8;
      // 
      // button_DecrVizh
      // 
      this.button_DecrVizh.Location = new System.Drawing.Point(15, 386);
      this.button_DecrVizh.Name = "button_DecrVizh";
      this.button_DecrVizh.Size = new System.Drawing.Size(383, 49);
      this.button_DecrVizh.TabIndex = 7;
      this.button_DecrVizh.Text = "Открыть и расшифровать файл";
      this.button_DecrVizh.UseVisualStyleBackColor = true;
      this.button_DecrVizh.Click += new System.EventHandler(this.button_DecrVizh_Click);
      // 
      // textBox_EncrVizh
      // 
      this.textBox_EncrVizh.Location = new System.Drawing.Point(15, 245);
      this.textBox_EncrVizh.Multiline = true;
      this.textBox_EncrVizh.Name = "textBox_EncrVizh";
      this.textBox_EncrVizh.Size = new System.Drawing.Size(383, 65);
      this.textBox_EncrVizh.TabIndex = 6;
      // 
      // textBox_VizhDecr
      // 
      this.textBox_VizhDecr.Location = new System.Drawing.Point(15, 341);
      this.textBox_VizhDecr.Name = "textBox_VizhDecr";
      this.textBox_VizhDecr.Size = new System.Drawing.Size(383, 22);
      this.textBox_VizhDecr.TabIndex = 5;
      // 
      // textBox_VIshTxt
      // 
      this.textBox_VIshTxt.Location = new System.Drawing.Point(15, 153);
      this.textBox_VIshTxt.Multiline = true;
      this.textBox_VIshTxt.Name = "textBox_VIshTxt";
      this.textBox_VIshTxt.Size = new System.Drawing.Size(383, 65);
      this.textBox_VIshTxt.TabIndex = 4;
      // 
      // button_EncrVizh
      // 
      this.button_EncrVizh.Location = new System.Drawing.Point(15, 85);
      this.button_EncrVizh.Name = "button_EncrVizh";
      this.button_EncrVizh.Size = new System.Drawing.Size(383, 49);
      this.button_EncrVizh.TabIndex = 3;
      this.button_EncrVizh.Text = "Открыть и зашифровать файл";
      this.button_EncrVizh.UseVisualStyleBackColor = true;
      this.button_EncrVizh.Click += new System.EventHandler(this.button_EncrVizh_Click);
      // 
      // textBox_VFName
      // 
      this.textBox_VFName.Location = new System.Drawing.Point(15, 48);
      this.textBox_VFName.Name = "textBox_VFName";
      this.textBox_VFName.Size = new System.Drawing.Size(383, 22);
      this.textBox_VFName.TabIndex = 2;
      // 
      // groupBox_Choice
      // 
      this.groupBox_Choice.Controls.Add(this.radioButton_RailFence);
      this.groupBox_Choice.Controls.Add(this.radioButton_Vizhiner);
      this.groupBox_Choice.Location = new System.Drawing.Point(317, 12);
      this.groupBox_Choice.Name = "groupBox_Choice";
      this.groupBox_Choice.Size = new System.Drawing.Size(481, 69);
      this.groupBox_Choice.TabIndex = 1;
      this.groupBox_Choice.TabStop = false;
      this.groupBox_Choice.Text = "Выберите шифр";
      // 
      // radioButton_RailFence
      // 
      this.radioButton_RailFence.AutoSize = true;
      this.radioButton_RailFence.Location = new System.Drawing.Point(20, 32);
      this.radioButton_RailFence.Name = "radioButton_RailFence";
      this.radioButton_RailFence.Size = new System.Drawing.Size(209, 20);
      this.radioButton_RailFence.TabIndex = 0;
      this.radioButton_RailFence.TabStop = true;
      this.radioButton_RailFence.Text = "Железодорожная изгородь";
      this.radioButton_RailFence.UseVisualStyleBackColor = true;
      this.radioButton_RailFence.CheckedChanged += new System.EventHandler(this.radioButton_RailFence_CheckedChanged);
      // 
      // radioButton_Vizhiner
      // 
      this.radioButton_Vizhiner.AutoSize = true;
      this.radioButton_Vizhiner.Location = new System.Drawing.Point(252, 32);
      this.radioButton_Vizhiner.Name = "radioButton_Vizhiner";
      this.radioButton_Vizhiner.Size = new System.Drawing.Size(202, 20);
      this.radioButton_Vizhiner.TabIndex = 1;
      this.radioButton_Vizhiner.TabStop = true;
      this.radioButton_Vizhiner.Text = "Виженер с прямым ключом";
      this.radioButton_Vizhiner.UseVisualStyleBackColor = true;
      this.radioButton_Vizhiner.CheckedChanged += new System.EventHandler(this.radioButton_Vizhiner_CheckedChanged);
      // 
      // button_Close
      // 
      this.button_Close.Location = new System.Drawing.Point(996, 642);
      this.button_Close.Name = "button_Close";
      this.button_Close.Size = new System.Drawing.Size(105, 54);
      this.button_Close.TabIndex = 2;
      this.button_Close.Text = "Закрыть";
      this.button_Close.UseVisualStyleBackColor = true;
      this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
      // 
      // textBox_Key
      // 
      this.textBox_Key.Location = new System.Drawing.Point(501, 135);
      this.textBox_Key.Name = "textBox_Key";
      this.textBox_Key.Size = new System.Drawing.Size(100, 22);
      this.textBox_Key.TabIndex = 3;
      // 
      // openFileDialog
      // 
      this.openFileDialog.FileName = "openFileDialog";
      // 
      // button_Clear
      // 
      this.button_Clear.Location = new System.Drawing.Point(491, 566);
      this.button_Clear.Name = "button_Clear";
      this.button_Clear.Size = new System.Drawing.Size(126, 49);
      this.button_Clear.TabIndex = 10;
      this.button_Clear.Text = "Очистить";
      this.button_Clear.UseVisualStyleBackColor = true;
      this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1122, 708);
      this.Controls.Add(this.button_Clear);
      this.Controls.Add(this.textBox_Key);
      this.Controls.Add(this.button_Close);
      this.Controls.Add(this.groupBox_Choice);
      this.Controls.Add(this.groupBox_Vizhiner);
      this.Controls.Add(this.groupBox_RailFence);
      this.Name = "Form1";
      this.Text = "Шифры";
      this.groupBox_RailFence.ResumeLayout(false);
      this.groupBox_RailFence.PerformLayout();
      this.groupBox_Vizhiner.ResumeLayout(false);
      this.groupBox_Vizhiner.PerformLayout();
      this.groupBox_Choice.ResumeLayout(false);
      this.groupBox_Choice.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_RailFence;
        private System.Windows.Forms.GroupBox groupBox_Vizhiner;
        private System.Windows.Forms.GroupBox groupBox_Choice;
        private System.Windows.Forms.TextBox textBox_DecrRail;
        private System.Windows.Forms.Button button_DecrRail;
        private System.Windows.Forms.TextBox textBox_NameDecrRail;
        private System.Windows.Forms.TextBox textBox_EncrRail;
        private System.Windows.Forms.TextBox textBox_IshTxtRail;
        private System.Windows.Forms.Button button_EncrRail;
        private System.Windows.Forms.TextBox textBox_IshFRail;
        private System.Windows.Forms.TextBox textBox_DecrTxtV;
        private System.Windows.Forms.Button button_DecrVizh;
        private System.Windows.Forms.TextBox textBox_EncrVizh;
        private System.Windows.Forms.TextBox textBox_VizhDecr;
        private System.Windows.Forms.TextBox textBox_VIshTxt;
        private System.Windows.Forms.Button button_EncrVizh;
        private System.Windows.Forms.TextBox textBox_VFName;
        private System.Windows.Forms.RadioButton radioButton_RailFence;
        private System.Windows.Forms.RadioButton radioButton_Vizhiner;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.TextBox textBox_Key;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
    private System.Windows.Forms.Button button_Clear;
  }
}

