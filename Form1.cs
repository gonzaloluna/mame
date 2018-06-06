﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string F1FileXMLPath;
        private string F1ListFilePath;

        private string F2ListFilePath;
        private string F2DummyFolderPath;

        public Form1()
        {
            InitializeComponent();
        }

        #region function1

        private void F1btnBrowseFileXML_Click(object sender, EventArgs e)
        {
            F1lblGenerateListResultMessage.Text = "";
            DialogResult result = F1ofdFileXMLPath.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                F1FileXMLPath = F1ofdFileXMLPath.FileName;
                F1tbFileXML.Text = F1FileXMLPath;
            }
        }
        private void updateArchivoXML(object sender, EventArgs e)
        {
            F1lblGenerateListResultMessage.Text = "";
            F1tbFileXML.Text = ((TextBox)sender).Text;
            F1FileXMLPath = F1tbFileXML.Text;
        }

        private void updateLista(object sender, EventArgs e)
        {
            F1lblGenerateListResultMessage.Text = "";
            F1tbGenerateList.Text = ((TextBox)sender).Text;
            F1ListFilePath = F1tbGenerateList.Text;
        }

        private void F1btnBrowseGenerateList_Click(object sender, EventArgs e)
        {
            F1lblGenerateListResultMessage.Text = "";
            DialogResult result = F1ofdListPath.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                F1ListFilePath = F1ofdListPath.FileName;
                F1tbGenerateList.Text = F1ListFilePath;
            }
        }

        private void F1btnGenerateList_Click(object sender, EventArgs e)
        {
            MameLibrary.Util.Funcionalidad1(F1FileXMLPath, F1ListFilePath);
            F1lblGenerateListResultMessage.Text = String.Format("{0} Generado!", new FileInfo(F1ListFilePath).Name);

        }

        #endregion

        private void F2btnBrowseListFile_Click(object sender, EventArgs e)
        {
            F2lblGenerateDummiesResultMessage.Text = "";
            DialogResult result = F2ofdListFilePath.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                F2ListFilePath = F2ofdListFilePath.FileName;
                F2tbListFilePath.Text = F2ListFilePath;
            }
        }

        private void F2btnBrowseDummyPath_Click(object sender, EventArgs e)
        {
            F2lblGenerateDummiesResultMessage.Text = "";
            DialogResult result = F2ofdDummyFolderPath.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                F2DummyFolderPath = F2ofdDummyFolderPath.SelectedPath;
                F2tbDummyFolderPath.Text = F2DummyFolderPath;
            }
        }

        private void F2btnGenerateDummies_Click(object sender, EventArgs e)
        {
            F2lblGenerateDummiesResultMessage.Text = "Generando dummies, aguanta..";
            MameLibrary.Util.Funcionalidad2(F2ListFilePath, F2DummyFolderPath);
            F2lblGenerateDummiesResultMessage.Text = String.Format("Dummies generados en {0}", F2DummyFolderPath);

        }
    }
}
