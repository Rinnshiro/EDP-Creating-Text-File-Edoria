namespace Edoria_Raine_LabStream;

partial class FrmFileName
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblFileName = null!;
    private TextBox txtFileName = null!;
    private Button btnOkay = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblFileName = new Label();
        txtFileName = new TextBox();
        btnOkay = new Button();
        SuspendLayout();
        lblFileName.AutoSize = true;
        lblFileName.Location = new Point(25, 24);
        lblFileName.Name = "lblFileName";
        lblFileName.Size = new Size(112, 20);
        lblFileName.Text = "Enter File Name";
        txtFileName.Location = new Point(28, 55);
        txtFileName.Name = "txtFileName";
        txtFileName.Size = new Size(374, 27);
        btnOkay.Location = new Point(155, 108);
        btnOkay.Name = "btnOkay";
        btnOkay.Size = new Size(120, 38);
        btnOkay.Text = "Okay";
        btnOkay.UseVisualStyleBackColor = true;
        btnOkay.Click += btnOkay_Click;
        AcceptButton = btnOkay;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(430, 175);
        Controls.Add(btnOkay);
        Controls.Add(txtFileName);
        Controls.Add(lblFileName);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FrmFileName";
        StartPosition = FormStartPosition.CenterParent;
        Text = "FrmFileName";
        ResumeLayout(false);
        PerformLayout();
    }
}
