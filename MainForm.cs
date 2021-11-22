namespace StartExternalApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // only start, if an application was selected first
            if (!String.IsNullOrEmpty(SelectApplicationOpenFileDialog.FileName))
            {
                // start the selected application
                System.Diagnostics.Process.Start(SelectApplicationOpenFileDialog.FileName);   
            }
            else
            {
                MessageBox.Show("Please select an application first.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectApplicationButton_Click(object sender, EventArgs e)
        {
            // set initial directory to Program Files
            SelectApplicationOpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            // show OpenFileDialog to select desired application
            DialogResult result = SelectApplicationOpenFileDialog.ShowDialog(this);
            // only proceed, if the OpenFileDialog was not closed using abort
            if (result == DialogResult.OK)
            {
                // display the selected application path
                ApplicationPathTextBox.Text = SelectApplicationOpenFileDialog.FileName;
            }
        }
    }
}