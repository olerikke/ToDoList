using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Projects = new System.Windows.Forms.ListBox();
            this.CreateProject = new System.Windows.Forms.Button();
            this.NameProject = new System.Windows.Forms.TextBox();
            this.GetListOfProjects = new System.Windows.Forms.Button();
            this.ListOfTasks = new System.Windows.Forms.ListBox();
            this.ArchiveProject = new System.Windows.Forms.Button();
            this.ChosenProject = new System.Windows.Forms.TextBox();
            this.AddTask = new System.Windows.Forms.Button();
            this.NameTask = new System.Windows.Forms.TextBox();
            this.DeleteTask = new System.Windows.Forms.Button();
            this.ListArhcive = new System.Windows.Forms.Button();
            this.DeleteArchivedProject = new System.Windows.Forms.Button();
            this.ListProjects = new System.Windows.Forms.TextBox();
            this.ListArchived = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Projects
            // 
            this.Projects.BackColor = System.Drawing.Color.YellowGreen;
            this.Projects.FormattingEnabled = true;
            this.Projects.ItemHeight = 22;
            this.Projects.Location = new System.Drawing.Point(50, 196);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(399, 510);
            this.Projects.TabIndex = 0;
            this.Projects.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Projects_MouseClick);
            // 
            // CreateProject
            // 
            this.CreateProject.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CreateProject.Location = new System.Drawing.Point(50, 62);
            this.CreateProject.Name = "CreateProject";
            this.CreateProject.Size = new System.Drawing.Size(192, 35);
            this.CreateProject.TabIndex = 1;
            this.CreateProject.Text = "Create Project";
            this.CreateProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CreateProject.UseVisualStyleBackColor = false;
            this.CreateProject.Click += new System.EventHandler(this.CreateProject_Click_1);
            // 
            // NameProject
            // 
            this.NameProject.BackColor = System.Drawing.Color.YellowGreen;
            this.NameProject.Location = new System.Drawing.Point(50, 21);
            this.NameProject.Name = "NameProject";
            this.NameProject.Size = new System.Drawing.Size(399, 28);
            this.NameProject.TabIndex = 2;
            // 
            // GetListOfProjects
            // 
            this.GetListOfProjects.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.GetListOfProjects.Location = new System.Drawing.Point(248, 148);
            this.GetListOfProjects.Name = "GetListOfProjects";
            this.GetListOfProjects.Size = new System.Drawing.Size(192, 35);
            this.GetListOfProjects.TabIndex = 3;
            this.GetListOfProjects.Text = "List projects";
            this.GetListOfProjects.UseVisualStyleBackColor = false;
            this.GetListOfProjects.Click += new System.EventHandler(this.GetListOfProjects_Click_1);
            // 
            // ListOfTasks
            // 
            this.ListOfTasks.BackColor = System.Drawing.Color.YellowGreen;
            this.ListOfTasks.FormattingEnabled = true;
            this.ListOfTasks.ItemHeight = 22;
            this.ListOfTasks.Location = new System.Drawing.Point(635, 110);
            this.ListOfTasks.Name = "ListOfTasks";
            this.ListOfTasks.Size = new System.Drawing.Size(625, 510);
            this.ListOfTasks.TabIndex = 4;
            this.ListOfTasks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListOfTasks_OneClick);
            // 
            // ArchiveProject
            // 
            this.ArchiveProject.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ArchiveProject.Location = new System.Drawing.Point(50, 773);
            this.ArchiveProject.Name = "ArchiveProject";
            this.ArchiveProject.Size = new System.Drawing.Size(195, 35);
            this.ArchiveProject.TabIndex = 5;
            this.ArchiveProject.Text = "Archive project";
            this.ArchiveProject.UseVisualStyleBackColor = false;
            this.ArchiveProject.Click += new System.EventHandler(this.ArchiveProject_click_1);
            // 
            // ChosenProject
            // 
            this.ChosenProject.BackColor = System.Drawing.Color.YellowGreen;
            this.ChosenProject.Location = new System.Drawing.Point(635, 62);
            this.ChosenProject.Name = "ChosenProject";
            this.ChosenProject.Size = new System.Drawing.Size(625, 28);
            this.ChosenProject.TabIndex = 6;
            // 
            // AddTask
            // 
            this.AddTask.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddTask.Location = new System.Drawing.Point(637, 639);
            this.AddTask.Name = "AddTask";
            this.AddTask.Size = new System.Drawing.Size(120, 35);
            this.AddTask.TabIndex = 7;
            this.AddTask.Text = "Add task";
            this.AddTask.UseVisualStyleBackColor = false;
            this.AddTask.Click += new System.EventHandler(this.AddTask_Click_1);
            // 
            // NameTask
            // 
            this.NameTask.BackColor = System.Drawing.Color.YellowGreen;
            this.NameTask.Location = new System.Drawing.Point(637, 689);
            this.NameTask.Name = "NameTask";
            this.NameTask.Size = new System.Drawing.Size(623, 28);
            this.NameTask.TabIndex = 8;
            // 
            // DeleteTask
            // 
            this.DeleteTask.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.DeleteTask.Location = new System.Drawing.Point(788, 639);
            this.DeleteTask.Name = "DeleteTask";
            this.DeleteTask.Size = new System.Drawing.Size(162, 35);
            this.DeleteTask.TabIndex = 9;
            this.DeleteTask.Text = "Delete task";
            this.DeleteTask.UseVisualStyleBackColor = false;
            this.DeleteTask.Click += new System.EventHandler(this.DeleteTask_Click_1);
            // 
            // ListArhcive
            // 
            this.ListArhcive.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ListArhcive.Location = new System.Drawing.Point(254, 728);
            this.ListArhcive.Name = "ListArhcive";
            this.ListArhcive.Size = new System.Drawing.Size(195, 33);
            this.ListArhcive.TabIndex = 10;
            this.ListArhcive.Text = "List arhcive";
            this.ListArhcive.UseVisualStyleBackColor = false;
            this.ListArhcive.Click += new System.EventHandler(this.ListArhcive_Click_1);
            // 
            // DeleteArchivedProject
            // 
            this.DeleteArchivedProject.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.DeleteArchivedProject.Location = new System.Drawing.Point(254, 775);
            this.DeleteArchivedProject.Name = "DeleteArchivedProject";
            this.DeleteArchivedProject.Size = new System.Drawing.Size(225, 33);
            this.DeleteArchivedProject.TabIndex = 11;
            this.DeleteArchivedProject.Text = "Delete archived project";
            this.DeleteArchivedProject.UseVisualStyleBackColor = false;
            this.DeleteArchivedProject.Click += new System.EventHandler(this.DeleteArchivedProject_Click_1);
            // 
            // ListProjects
            // 
            this.ListProjects.BackColor = System.Drawing.Color.YellowGreen;
            this.ListProjects.Location = new System.Drawing.Point(50, 151);
            this.ListProjects.Name = "ListProjects";
            this.ListProjects.Size = new System.Drawing.Size(192, 28);
            this.ListProjects.TabIndex = 12;
            // 
            // ListArchived
            // 
            this.ListArchived.BackColor = System.Drawing.Color.YellowGreen;
            this.ListArchived.Location = new System.Drawing.Point(50, 728);
            this.ListArchived.Name = "ListArchived";
            this.ListArchived.Size = new System.Drawing.Size(195, 28);
            this.ListArchived.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1400, 816);
            this.Controls.Add(this.ListArchived);
            this.Controls.Add(this.ListProjects);
            this.Controls.Add(this.DeleteArchivedProject);
            this.Controls.Add(this.ListArhcive);
            this.Controls.Add(this.DeleteTask);
            this.Controls.Add(this.NameTask);
            this.Controls.Add(this.AddTask);
            this.Controls.Add(this.ChosenProject);
            this.Controls.Add(this.ArchiveProject);
            this.Controls.Add(this.ListOfTasks);
            this.Controls.Add(this.GetListOfProjects);
            this.Controls.Add(this.NameProject);
            this.Controls.Add(this.CreateProject);
            this.Controls.Add(this.Projects);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "ToDoList";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DeleteArchivedProject_Click_1(object sender, EventArgs e)
        {
            
            var projectRepository = new ProjectRepository();
            string[] files =  projectRepository.DeleteFile(@"C:/Users/z6one/TodoList/Archive", ChosenProject.Text);

            Projects.Items.Clear();
            ChosenProject.Text = null;
            ListOfTasks.Items.Clear();

            for (int iFile = 0; iFile < files.Length; iFile++)
            {
                Projects.Items.Add(Path.GetFileName(files[iFile]));
            }
        }

        private void ListArhcive_Click_1(object sender, EventArgs e)
        {

            ListOfTasks.Items.Clear();
            ListProjects.Text = null;
            ListArchived.Text = "Archived";

            var projectRepository = new ProjectRepository();
            string[] files = projectRepository.FileRetrive(@"C:/Users/z6one/TodoList/Archive/");


            Projects.Items.Clear();

            for (int iFile = 0; iFile < files.Length; iFile++)
            {
                Projects.Items.Add(Path.GetFileName(files[iFile]));

            }
        }

        private void ListOfTasks_OneClick(object sender, MouseEventArgs e)
        {
            if (ListOfTasks.SelectedItem != null)
            {
                NameTask.Text = ListOfTasks.SelectedItem.ToString();
            }
        }

        private void DeleteTask_Click_1(object sender, EventArgs e)
        {
            ListOfTasks.Items.Remove(NameTask.Text);

            string pathstring = @"C:/Users/z6one/TodoList/";

            if (ListArchived.Text == "Archived")
            {
                pathstring = @"C:/Users/z6one/TodoList/Archive/";
            }

            var projectRepository = new ProjectRepository();
            projectRepository.ChangeTaskList(ListOfTasks, pathstring, ChosenProject.Text);

            NameTask.Text = string.Empty;
        }

        private void AddTask_Click_1(object sender, EventArgs e)
        {

            ListOfTasks.Items.Add(NameTask.Text);

            string pathstring = @"C:/Users/z6one/TodoList/";

            if (ListArchived.Text == "Archived")
            {
                pathstring = @"C:/Users/z6one/TodoList/Archive/";
            }

            var projectRepository = new ProjectRepository();
            projectRepository.ChangeTaskList(ListOfTasks, pathstring, ChosenProject.Text);

            NameTask.Text = string.Empty;


        }

        private void Projects_MouseClick(object sender, MouseEventArgs e)
        {
            if (Projects.SelectedItem != null)
            {
                ChosenProject.Text = Projects.SelectedItem.ToString();

                ListOfTasks.Items.Clear();

               
                string foldername = @"C:/Users/z6one/TodoList/";

                bool v = ListArchived.Text == "Archived";
                if (v)
                {
                    foldername = @"C:/Users/z6one/TodoList/Archive/";
                }

                var projectRepository = new ProjectRepository();
                ListBox listbox1 = projectRepository.ListTaskList(foldername, ChosenProject.Text);


                object[] objCollection = new object[listbox1.Items.Count];
                listbox1.Items.CopyTo(objCollection,0);

                ListOfTasks.Items.AddRange(objCollection);

            }
        }



        #endregion

        private void Form1_Shown(object sender, System.EventArgs e)
        {
            GetListOfProjects.PerformClick();
        }

        private void CreateProject_Click_1(object sender, System.EventArgs e)
        {
 
            var projectRepository = new ProjectRepository();
            projectRepository.CreateFile(@"C:/Users/z6one/TodoList", NameProject.Text);

            GetListOfProjects.PerformClick();

            NameProject.Text = string.Empty;
        }

        private void GetListOfProjects_Click_1(object sender, System.EventArgs e)
        {
            ListProjects.Text = "Projects";
            ListArchived.Text = null;
            ListOfTasks.Items.Clear();

            var projectRepository = new ProjectRepository();
            string[] files = projectRepository.FileRetrive(@"C:/Users/z6one/TodoList/");


            Projects.Items.Clear();

            for (int iFile = 0; iFile < files.Length; iFile++)
            {
                Projects.Items.Add(Path.GetFileName(files[iFile]));

            }

        }
        private void ArchiveProject_click_1(object sender, EventArgs e)
        {
            string foldernamefrom = @"C:/Users/z6one/TodoList";

            string foldernameTo = @"C:/Users/z6one/TodoList/Archive";

            string destfile = System.IO.Path.Combine(foldernameTo, ChosenProject.Text);
            string pathString = System.IO.Path.Combine(foldernamefrom, ChosenProject.Text);

            var projectRepository = new ProjectRepository();
            projectRepository.CopyFile(pathString, destfile);



            //Delete file in main folder

            var projectRepository2 = new ProjectRepository();
            string[] files = projectRepository2.DeleteFile(@"C:/Users/z6one/TodoList", ChosenProject.Text);



            Projects.Items.Clear();
            ChosenProject.Text = null;
            ListOfTasks.Items.Clear();



            for (int iFile = 0; iFile < files.Length ; iFile++)
            {
                Projects.Items.Add(Path.GetFileName(files[iFile]));
            }

        }
      


        private System.Windows.Forms.ListBox Projects;
        private System.Windows.Forms.Button CreateProject;
        private System.Windows.Forms.TextBox NameProject;
        private Button GetListOfProjects;
        private ListBox ListOfTasks;
        private Button ArchiveProject;
        private TextBox ChosenProject;
        private Button AddTask;
        private TextBox NameTask;
        private Button DeleteTask;
        private Button ListArhcive;
        private Button DeleteArchivedProject;
        private TextBox ListProjects;
        private TextBox ListArchived;
    }
}

