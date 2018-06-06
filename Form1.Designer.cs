namespace WindowsFormsApp1
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
            System.Windows.Forms.Label F1lblFileXML;
            this.F1TabControl = new System.Windows.Forms.TabControl();
            this.F1Tab = new System.Windows.Forms.TabPage();
            this.F1lblGenerateListResultMessage = new System.Windows.Forms.Label();
            this.F1btnGenerateList = new System.Windows.Forms.Button();
            this.F1btnBrowseGenerateList = new System.Windows.Forms.Button();
            this.F1tbGenerateList = new System.Windows.Forms.TextBox();
            this.F1lbGenerateList = new System.Windows.Forms.Label();
            this.F1tbFileXML = new System.Windows.Forms.TextBox();
            this.F1btnBrowseFileXML = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.F2lblGenerateDummiesResultMessage = new System.Windows.Forms.Label();
            this.F2btnGenerateDummies = new System.Windows.Forms.Button();
            this.F2btnBrowseDummyPath = new System.Windows.Forms.Button();
            this.F2btnBrowseListFile = new System.Windows.Forms.Button();
            this.F2tbDummyFolderPath = new System.Windows.Forms.TextBox();
            this.F2tbListFilePath = new System.Windows.Forms.TextBox();
            this.F2lblDummyFolder = new System.Windows.Forms.Label();
            this.F2lblListPath = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.F3btnDummyFolderPath = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.F3btnFaltaFilePath = new System.Windows.Forms.Button();
            this.F3btnSobraFilePath = new System.Windows.Forms.Button();
            this.F3btnListFilePath = new System.Windows.Forms.Button();
            this.F3tbFaltaFilePath = new System.Windows.Forms.TextBox();
            this.F3tbSobraFilePath = new System.Windows.Forms.TextBox();
            this.F3tbDummyFolderPath = new System.Windows.Forms.TextBox();
            this.F3tbListFilePath = new System.Windows.Forms.TextBox();
            this.F3lblGenerateFilesResultMessage = new System.Windows.Forms.Label();
            this.F3lblFaltaFilePath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.F3lbDummyFolderPath = new System.Windows.Forms.Label();
            this.F3lbListFilePath = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.F1ofdFileXMLPath = new System.Windows.Forms.OpenFileDialog();
            this.F1ofdListPath = new System.Windows.Forms.SaveFileDialog();
            this.F2ofdListFilePath = new System.Windows.Forms.OpenFileDialog();
            this.F2ofdDummyFolderPath2 = new System.Windows.Forms.FolderBrowserDialog();
            this.F3ofdListPath = new System.Windows.Forms.OpenFileDialog();
            this.F3ofdDummyFolderPath = new System.Windows.Forms.FolderBrowserDialog();
            this.F3osdSobraPath = new System.Windows.Forms.SaveFileDialog();
            this.F3osdFaltaPath = new System.Windows.Forms.SaveFileDialog();
            this.F2ofdDummyFolderPath = new System.Windows.Forms.FolderBrowserDialog();
            F1lblFileXML = new System.Windows.Forms.Label();
            this.F1TabControl.SuspendLayout();
            this.F1Tab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // F1lblFileXML
            // 
            F1lblFileXML.AutoSize = true;
            F1lblFileXML.Location = new System.Drawing.Point(32, 63);
            F1lblFileXML.Name = "F1lblFileXML";
            F1lblFileXML.Size = new System.Drawing.Size(102, 20);
            F1lblFileXML.TabIndex = 2;
            F1lblFileXML.Text = "Archivo XML:";
            // 
            // F1TabControl
            // 
            this.F1TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.F1TabControl.Controls.Add(this.F1Tab);
            this.F1TabControl.Controls.Add(this.tabPage2);
            this.F1TabControl.Controls.Add(this.tabPage3);
            this.F1TabControl.Controls.Add(this.tabPage4);
            this.F1TabControl.Controls.Add(this.tabPage5);
            this.F1TabControl.Location = new System.Drawing.Point(12, 12);
            this.F1TabControl.Name = "F1TabControl";
            this.F1TabControl.SelectedIndex = 0;
            this.F1TabControl.Size = new System.Drawing.Size(1052, 526);
            this.F1TabControl.TabIndex = 0;
            // 
            // F1Tab
            // 
            this.F1Tab.Controls.Add(this.F1lblGenerateListResultMessage);
            this.F1Tab.Controls.Add(this.F1btnGenerateList);
            this.F1Tab.Controls.Add(this.F1btnBrowseGenerateList);
            this.F1Tab.Controls.Add(this.F1tbGenerateList);
            this.F1Tab.Controls.Add(this.F1lbGenerateList);
            this.F1Tab.Controls.Add(F1lblFileXML);
            this.F1Tab.Controls.Add(this.F1tbFileXML);
            this.F1Tab.Controls.Add(this.F1btnBrowseFileXML);
            this.F1Tab.Location = new System.Drawing.Point(4, 29);
            this.F1Tab.Name = "F1Tab";
            this.F1Tab.Padding = new System.Windows.Forms.Padding(3);
            this.F1Tab.Size = new System.Drawing.Size(1044, 493);
            this.F1Tab.TabIndex = 0;
            this.F1Tab.Text = "Crear Lista desde XML";
            this.F1Tab.UseVisualStyleBackColor = true;
            // 
            // F1lblGenerateListResultMessage
            // 
            this.F1lblGenerateListResultMessage.AutoSize = true;
            this.F1lblGenerateListResultMessage.Location = new System.Drawing.Point(323, 167);
            this.F1lblGenerateListResultMessage.Name = "F1lblGenerateListResultMessage";
            this.F1lblGenerateListResultMessage.Size = new System.Drawing.Size(0, 20);
            this.F1lblGenerateListResultMessage.TabIndex = 7;
            // 
            // F1btnGenerateList
            // 
            this.F1btnGenerateList.Location = new System.Drawing.Point(140, 157);
            this.F1btnGenerateList.Name = "F1btnGenerateList";
            this.F1btnGenerateList.Size = new System.Drawing.Size(157, 40);
            this.F1btnGenerateList.TabIndex = 6;
            this.F1btnGenerateList.Text = "Generar Lista";
            this.F1btnGenerateList.UseVisualStyleBackColor = true;
            this.F1btnGenerateList.Click += new System.EventHandler(this.F1btnGenerateList_Click);
            // 
            // F1btnBrowseGenerateList
            // 
            this.F1btnBrowseGenerateList.Location = new System.Drawing.Point(666, 101);
            this.F1btnBrowseGenerateList.Name = "F1btnBrowseGenerateList";
            this.F1btnBrowseGenerateList.Size = new System.Drawing.Size(75, 29);
            this.F1btnBrowseGenerateList.TabIndex = 5;
            this.F1btnBrowseGenerateList.Text = "Browse";
            this.F1btnBrowseGenerateList.UseVisualStyleBackColor = true;
            this.F1btnBrowseGenerateList.Click += new System.EventHandler(this.F1btnBrowseGenerateList_Click);
            // 
            // F1tbGenerateList
            // 
            this.F1tbGenerateList.Location = new System.Drawing.Point(140, 102);
            this.F1tbGenerateList.Name = "F1tbGenerateList";
            this.F1tbGenerateList.ReadOnly = true;
            this.F1tbGenerateList.Size = new System.Drawing.Size(502, 26);
            this.F1tbGenerateList.TabIndex = 4;
            // 
            // F1lbGenerateList
            // 
            this.F1lbGenerateList.AutoSize = true;
            this.F1lbGenerateList.Location = new System.Drawing.Point(36, 105);
            this.F1lbGenerateList.Name = "F1lbGenerateList";
            this.F1lbGenerateList.Size = new System.Drawing.Size(100, 20);
            this.F1lbGenerateList.TabIndex = 3;
            this.F1lbGenerateList.Text = "Generar lista";
            // 
            // F1tbFileXML
            // 
            this.F1tbFileXML.AllowDrop = true;
            this.F1tbFileXML.Location = new System.Drawing.Point(140, 60);
            this.F1tbFileXML.Name = "F1tbFileXML";
            this.F1tbFileXML.ReadOnly = true;
            this.F1tbFileXML.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.F1tbFileXML.Size = new System.Drawing.Size(502, 26);
            this.F1tbFileXML.TabIndex = 1;
            // 
            // F1btnBrowseFileXML
            // 
            this.F1btnBrowseFileXML.Location = new System.Drawing.Point(666, 60);
            this.F1btnBrowseFileXML.Name = "F1btnBrowseFileXML";
            this.F1btnBrowseFileXML.Size = new System.Drawing.Size(75, 30);
            this.F1btnBrowseFileXML.TabIndex = 0;
            this.F1btnBrowseFileXML.Text = "Browse";
            this.F1btnBrowseFileXML.UseVisualStyleBackColor = true;
            this.F1btnBrowseFileXML.Click += new System.EventHandler(this.F1btnBrowseFileXML_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.F2lblGenerateDummiesResultMessage);
            this.tabPage2.Controls.Add(this.F2btnGenerateDummies);
            this.tabPage2.Controls.Add(this.F2btnBrowseDummyPath);
            this.tabPage2.Controls.Add(this.F2btnBrowseListFile);
            this.tabPage2.Controls.Add(this.F2tbDummyFolderPath);
            this.tabPage2.Controls.Add(this.F2tbListFilePath);
            this.tabPage2.Controls.Add(this.F2lblDummyFolder);
            this.tabPage2.Controls.Add(this.F2lblListPath);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1044, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crear Dummies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // F2lblGenerateDummiesResultMessage
            // 
            this.F2lblGenerateDummiesResultMessage.AutoSize = true;
            this.F2lblGenerateDummiesResultMessage.Location = new System.Drawing.Point(407, 170);
            this.F2lblGenerateDummiesResultMessage.Name = "F2lblGenerateDummiesResultMessage";
            this.F2lblGenerateDummiesResultMessage.Size = new System.Drawing.Size(0, 20);
            this.F2lblGenerateDummiesResultMessage.TabIndex = 7;
            // 
            // F2btnGenerateDummies
            // 
            this.F2btnGenerateDummies.Location = new System.Drawing.Point(212, 161);
            this.F2btnGenerateDummies.Name = "F2btnGenerateDummies";
            this.F2btnGenerateDummies.Size = new System.Drawing.Size(158, 38);
            this.F2btnGenerateDummies.TabIndex = 6;
            this.F2btnGenerateDummies.Text = "Crear Dummies";
            this.F2btnGenerateDummies.UseVisualStyleBackColor = true;
            this.F2btnGenerateDummies.Click += new System.EventHandler(this.F2btnGenerateDummies_Click);
            // 
            // F2btnBrowseDummyPath
            // 
            this.F2btnBrowseDummyPath.Location = new System.Drawing.Point(636, 100);
            this.F2btnBrowseDummyPath.Name = "F2btnBrowseDummyPath";
            this.F2btnBrowseDummyPath.Size = new System.Drawing.Size(75, 34);
            this.F2btnBrowseDummyPath.TabIndex = 5;
            this.F2btnBrowseDummyPath.Text = "Browse";
            this.F2btnBrowseDummyPath.UseVisualStyleBackColor = true;
            this.F2btnBrowseDummyPath.Click += new System.EventHandler(this.F2btnBrowseDummyPath_Click);
            // 
            // F2btnBrowseListFile
            // 
            this.F2btnBrowseListFile.Location = new System.Drawing.Point(636, 61);
            this.F2btnBrowseListFile.Name = "F2btnBrowseListFile";
            this.F2btnBrowseListFile.Size = new System.Drawing.Size(75, 33);
            this.F2btnBrowseListFile.TabIndex = 4;
            this.F2btnBrowseListFile.Text = "Browse";
            this.F2btnBrowseListFile.UseVisualStyleBackColor = true;
            this.F2btnBrowseListFile.Click += new System.EventHandler(this.F2btnBrowseListFile_Click);
            // 
            // F2tbDummyFolderPath
            // 
            this.F2tbDummyFolderPath.Location = new System.Drawing.Point(212, 101);
            this.F2tbDummyFolderPath.Name = "F2tbDummyFolderPath";
            this.F2tbDummyFolderPath.ReadOnly = true;
            this.F2tbDummyFolderPath.Size = new System.Drawing.Size(398, 26);
            this.F2tbDummyFolderPath.TabIndex = 3;
            // 
            // F2tbListFilePath
            // 
            this.F2tbListFilePath.Location = new System.Drawing.Point(212, 64);
            this.F2tbListFilePath.Name = "F2tbListFilePath";
            this.F2tbListFilePath.ReadOnly = true;
            this.F2tbListFilePath.Size = new System.Drawing.Size(398, 26);
            this.F2tbListFilePath.TabIndex = 2;
            // 
            // F2lblDummyFolder
            // 
            this.F2lblDummyFolder.AutoSize = true;
            this.F2lblDummyFolder.Location = new System.Drawing.Point(47, 107);
            this.F2lblDummyFolder.Name = "F2lblDummyFolder";
            this.F2lblDummyFolder.Size = new System.Drawing.Size(159, 20);
            this.F2lblDummyFolder.TabIndex = 1;
            this.F2lblDummyFolder.Text = "Carpeta de Dummies";
            // 
            // F2lblListPath
            // 
            this.F2lblListPath.AutoSize = true;
            this.F2lblListPath.Location = new System.Drawing.Point(163, 65);
            this.F2lblListPath.Name = "F2lblListPath";
            this.F2lblListPath.Size = new System.Drawing.Size(43, 20);
            this.F2lblListPath.TabIndex = 0;
            this.F2lblListPath.Text = "Lista";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.F3btnDummyFolderPath);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.F3btnFaltaFilePath);
            this.tabPage3.Controls.Add(this.F3btnSobraFilePath);
            this.tabPage3.Controls.Add(this.F3btnListFilePath);
            this.tabPage3.Controls.Add(this.F3tbFaltaFilePath);
            this.tabPage3.Controls.Add(this.F3tbSobraFilePath);
            this.tabPage3.Controls.Add(this.F3tbDummyFolderPath);
            this.tabPage3.Controls.Add(this.F3tbListFilePath);
            this.tabPage3.Controls.Add(this.F3lblGenerateFilesResultMessage);
            this.tabPage3.Controls.Add(this.F3lblFaltaFilePath);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.F3lbDummyFolderPath);
            this.tabPage3.Controls.Add(this.F3lbListFilePath);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1044, 493);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Comparar Directorio con lista";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // F3btnDummyFolderPath
            // 
            this.F3btnDummyFolderPath.Location = new System.Drawing.Point(584, 88);
            this.F3btnDummyFolderPath.Name = "F3btnDummyFolderPath";
            this.F3btnDummyFolderPath.Size = new System.Drawing.Size(75, 26);
            this.F3btnDummyFolderPath.TabIndex = 14;
            this.F3btnDummyFolderPath.Text = "Browse";
            this.F3btnDummyFolderPath.UseVisualStyleBackColor = true;
            this.F3btnDummyFolderPath.Click += new System.EventHandler(this.F3btnDummyFolderPath_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(149, 223);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 48);
            this.button5.TabIndex = 13;
            this.button5.Text = "Comparar y generar archivos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.F3btnGenerateSobraFalta_Click);
            // 
            // F3btnFaltaFilePath
            // 
            this.F3btnFaltaFilePath.Location = new System.Drawing.Point(584, 162);
            this.F3btnFaltaFilePath.Name = "F3btnFaltaFilePath";
            this.F3btnFaltaFilePath.Size = new System.Drawing.Size(75, 26);
            this.F3btnFaltaFilePath.TabIndex = 12;
            this.F3btnFaltaFilePath.Text = "Browse";
            this.F3btnFaltaFilePath.UseVisualStyleBackColor = true;
            this.F3btnFaltaFilePath.Click += new System.EventHandler(this.F3btnFaltaFilePath_Click);
            // 
            // F3btnSobraFilePath
            // 
            this.F3btnSobraFilePath.Location = new System.Drawing.Point(584, 123);
            this.F3btnSobraFilePath.Name = "F3btnSobraFilePath";
            this.F3btnSobraFilePath.Size = new System.Drawing.Size(75, 26);
            this.F3btnSobraFilePath.TabIndex = 11;
            this.F3btnSobraFilePath.Text = "Browse";
            this.F3btnSobraFilePath.UseVisualStyleBackColor = true;
            this.F3btnSobraFilePath.Click += new System.EventHandler(this.F3btnSobraFilePath_Click);
            // 
            // F3btnListFilePath
            // 
            this.F3btnListFilePath.Location = new System.Drawing.Point(584, 48);
            this.F3btnListFilePath.Name = "F3btnListFilePath";
            this.F3btnListFilePath.Size = new System.Drawing.Size(75, 26);
            this.F3btnListFilePath.TabIndex = 9;
            this.F3btnListFilePath.Text = "Browse";
            this.F3btnListFilePath.UseVisualStyleBackColor = true;
            this.F3btnListFilePath.Click += new System.EventHandler(this.F3btnListFilePath_Click);
            // 
            // F3tbFaltaFilePath
            // 
            this.F3tbFaltaFilePath.Location = new System.Drawing.Point(149, 162);
            this.F3tbFaltaFilePath.Name = "F3tbFaltaFilePath";
            this.F3tbFaltaFilePath.ReadOnly = true;
            this.F3tbFaltaFilePath.Size = new System.Drawing.Size(421, 26);
            this.F3tbFaltaFilePath.TabIndex = 8;
            // 
            // F3tbSobraFilePath
            // 
            this.F3tbSobraFilePath.Location = new System.Drawing.Point(149, 123);
            this.F3tbSobraFilePath.Name = "F3tbSobraFilePath";
            this.F3tbSobraFilePath.ReadOnly = true;
            this.F3tbSobraFilePath.Size = new System.Drawing.Size(421, 26);
            this.F3tbSobraFilePath.TabIndex = 7;
            // 
            // F3tbDummyFolderPath
            // 
            this.F3tbDummyFolderPath.Location = new System.Drawing.Point(149, 88);
            this.F3tbDummyFolderPath.Name = "F3tbDummyFolderPath";
            this.F3tbDummyFolderPath.ReadOnly = true;
            this.F3tbDummyFolderPath.Size = new System.Drawing.Size(421, 26);
            this.F3tbDummyFolderPath.TabIndex = 6;
            // 
            // F3tbListFilePath
            // 
            this.F3tbListFilePath.Location = new System.Drawing.Point(149, 48);
            this.F3tbListFilePath.Name = "F3tbListFilePath";
            this.F3tbListFilePath.ReadOnly = true;
            this.F3tbListFilePath.Size = new System.Drawing.Size(421, 26);
            this.F3tbListFilePath.TabIndex = 5;
            // 
            // F3lblGenerateFilesResultMessage
            // 
            this.F3lblGenerateFilesResultMessage.AutoSize = true;
            this.F3lblGenerateFilesResultMessage.Location = new System.Drawing.Point(424, 251);
            this.F3lblGenerateFilesResultMessage.Name = "F3lblGenerateFilesResultMessage";
            this.F3lblGenerateFilesResultMessage.Size = new System.Drawing.Size(0, 20);
            this.F3lblGenerateFilesResultMessage.TabIndex = 4;
            // 
            // F3lblFaltaFilePath
            // 
            this.F3lblFaltaFilePath.AutoSize = true;
            this.F3lblFaltaFilePath.Location = new System.Drawing.Point(92, 162);
            this.F3lblFaltaFilePath.Name = "F3lblFaltaFilePath";
            this.F3lblFaltaFilePath.Size = new System.Drawing.Size(45, 20);
            this.F3lblFaltaFilePath.TabIndex = 3;
            this.F3lblFaltaFilePath.Text = "Falta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sobra";
            // 
            // F3lbDummyFolderPath
            // 
            this.F3lbDummyFolderPath.AutoSize = true;
            this.F3lbDummyFolderPath.Location = new System.Drawing.Point(67, 88);
            this.F3lbDummyFolderPath.Name = "F3lbDummyFolderPath";
            this.F3lbDummyFolderPath.Size = new System.Drawing.Size(76, 20);
            this.F3lbDummyFolderPath.TabIndex = 1;
            this.F3lbDummyFolderPath.Text = "Dummies";
            // 
            // F3lbListFilePath
            // 
            this.F3lbListFilePath.AutoSize = true;
            this.F3lbListFilePath.Location = new System.Drawing.Point(100, 51);
            this.F3lbListFilePath.Name = "F3lbListFilePath";
            this.F3lbListFilePath.Size = new System.Drawing.Size(43, 20);
            this.F3lbListFilePath.TabIndex = 0;
            this.F3lbListFilePath.Text = "Lista";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1044, 493);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mover archivos que coinciden";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1044, 493);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Mover archivos que NO coinciden";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 563);
            this.Controls.Add(this.F1TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.F1TabControl.ResumeLayout(false);
            this.F1Tab.ResumeLayout(false);
            this.F1Tab.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl F1TabControl;
        private System.Windows.Forms.TabPage F1Tab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox F1tbFileXML;
        private System.Windows.Forms.Button F1btnBrowseFileXML;
        private System.Windows.Forms.OpenFileDialog F1ofdFileXMLPath;
        private System.Windows.Forms.Label F1lbGenerateList;
        private System.Windows.Forms.Button F1btnBrowseGenerateList;
        private System.Windows.Forms.TextBox F1tbGenerateList;
        private System.Windows.Forms.Button F1btnGenerateList;
        private System.Windows.Forms.Label F1lblGenerateListResultMessage;
        private System.Windows.Forms.Label F2lblDummyFolder;
        private System.Windows.Forms.Label F2lblListPath;
        private System.Windows.Forms.TextBox F2tbListFilePath;
        private System.Windows.Forms.TextBox F2tbDummyFolderPath;
        private System.Windows.Forms.Button F2btnBrowseDummyPath;
        private System.Windows.Forms.Button F2btnBrowseListFile;
        private System.Windows.Forms.Button F2btnGenerateDummies;
        private System.Windows.Forms.SaveFileDialog F1ofdListPath;
        private System.Windows.Forms.OpenFileDialog F2ofdListFilePath;
        private System.Windows.Forms.Label F2lblGenerateDummiesResultMessage;
        private System.Windows.Forms.FolderBrowserDialog F2ofdDummyFolderPath2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button F3btnFaltaFilePath;
        private System.Windows.Forms.Button F3btnSobraFilePath;
        private System.Windows.Forms.Button F3btnListFilePath;
        private System.Windows.Forms.TextBox F3tbFaltaFilePath;
        private System.Windows.Forms.TextBox F3tbSobraFilePath;
        private System.Windows.Forms.TextBox F3tbDummyFolderPath;
        private System.Windows.Forms.TextBox F3tbListFilePath;
        private System.Windows.Forms.Label F3lblGenerateFilesResultMessage;
        private System.Windows.Forms.Label F3lblFaltaFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label F3lbDummyFolderPath;
        private System.Windows.Forms.Label F3lbListFilePath;
        private System.Windows.Forms.Button F3btnDummyFolderPath;
        private System.Windows.Forms.OpenFileDialog F3ofdListPath;
        private System.Windows.Forms.FolderBrowserDialog F3ofdDummyFolderPath;
        private System.Windows.Forms.SaveFileDialog F3osdSobraPath;
        private System.Windows.Forms.SaveFileDialog F3osdFaltaPath;
        private System.Windows.Forms.FolderBrowserDialog F2ofdDummyFolderPath;
    }
}

