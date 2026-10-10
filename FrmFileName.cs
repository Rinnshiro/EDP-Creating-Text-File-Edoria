using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Edoria_Raine_LabStream;

public partial class FrmFileName : Form
{
    public static string SetFileName;

    public FrmFileName()
    {
        InitializeComponent();
    }

    private void btnOkay_Click(object? sender, EventArgs e)
    {
        string requestedName = txtFileName.Text.Trim();
        if (string.IsNullOrWhiteSpace(requestedName))
        {
            MessageBox.Show("Enter a file name.", "Missing file name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtFileName.Focus();
            return;
        }
        if (requestedName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
        {
            MessageBox.Show("The file name contains an invalid character.", "Invalid file name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtFileName.SelectAll();
            txtFileName.Focus();
            return;
        }
        SetFileName = Path.GetFileNameWithoutExtension(requestedName) + ".txt";
        DialogResult = DialogResult.OK;
        Close();
    }
}
