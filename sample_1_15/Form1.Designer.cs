namespace sample_1_15 {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
      this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
      this.checkedListBoxControl1 = new DevExpress.XtraEditors.CheckedListBoxControl();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // simpleButton1
      // 
      this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
      this.simpleButton1.Location = new System.Drawing.Point(157, 68);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new System.Drawing.Size(126, 50);
      this.simpleButton1.TabIndex = 1;
      this.simpleButton1.Text = "simpleButton1";
      // 
      // checkEdit1
      // 
      this.checkEdit1.Location = new System.Drawing.Point(157, 43);
      this.checkEdit1.Name = "checkEdit1";
      this.checkEdit1.Properties.Caption = "checkEdit1";
      this.checkEdit1.Size = new System.Drawing.Size(75, 19);
      this.checkEdit1.TabIndex = 0;
      // 
      // checkedListBoxControl1
      // 
      this.checkedListBoxControl1.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("One"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Two")});
      this.checkedListBoxControl1.Location = new System.Drawing.Point(12, 23);
      this.checkedListBoxControl1.Name = "checkedListBoxControl1";
      this.checkedListBoxControl1.Size = new System.Drawing.Size(120, 95);
      this.checkedListBoxControl1.TabIndex = 9;
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(157, 23);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(63, 13);
      this.labelControl1.TabIndex = 13;
      this.labelControl1.Text = "labelControl1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(430, 134);
      this.Controls.Add(this.labelControl1);
      this.Controls.Add(this.simpleButton1);
      this.Controls.Add(this.checkedListBoxControl1);
      this.Controls.Add(this.checkEdit1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private DevExpress.XtraEditors.SimpleButton simpleButton1;
    private DevExpress.XtraEditors.CheckEdit checkEdit1;
    private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl1;
    private DevExpress.XtraEditors.LabelControl labelControl1;
  }
}

