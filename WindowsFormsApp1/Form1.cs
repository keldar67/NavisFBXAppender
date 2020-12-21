using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

//Navisworks
using Autodesk.Navisworks.Api.Automation;
using System.ComponentModel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //A Navisworks Application to drive the appending of any FBX Files.
        NavisworksApplication nwApp;
        int filecount;
        
        public Form1()
        {
            InitializeComponent();

            //Create and open the Navisworks Application.
            nwApp = new Autodesk.Navisworks.Api.Automation.NavisworksApplication();
            nwApp.Visible = true;
            lblCount.Text = "0";
        }

        private void BtnGetFBXFiles_MouseUp(object sender, MouseEventArgs e)
        {
            DirectoryInfo theroot = new DirectoryInfo("P:/20/2005007.000/Admin/03.0 Consultants/3.23 Land Surveyor/B&F/201221_FBX Files/036527 308 Queen Street FBX/Data");

            DirectoryInfo[] dirs = theroot.GetDirectories();

            var fbxlist = new List<FileInfo>();

            foreach (DirectoryInfo dir in dirs)
            {
                
                //Grab each of the FBX folders
                var fbxfolder = new DirectoryInfo(theroot.FullName + "/" + dir.Name+ "/");

                //Look in each of the folders and grab any FBX files.
                var fbxfiles = fbxfolder.GetFiles("*.fbx");


                foreach (FileInfo afile in fbxfiles)
                {
                    txtFileNames.AppendText((txtFileNames.Text == "") ? afile.Name : $"{Environment.NewLine + afile.Name}");
                    
                    //Append the current FBX file to the Federated Navisworks models
                    nwApp.AppendFile(afile.FullName);

                    //Increment the counter on the form
                    filecount++;
                    lblCount.Text = filecount.ToString();
                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            //Close Navisworks
            //nwApp.Dispose();
            base.OnClosing(e);
        }

        private void BtnClose_MouseUp(object sender, MouseEventArgs e)
        {
            //Close Navisworks
            nwApp.Dispose();
            base.Close();
        }
    }
}
