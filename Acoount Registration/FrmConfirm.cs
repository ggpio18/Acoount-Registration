using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Acoount_Registration.StudentInfoClass;

namespace Acoount_Registration
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelContactNo, DelStudentNo;

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

       
        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudentNo = new DelegateNumber(StudentInfoClass.GetStudentNo);

            //label
            lblProgram.Text = DelProgram(StudentInfoClass.Program);
            lblLastName.Text = DelLastName(StudentInfoClass.LastName);
            lblFirstName.Text = DelFirstName(StudentInfoClass.FirstName);
            lblMiddleName.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblAddress.Text = DelAddress(StudentInfoClass.Address);

            lblAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lblContactNo.Text = DelContactNo(StudentInfoClass.ContactNo).ToString();
            lblStudentNo.Text = DelStudentNo(StudentInfoClass.StudentNo).ToString();
        }
    }
}
