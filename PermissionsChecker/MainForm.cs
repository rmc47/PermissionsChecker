using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PermissionsChecker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void m_BrowsePath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                DialogResult dr = fbd.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    m_Path.Text = fbd.SelectedPath;
                }
            }
        }

        private void m_Go_Click(object sender, EventArgs e)
        {
            m_Output.Clear();
            m_Status.Text = "Starting";
            string path = m_Path.Text;
            string target = m_Target.Text;
            var thread = new Thread(_ => Search(path, target));
            thread.IsBackground = true;
            thread.Start();
        }

        private void Search(string topLevelPath, string target)
        {
            Queue<string> foldersToProcess = new Queue<string>();
            foldersToProcess.Enqueue(topLevelPath);
            while (foldersToProcess.Count > 0)
            {
                ProcessFolder(foldersToProcess.Dequeue(), target, foldersToProcess);
            }
            SetStatus("Complete");
        }

        private void ProcessFolder(string path, string target, Queue<string> foldersToProcess)
        {
            SetStatus(path);
            try
            {
                var acl = Directory.GetAccessControl(path);
                foreach (FileSystemAccessRule aclEntry in acl.GetAccessRules(true, false, typeof(NTAccount)))
                {
                    if (aclEntry.IdentityReference.Value.Equals(target, StringComparison.InvariantCultureIgnoreCase))
                    {
                        AppendOutputLine(path);
                    }
                }
                foreach (string subfolder in Directory.EnumerateDirectories(path, "*", SearchOption.TopDirectoryOnly))
                {
                    foldersToProcess.Enqueue(subfolder);
                }
            }
            catch
            {

            }
        }

        private void SetStatus(string status)
        {
            if (Disposing || IsDisposed || !IsHandleCreated)
                return;
            Invoke(new MethodInvoker(() =>
            {
                m_Status.Text = status;
            }));
        }
        private void AppendOutputLine(string output)
        {
            if (Disposing || IsDisposed || !IsHandleCreated)
                return;
            Invoke(new MethodInvoker(() =>
            {
                m_Output.AppendText(output + "\r\n");
            }));
        }
    }
}
