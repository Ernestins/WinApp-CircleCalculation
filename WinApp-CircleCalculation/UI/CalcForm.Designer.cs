namespace WinApp_CircleCalculation.UI
{
  partial class CalcForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcForm));
      this.picOutline = new System.Windows.Forms.PictureBox();
      this.edRadius = new System.Windows.Forms.TextBox();
      this.edCircum = new System.Windows.Forms.TextBox();
      this.edArea = new System.Windows.Forms.TextBox();
      this.btnCalcA = new System.Windows.Forms.Button();
      this.btnCalcC = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.picOutline)).BeginInit();
      this.SuspendLayout();
      // 
      // picOutline
      // 
      this.picOutline.Image = ((System.Drawing.Image)(resources.GetObject("picOutline.Image")));
      this.picOutline.Location = new System.Drawing.Point(12, 12);
      this.picOutline.Name = "picOutline";
      this.picOutline.Size = new System.Drawing.Size(186, 249);
      this.picOutline.TabIndex = 0;
      this.picOutline.TabStop = false;
      // 
      // edRadius
      // 
      this.edRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.edRadius.Location = new System.Drawing.Point(131, 103);
      this.edRadius.Name = "edRadius";
      this.edRadius.Size = new System.Drawing.Size(100, 23);
      this.edRadius.TabIndex = 1;
      this.edRadius.Leave += new System.EventHandler(this.edRadius_Leave);
      // 
      // edCircum
      // 
      this.edCircum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.edCircum.Location = new System.Drawing.Point(131, 185);
      this.edCircum.Name = "edCircum";
      this.edCircum.ReadOnly = true;
      this.edCircum.Size = new System.Drawing.Size(100, 23);
      this.edCircum.TabIndex = 2;
      // 
      // edArea
      // 
      this.edArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.edArea.Location = new System.Drawing.Point(131, 31);
      this.edArea.Name = "edArea";
      this.edArea.ReadOnly = true;
      this.edArea.Size = new System.Drawing.Size(100, 23);
      this.edArea.TabIndex = 3;
      // 
      // btnCalcA
      // 
      this.btnCalcA.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.btnCalcA.AutoEllipsis = true;
      this.btnCalcA.Location = new System.Drawing.Point(249, 31);
      this.btnCalcA.Name = "btnCalcA";
      this.btnCalcA.Size = new System.Drawing.Size(90, 23);
      this.btnCalcA.TabIndex = 4;
      this.btnCalcA.Text = "Calculate";
      this.btnCalcA.UseVisualStyleBackColor = true;
      // 
      // btnCalcC
      // 
      this.btnCalcC.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.btnCalcC.AutoEllipsis = true;
      this.btnCalcC.Location = new System.Drawing.Point(249, 185);
      this.btnCalcC.Name = "btnCalcC";
      this.btnCalcC.Size = new System.Drawing.Size(90, 23);
      this.btnCalcC.TabIndex = 5;
      this.btnCalcC.Text = "Calculate";
      this.btnCalcC.UseVisualStyleBackColor = true;
      // 
      // CalcForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(384, 281);
      this.Controls.Add(this.btnCalcC);
      this.Controls.Add(this.btnCalcA);
      this.Controls.Add(this.edArea);
      this.Controls.Add(this.edCircum);
      this.Controls.Add(this.edRadius);
      this.Controls.Add(this.picOutline);
      this.MaximumSize = new System.Drawing.Size(580, 320);
      this.MinimumSize = new System.Drawing.Size(380, 300);
      this.Name = "CalcForm";
      this.Text = "calculate area and circumference";
      ((System.ComponentModel.ISupportInitialize)(this.picOutline)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private PictureBox picOutline;
    private TextBox edRadius;
    private TextBox edCircum;
    private TextBox edArea;
    private Button btnCalcA;
    private Button btnCalcC;
  }
}