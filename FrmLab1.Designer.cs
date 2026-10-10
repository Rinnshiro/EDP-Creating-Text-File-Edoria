namespace Edoria_Raine_LabStream;

partial class FrmLab1
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitle = null!;
    private Label lblPrompt = null!;
    private TextBox txtInput = null!;
    private Button btnCreate = null!;
    private Button btnRegistration = null!;

    protected override void Dispose(bool disposing) { if (disposing) components?.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        lblTitle = new Label(); lblPrompt = new Label(); txtInput = new TextBox(); btnCreate = new Button(); btnRegistration = new Button();
        SuspendLayout();
        lblTitle.AutoSize = true; lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold); lblTitle.Location = new Point(28, 24); lblTitle.Name = "lblTitle"; lblTitle.Text = "Creating Text File";
        lblPrompt.AutoSize = true; lblPrompt.Location = new Point(31, 77); lblPrompt.Name = "lblPrompt"; lblPrompt.Text = "Enter the text to save:";
        txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right; txtInput.Location = new Point(34, 105); txtInput.Multiline = true; txtInput.Name = "txtInput"; txtInput.ScrollBars = ScrollBars.Vertical; txtInput.Size = new Size(450, 105);
        btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right; btnCreate.Location = new Point(364, 228); btnCreate.Name = "btnCreate"; btnCreate.Size = new Size(120, 40); btnCreate.Text = "Create"; btnCreate.UseVisualStyleBackColor = true; btnCreate.Click += btnCreate_Click;
        btnRegistration.Location = new Point(34, 228); btnRegistration.Name = "btnRegistration"; btnRegistration.Size = new Size(135, 40); btnRegistration.Text = "Registration"; btnRegistration.UseVisualStyleBackColor = true; btnRegistration.Click += btnRegistration_Click;
        AcceptButton = btnCreate; AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(520, 320);
        Controls.Add(btnRegistration); Controls.Add(btnCreate); Controls.Add(txtInput); Controls.Add(lblPrompt); Controls.Add(lblTitle);
        Font = new Font("Segoe UI", 10F); MinimumSize = new Size(480, 300); Name = "FrmLab1"; StartPosition = FormStartPosition.CenterScreen; Text = "FrmLab1 - Creating Text File";
        ResumeLayout(false); PerformLayout();
    }
}
