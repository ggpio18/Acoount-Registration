using static Acoount_Registration.StudentInfoClass;

namespace Acoount_Registration
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.LastName = (txtLastName.Text);
            StudentInfoClass.FirstName = (txtFirstName.Text);
            StudentInfoClass.MiddleName = (txtMiddleName.Text);
            StudentInfoClass.Program = (txtProgram.Text);
            StudentInfoClass.Address = (txtAddress.Text.ToString());

            StudentInfoClass.Age = long.Parse(txtAge.Text);
            StudentInfoClass.StudentNo = long.Parse(txtStudentNo.Text);
            StudentInfoClass.ContactNo = long.Parse(txtContactNo.Text);

            FrmConfirm frm2 = new FrmConfirm();
            frm2.ShowDialog();

        }
    }
}