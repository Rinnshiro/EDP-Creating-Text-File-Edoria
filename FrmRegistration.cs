using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
namespace Edoria_Raine_LabStream;

public partial class FrmRegistration : Form
{
    public FrmRegistration() => InitializeComponent();

    private void btnRegister_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtStudentNo.Text) || 
            string.IsNullOrWhiteSpace(txtLastName.Text) || 
            string.IsNullOrWhiteSpace(txtFirstName.Text) || 
            string.IsNullOrWhiteSpace(txtContactNo.Text))
        {
            MessageBox.Show("Complete the required registration fields.", "Incomplete information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string studentNo = txtStudentNo.Text.Trim();
        if (studentNo.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
        {
            MessageBox.Show("Student number contains an invalid file-name character.", "Invalid student number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string middle = txtMiddleInitial.Text.Trim().TrimEnd('.');
        string fullName = $"{txtLastName.Text.Trim()}, {txtFirstName.Text.Trim()}" + 
                          (middle.Length > 0 ? $" {middle}." : "");

        string[] registration = 
        [
            $"Student No.: {studentNo}",
            $"Full Name: {fullName}",
            $"Program: {cboProgram.Text}",
            $"Gender: {cboGender.Text}",
            $"Age: {numAge.Value}",
            $"Birthday: {dtpBirthday.Value:yyyy-MM-dd}",
            $"Contact No.: {txtContactNo.Text.Trim()}"
        ];

        string fullPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), studentNo + ".txt");
        try
        {
            using StreamWriter outputFile = new(fullPath, false, Encoding.UTF8);
            foreach (string content in registration)
            {
                outputFile.WriteLine(content);
                Console.WriteLine(content);
            }
            MessageBox.Show($"Registration file created successfully.\n\n{fullPath}", "Registration saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"The registration file could not be created.\n\n{ex.Message}", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
