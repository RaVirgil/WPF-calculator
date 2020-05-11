using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MVP_Tema1
{

    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();
            GetProcessorInfo();
        }

        private void txtLink_Click(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.ToString());
        }

        private void GetProcessorInfo()
        {
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_ComputerSystem").Get())
            {
                txtSystemInfo.AppendText("\nNumber of Physical Processors: " + item["NumberOfProcessors"].ToString());
                txtSystemInfo.AppendText("\nNumber of Logical Processors: " + item["NumberOfLogicalProcessors"].ToString());
            }

            int coreCount = 0;

            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                coreCount += int.Parse(item["NumberOfCores"].ToString());
            }
            txtSystemInfo.AppendText("\nNumber of Cores: " + coreCount.ToString());
        }

        private void txtSystemInfo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
