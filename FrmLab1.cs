using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Edoria_Raine_LabStream;

public partial class FrmLab1 : Form
{
    public FrmLab1() => InitializeComponent();

    private void btnRegistration_Click(object? sender, EventArgs e) => new FrmRegistration().ShowDialog(this);

    private void btnCreate_Click(object? sender, EventArgs e)
    {
        using var fileNameForm = new FrmFileName();
        if (fileNameForm.ShowDialog(this) != DialogResult.OK) return;

        string getInput = txtInput.Text;
        if (string.IsNullOrWhiteSpace(getInput))
        {
            MessageBox.Show("Enter text before creating the file.", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtInput.Focus();
            return;
        }
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
        {
            outputFile.WriteLine(getInput);
            Console.WriteLine(getInput);
        }
        MessageBox.Show("Text file created successfully.", "File created", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
